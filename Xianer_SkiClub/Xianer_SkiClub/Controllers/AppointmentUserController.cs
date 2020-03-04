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
    public class AppointmentUserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AppointmentUserController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AppointmentUser
        public async Task<IActionResult> Index()
        {
            return View(await _context.AppointmentUser.ToListAsync());
        }

        // GET: AppointmentUser/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointmentUser = await _context.AppointmentUser
                .FirstOrDefaultAsync(m => m.appointmentUserId == id);
            if (appointmentUser == null)
            {
                return NotFound();
            }

            return View(appointmentUser);
        }

        // GET: AppointmentUser/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AppointmentUser/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("appointmentUserId,applicationUserId,appointmentId")] AppointmentUser appointmentUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appointmentUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(appointmentUser);
        }

        // GET: AppointmentUser/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointmentUser = await _context.AppointmentUser.FindAsync(id);
            if (appointmentUser == null)
            {
                return NotFound();
            }
            return View(appointmentUser);
        }

        // POST: AppointmentUser/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("appointmentUserId,applicationUserId,appointmentId")] AppointmentUser appointmentUser)
        {
            if (id != appointmentUser.appointmentUserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appointmentUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppointmentUserExists(appointmentUser.appointmentUserId))
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
            return View(appointmentUser);
        }

        // GET: AppointmentUser/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointmentUser = await _context.AppointmentUser
                .FirstOrDefaultAsync(m => m.appointmentUserId == id);
            if (appointmentUser == null)
            {
                return NotFound();
            }

            return View(appointmentUser);
        }

        // POST: AppointmentUser/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var appointmentUser = await _context.AppointmentUser.FindAsync(id);
            _context.AppointmentUser.Remove(appointmentUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppointmentUserExists(int id)
        {
            return _context.AppointmentUser.Any(e => e.appointmentUserId == id);
        }
    }
}
