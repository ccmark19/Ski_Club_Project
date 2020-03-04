using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Xianer_SkiClub.Data;
using Xianer_SkiClub.Models;

namespace Xianer_SkiClub.Controllers
{
    public class ScheduleAppointmentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ScheduleAppointmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ScheduleAppointment
        public async Task<IActionResult> Index()
        {
            return View(await _context.ScheduleAppointment.ToListAsync());
        }

        // GET: ScheduleAppointment/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scheduleAppointment = await _context.ScheduleAppointment
                .FirstOrDefaultAsync(m => m.scheduleAppointmentId == id);
            if (scheduleAppointment == null)
            {
                return NotFound();
            }

            return View(scheduleAppointment);
        }

        // GET: ScheduleAppointment/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ScheduleAppointment/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("scheduleAppointmentId,scheduleId,appointmentId")] ScheduleAppointment scheduleAppointment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(scheduleAppointment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(scheduleAppointment);
        }

        // GET: ScheduleAppointment/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scheduleAppointment = await _context.ScheduleAppointment.FindAsync(id);
            if (scheduleAppointment == null)
            {
                return NotFound();
            }
            return View(scheduleAppointment);
        }

        // POST: ScheduleAppointment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("scheduleAppointmentId,scheduleId,appointmentId")] ScheduleAppointment scheduleAppointment)
        {
            if (id != scheduleAppointment.scheduleAppointmentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(scheduleAppointment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScheduleAppointmentExists(scheduleAppointment.scheduleAppointmentId))
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
            return View(scheduleAppointment);
        }

        // GET: ScheduleAppointment/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scheduleAppointment = await _context.ScheduleAppointment
                .FirstOrDefaultAsync(m => m.scheduleAppointmentId == id);
            if (scheduleAppointment == null)
            {
                return NotFound();
            }

            return View(scheduleAppointment);
        }

        // POST: ScheduleAppointment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var scheduleAppointment = await _context.ScheduleAppointment.FindAsync(id);
            _context.ScheduleAppointment.Remove(scheduleAppointment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScheduleAppointmentExists(int id)
        {
            return _context.ScheduleAppointment.Any(e => e.scheduleAppointmentId == id);
        }
    }
}
