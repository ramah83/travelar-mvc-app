using Microsoft.AspNetCore.Mvc;
using TeamLID.TravelExperts.Repository.Domain;
using System.Linq;
using TeamLID.TravelExperts.App.Models;

namespace TeamLID.TravelExperts.App.Controllers
{
    public class DashboardsController : Controller
    {
        private readonly TravelExpertsContext _context;

        public DashboardsController(TravelExpertsContext context)
        {
            _context = context;
        }

        public IActionResult DefaultDashboard()
        {
            var model = new DashboardViewModel
            {
                TotalCustomers = _context.Customers.Count(),
                TotalBookings = _context.Bookings.Count(),
                TotalAgents = _context.Agents.Count(),
                TotalPackages = _context.Packages.Count()
            };

            model.BookingsByDestination = _context.Bookings
                .Where(b => b.PackageId != null)
                .Select(b => b.Package.PkgName)
                .AsEnumerable()
                .GroupBy(pkg => pkg)
                .OrderByDescending(g => g.Count())
                .Take(5)
                .ToDictionary(g => g.Key, g => g.Count());

            var lastSixMonths = DateTime.Now.AddMonths(-5);

            model.Months = Enumerable.Range(0, 6)
                .Select(i => lastSixMonths.AddMonths(i).ToString("MMM"))
                .ToList();

            model.NewCustomersPerMonth = Enumerable.Range(0, 6)
      .Select(i =>
      {
          var month = lastSixMonths.AddMonths(i).Month;
          var year = lastSixMonths.AddMonths(i).Year;
          return _context.Customers
              .Where(c => c.Bookings.Any(b =>
                  b.BookingDate.HasValue &&
                  b.BookingDate.Value.Year == year &&
                  b.BookingDate.Value.Month == month))
              .Count();
      })
      .ToList();

            return View(model);
        }
    }
}
