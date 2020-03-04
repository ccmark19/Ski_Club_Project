using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Xianer_SkiClub.Data;
using Xianer_SkiClub.Models;
using System.Security.Claims;

namespace Xianer_SkiClub.Controllers
{
    
    public class ScheduleController : Controller
    {
        private readonly ApplicationDbContext _context;        

        public ScheduleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Schedule
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Schedule.Include(s => s.location);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Schedule/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {        
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedule
                .Include(s => s.location)
                .FirstOrDefaultAsync(m => m.scheduleId == id);
            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }
        [Authorize(Roles = "Coach")]
        // GET: Schedule/Create
        public IActionResult Create(int? id)
        {
            if(id == null)
            {
                ViewData["locationId"] = new SelectList(_context.Location, "locationId", "locationDesc");                
            }
            else
            {
                ViewData["locationId"] = id;
            }
            
            return View();
        }

        // POST: Schedule/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Coach")]
        public async Task<IActionResult> Create([Bind("scheduleId,schedule_CoachId,startDate,endDate,createDate,createByEmployeeId,lastModifiedDate,lastModifiedByEmployeeId,locationId")] Schedule schedule)
        {
            try
            {
                var userId = this.User.FindFirst(ClaimTypes.Name).Value;
                schedule.createByEmployeeId = userId;
                ViewData["userId"] = userId;
                ViewData["CoachEmail"] = User.FindFirst(ClaimTypes.Name).Value;
                schedule.lastModifiedByEmployeeId = userId;
                schedule.createDate = DateTime.Now;
                schedule.lastModifiedDate = DateTime.Now;

                if (ModelState.IsValid)
                {
                    _context.Add(schedule);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                ViewData["locationId"] = new SelectList(_context.Location, "locationId", "locationId", schedule.locationId);
            }
            catch
            {

            }
            return View(schedule);
        }

        [Authorize(Roles = "Coach")]
        // GET: Schedule/Edit/5
        [Authorize(Roles = "Coach")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedule.FindAsync(id);
            if (schedule == null)
            {
                return NotFound();
            }
            ViewData["locationList"] = new SelectList(_context.Location, "locationId", "locationDesc", schedule.locationId);
            return View(schedule);
        }
        [Authorize(Roles = "Coach")]
        // POST: Schedule/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("scheduleId,schedule_CoachId,startDate,endDate,createDate,createByEmployeeId,lastModifiedDate,lastModifiedByEmployeeId,locationId")] Schedule schedule)
        {
            if (id != schedule.scheduleId)
            {
                return NotFound();
            }

            schedule.lastModifiedByEmployeeId = this.User.FindFirst(ClaimTypes.Name).Value;
            schedule.lastModifiedDate = DateTime.Now;

            //schedule.lastModifiedByEmployeeId = resultId;

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(schedule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScheduleExists(schedule.scheduleId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["locationId"] = new SelectList(_context.Location, "locationId", "locationDesc", schedule.locationId);
            return View(schedule);
        }

        // GET: Schedule/Delete/5
        [Authorize(Roles = "Coach")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedule
                .Include(s => s.location)
                .FirstOrDefaultAsync(m => m.scheduleId == id);
            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }

        // POST: Schedule/Delete/5
        [Authorize(Roles = "Coach")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var schedule = await _context.Schedule.FindAsync(id);
            _context.Schedule.Remove(schedule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool ScheduleExists(int id)
        {
            return _context.Schedule.Any(e => e.scheduleId == id);
        }
    }
}
