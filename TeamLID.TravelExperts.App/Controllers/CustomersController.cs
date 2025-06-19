
using lf_egypt.App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TeamLID.TravelExperts.App.Models;
using TeamLID.TravelExperts.App.Models.DataManager;
using TeamLID.TravelExperts.Repository.Domain;

namespace TeamLID.TravelExperts.App.Controllers
{
    public class CustomersController : Controller
    {
        private readonly TravelExpertsContext _context;

        public CustomersController(TravelExpertsContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ViewResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserViewModel user)
        {
            if (!ValidateUser(user))
            {
                ViewBag.msg = "validation failed, please fill in valid information and try again.";
                return View("Register", user);
            }
            else
            {
                var newCust = new Customers
                {
                    CustLastName = user.CustLastName,
                    CustFirstName = user.CustFirstName,
                    CustBusPhone = Regex.Replace(user.CustBusPhone,@"[-.]","") ,  
                    CustPostal = user.CustPostal.Replace('-',' ').ToUpper(),  
                    CustHomePhone = user.CustHomePhone != null ? Regex.Replace(user.CustHomePhone, @"[-.]", "") : null,
                    CustAddress = user.CustAddress,
                    CustCity = user.CustCity,
                    CustCountry = user.CustCountry,
                    CustEmail = user.CustEmail,
                    CustProv = user.CustProv.ToUpper(),  
                    Password = user.Password,
                    Username = user.Username
                };
                try
                {
                    await CustomerProfileManager.Add(newCust);
                    ViewBag.success = "Congratulations! Your account is active now, please log in.";
                    return View("Login");
                }
                catch (Exception e)
                {
                    ViewBag.msg = "username is already in use, please login.";
                    ViewBag.reason = e.InnerException.Message;  
                    return View("Register", user);
                }
            }
        }

        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel login, string returnUrl = null)
        {
            if (login.username == "admin" && login.password == "admin123")
            {
                var adminCustomer = new Customers
                {
                    CustomerId = 0,
                    CustFirstName = "Admin",
                    CustLastName = "User",
                    CustEmail = "admin@system.com",
                    CustHomePhone = "N/A",
                    CustBusPhone = "N/A",
                    CustAddress = "Admin Control",
                    CustCity = "System",
                    CustProv = "AdminLand",
                    CustPostal = "00000",
                    CustCountry = "AdminCountry",
                    Username = "admin",
                    IsAdmin = true
                };

                HttpContext.Session.SetString("IsAdmin", "true");
                HttpContext.Session.SetString("Username", login.username);
                HttpContext.Session.SetObject("login", adminCustomer);
                HttpContext.Session.SetInt32("CustomerId", 0);

                return RedirectToAction("DefaultDashboard", "Dashboards");
            }

            var cust = await CustomerProfileManager.CompareLogin(login.username, login.password);

            if (cust != null)
            {
                HttpContext.Session.SetObject("login", cust);
                HttpContext.Session.SetInt32("CustomerId", cust.CustomerId);
                HttpContext.Session.SetString("Username", cust.Username);
                HttpContext.Session.SetString("IsAdmin", cust.IsAdmin ? "true" : "false");

                if (!string.IsNullOrEmpty(returnUrl))
                {
                    return Redirect(returnUrl);
                }

                if (cust.IsAdmin)
                {
                    return RedirectToAction("DefaultDashboard", "Dashboards");
                }

                return RedirectToAction("CustomerHistory", "Customers");
            }
            else
            {
                ViewBag.msg = "Sorry, username or password is invalid.";
                ViewData["ReturnUrl"] = returnUrl;
                return View("Login");
            }
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customers.FindAsync(id);

            if (customer != null)
            {
                if (customer.IsAdmin)
                {
                    int adminCount = _context.Customers.Count(c => c.IsAdmin);
                    if (adminCount <= 1)
                    {
                        TempData["Error"] = "لا يمكنك حذف آخر أدمن في النظام. الرجاء تعيين أدمن آخر أولاً.";
                        return RedirectToAction("Index");
                    }
                }

                var bookings = _context.Bookings.Where(b => b.CustomerId == id);
                _context.Bookings.RemoveRange(bookings);

                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> PromoteMe()
        {
            var customer = HttpContext.Session.GetObject<Customers>("login");

            if (customer == null) return RedirectToAction("Login");

            var dbUser = await _context.Customers.FindAsync(customer.CustomerId);
            if (dbUser == null) return RedirectToAction("Login");

            dbUser.IsAdmin = true;
            await _context.SaveChangesAsync();

            HttpContext.Session.SetString("IsAdmin", "true");

            return RedirectToAction("Profile");
        }
        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendResetPasswordUrl(string email)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.CustEmail == email);
            if (customer != null)
            {
                var token = Guid.NewGuid().ToString();
                TempData["ResetToken"] = token;
                TempData["Email"] = email;

                var resetUrl = Url.Action("ResetPassword", "Customers", new { email, token }, Request.Scheme);

                ViewBag.success = "Reset link has been generated.";
                ViewBag.ResetUrl = resetUrl;
                return View("ForgetPassword");
            }
            ViewBag.msg = "No account found with this email.";
            return View("ForgetPassword");
        }
        [HttpGet]
        public IActionResult ResetPassword(string email, string token)
        {
            var model = new ResetPasswordViewModel
            {
                Email = email,
                Token = token
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var customer = _context.Customers.FirstOrDefault(c => c.CustEmail == model.Email);
            if (customer != null)
            {
                customer.Password = model.NewPassword;
                _context.Update(customer);
                await _context.SaveChangesAsync();
                ViewBag.success = "Password reset successful. Please login.";
                return RedirectToAction("Login");
            }

            ViewBag.msg = "Invalid reset request.";
            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Customers");
        }



        public IActionResult Profile()
        {
            var customer = HttpContext.Session.GetObject<Customers>("login");

            if (customer == null)
            {
                return RedirectToAction("Login");
            }

            if (customer.CustomerId == 0 && HttpContext.Session.GetString("IsAdmin") == "true")
            {
                customer = new Customers
                {
                    CustomerId = 0,
                    CustFirstName = "Admin",
                    CustLastName = "User",
                    CustEmail = "admin@system.com",
                    CustHomePhone = "N/A",
                    CustBusPhone = "N/A",
                    CustAddress = "Admin Control",
                    CustCity = "System",
                    CustProv = "AdminLand",
                    CustPostal = "00000",
                    CustCountry = "AdminCountry",
                    Username = "admin",
                    Password = "********"
                };
            }

            return View(customer);
        }


        public ActionResult CustomerHistory()
        {
            var cust = HttpContext.Session.GetObject<Customers>("login");

            if (cust != null)
            {
                int id = cust.CustomerId;

                var bookings = BookingsManager.GetAllBookingsByCustomer(id)
                    .Select(bk => new BookingsModel
                    {
                        BookingId = bk.BookingId,
                        BookingDate = bk.BookingDate ?? DateTime.MinValue,
                        BookingNo = bk.BookingNo,
                        TravelerCount = bk.TravelerCount ?? 0,
                        CustomerId = bk.Customer.CustFirstName,
                        TripTypeId = bk.TripType.Ttname,
                        PackageId = bk.Package.PkgName,
                        Price = Math.Round((decimal)((bk.Package?.PkgBasePrice ?? 0) + (bk.Package?.PkgAgencyCommission ?? 0)), 0)
                    })
                    .ToList();

                return View(bookings);
            }
            else
            {
                return RedirectToAction("Login", "Customers");
            }
        }

        [HttpPost]
        public async Task<IActionResult> RequestAdmin()
        {
            var customer = HttpContext.Session.GetObject<Customers>("login");

            if (customer == null)
                return RedirectToAction("Login");

            var dbUser = await _context.Customers.FindAsync(customer.CustomerId);
            if (dbUser == null)
                return RedirectToAction("Login");

            dbUser.WantsAdmin = true;
            await _context.SaveChangesAsync();

            return RedirectToAction("Profile");
        }
        public IActionResult AdminRequests()
        {
            var isAdmin = HttpContext.Session.GetString("IsAdmin");

            if (isAdmin != "true")
                return RedirectToAction("Login");

            var requests = _context.Customers
                .Where(c => c.WantsAdmin && !c.IsAdmin)
                .ToList();

            return View(requests);
        }

        [HttpPost]
        public async Task<IActionResult> ApproveAdmin(int id)
        {
            var user = await _context.Customers.FindAsync(id);
            if (user != null)
            {
                user.IsAdmin = true;
                user.WantsAdmin = false;
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("AdminRequests");
        }
        public ActionResult BookingDetail(int id)
        {
            var booking = BookingsManager.Find(id);

            var a = new BookingsModel
            {
                BookingId = booking.BookingId,
                BookingNo = booking.BookingNo,
                PkgStartDate = booking.Package.PkgStartDate,
                PkgEndDate = booking.Package.PkgEndDate,
                TravelerCount = booking.TravelerCount,
                CustomerId = booking.Customer.CustFirstName,
                TripTypeId = booking.TripType.Ttname,
                PkgDesc = booking.Package.PkgDesc,
                PackageId = booking.Package.PkgName,
                Price = Math.Round((booking.Package.PkgBasePrice + (booking.Package.PkgAgencyCommission ?? 0)) * Convert.ToDecimal(booking.TravelerCount), 0)
            };

            return View(a);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (id == 0 && HttpContext.Session.GetString("IsAdmin") == "true")
            {
                var adminCustomer = new Customers
                {
                    CustomerId = 0,
                    CustFirstName = "Admin",
                    CustLastName = "User",
                    CustEmail = "admin@system.com",
                    CustHomePhone = "N/A",
                    CustBusPhone = "N/A",
                    CustAddress = "Admin Control",
                    CustCity = "System",
                    CustProv = "AdminLand",
                    CustPostal = "00000",
                    CustCountry = "AdminCountry",
                    Username = "admin",
                    Password = "********"
                };

                return View(adminCustomer);
            }

            var customers = await _context.Customers.FindAsync(id);
            if (customers == null)
            {
                return NotFound();
            }

            ViewData["AgentId"] = new SelectList(_context.Agents, "AgentId", "AgentId", customers.AgentId);
            return View(customers);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,CustFirstName,CustLastName,CustAddress,CustCity,CustProv,CustPostal,CustCountry,CustHomePhone,CustBusPhone,CustEmail,AgentId,Username,Password")] Customers customers)
        {
            if (id != customers.CustomerId)
            {
                return NotFound();
            }

            if (id == 0 && HttpContext.Session.GetString("IsAdmin") == "true")
            {
                HttpContext.Session.SetObject("login", customers);
                return RedirectToAction(nameof(Profile));
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customers);
                    await _context.SaveChangesAsync();

                    HttpContext.Session.SetObject("login", customers);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomersExists(customers.CustomerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Profile));
            }

            ViewData["AgentId"] = new SelectList(_context.Agents, "AgentId", "AgentId", customers.AgentId);
            return View(customers);
        }
        private bool ValidateUser(UserViewModel user)
        {
            bool isValid = true;
            var phoneRegex = @"^(010|011|012|015)[0-9]{8}$";
            var zipRegex = @"^\d{5}$";

            if (user.CustLastName == "" || user.CustFirstName == "" ||
                user.Password != user.PasswordConfirm ||
                !Regex.IsMatch(user.CustBusPhone, phoneRegex) ||
                !Regex.IsMatch(user.CustPostal, zipRegex))
            {
                isValid = false;
            }

            return isValid;
        }


        public decimal TotalOwing(decimal amount)
        {
            decimal total = 0;

            total += amount;

            return total;
        }


        public async Task<IActionResult> Index()
        {
            var travelExpertsContext = _context.Customers.Include(c => c.Agent);
            return View(await travelExpertsContext.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customers = await _context.Customers
                .Include(c => c.Agent)
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customers == null)
            {
                return NotFound();
            }

            return View(customers);
        }
        public IActionResult Create()
        {
            ViewData["AgentId"] = new SelectList(_context.Agents, "AgentId", "AgentId");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,CustFirstName,CustLastName,CustAddress,CustCity,CustProv,CustPostal,CustCountry,CustHomePhone,CustBusPhone,CustEmail,AgentId,Username,Password")] Customers customers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AgentId"] = new SelectList(_context.Agents, "AgentId", "AgentId", customers.AgentId);
            return View(customers);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customers = await _context.Customers
                .Include(c => c.Agent)
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customers == null)
            {
                return NotFound();
            }

            return View(customers);
        }
        [HttpPost]
        public async Task<IActionResult> RevokeMyAdminRole()
        {
            var customer = HttpContext.Session.GetObject<Customers>("login");

            if (customer == null || !customer.IsAdmin || customer.Username == "admin")
                return RedirectToAction("Profile");

            var dbUser = await _context.Customers.FindAsync(customer.CustomerId);
            if (dbUser != null)
            {
                dbUser.IsAdmin = false;
                await _context.SaveChangesAsync();

                HttpContext.Session.SetString("IsAdmin", "false");
                HttpContext.Session.SetObject("login", dbUser); 
            }

            return RedirectToAction("Profile");
        }
        [HttpPost]
        public async Task<IActionResult> RevokeAdmin(int id)
        {
            var currentUsername = HttpContext.Session.GetString("Username");

            if (currentUsername != "admin")
                return Unauthorized();

            var user = await _context.Customers.FindAsync(id);
            if (user != null && user.IsAdmin)
            {
                user.IsAdmin = false;
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }
        private bool CustomersExists(int id)
        {
            return _context.Customers.Any(e => e.CustomerId == id);
        }
    }
}
