using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TeamLID.TravelExperts.Repository.Domain;

namespace TeamLID.TravelExperts.App.Controllers
{
    public class AgentsController : Controller
    {
        private readonly TravelExpertsContext _context;

        public AgentsController(TravelExpertsContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var agents = await _context.Agents.Include(a => a.Agency).ToListAsync();
            return View(agents);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var agent = await _context.Agents
                .Include(a => a.Agency)
                .FirstOrDefaultAsync(m => m.AgentId == id);

            if (agent == null)
                return NotFound();

            return View(agent);
        }

        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("IsAdmin") != "true")
            {
                return RedirectToAction(nameof(Index));
            }

            ViewData["AgencyId"] = new SelectList(_context.Agencies, "AgencyId", "AgencyId");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AgtFirstName,AgtMiddleInitial,AgtLastName,AgtBusPhone,AgtEmail,AgtPosition,AgencyId")] Agents agent)
        {
            if (HttpContext.Session.GetString("IsAdmin") != "true")
            {
                return RedirectToAction(nameof(Index));
            }

            if (ModelState.IsValid)
            {
                _context.Add(agent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AgencyId"] = new SelectList(_context.Agencies, "AgencyId", "AgencyId", agent.AgencyId);
            return View(agent);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (HttpContext.Session.GetString("IsAdmin") != "true")
            {
                return RedirectToAction(nameof(Index));
            }

            if (id == null)
                return NotFound();

            var agent = await _context.Agents.FindAsync(id);
            if (agent == null)
                return NotFound();

            ViewData["AgencyId"] = new SelectList(_context.Agencies, "AgencyId", "AgencyId", agent.AgencyId);
            return View(agent);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AgentId,AgtFirstName,AgtMiddleInitial,AgtLastName,AgtBusPhone,AgtEmail,AgtPosition,AgencyId")] Agents agent)
        {
            if (HttpContext.Session.GetString("IsAdmin") != "true")
            {
                return RedirectToAction(nameof(Index));
            }

            if (id != agent.AgentId)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    var agentInDb = await _context.Agents.FindAsync(id);
                    if (agentInDb == null)
                        return NotFound();

                    agentInDb.AgtFirstName = agent.AgtFirstName;
                    agentInDb.AgtMiddleInitial = agent.AgtMiddleInitial;
                    agentInDb.AgtLastName = agent.AgtLastName;
                    agentInDb.AgtBusPhone = agent.AgtBusPhone;
                    agentInDb.AgtEmail = agent.AgtEmail;
                    agentInDb.AgtPosition = agent.AgtPosition;
                    agentInDb.AgencyId = agent.AgencyId;

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AgentsExists(agent.AgentId))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AgencyId"] = new SelectList(_context.Agencies, "AgencyId", "AgencyId", agent.AgencyId);
            return View(agent);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (HttpContext.Session.GetString("IsAdmin") != "true")
            {
                return RedirectToAction(nameof(Index));
            }

            if (id == null)
                return NotFound();

            var agent = await _context.Agents
                .Include(a => a.Agency)
                .FirstOrDefaultAsync(m => m.AgentId == id);

            if (agent == null)
                return NotFound();

            return View(agent);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (HttpContext.Session.GetString("IsAdmin") != "true")
            {
                return RedirectToAction(nameof(Index));
            }

            var agent = await _context.Agents.FindAsync(id);

            if (agent != null)
            {
                var relatedCustomers = await _context.Customers
                    .Where(c => c.AgentId == id)
                    .ToListAsync();

                foreach (var customer in relatedCustomers)
                {
                    customer.AgentId = null; 
                }

                _context.Agents.Remove(agent);

                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }


        private bool AgentsExists(int id)
        {
            return _context.Agents.Any(e => e.AgentId == id);
        }
    }
}
