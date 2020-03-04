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
    public class GroupUserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GroupUserController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: GroupUser
        public async Task<IActionResult> Index()
        {
            return View(await _context.GroupUser.ToListAsync());
        }

        // GET: GroupUser/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupUser = await _context.GroupUser
                .FirstOrDefaultAsync(m => m.groupUserId == id);
            if (groupUser == null)
            {
                return NotFound();
            }

            return View(groupUser);
        }

        // GET: GroupUser/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GroupUser/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("groupUserId,groupId,userId")] GroupUser groupUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(groupUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(groupUser);
        }

        // GET: GroupUser/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupUser = await _context.GroupUser.FindAsync(id);
            if (groupUser == null)
            {
                return NotFound();
            }
            return View(groupUser);
        }

        // POST: GroupUser/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("groupUserId,groupId,userId")] GroupUser groupUser)
        {
            if (id != groupUser.groupUserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(groupUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GroupUserExists(groupUser.groupUserId))
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
            return View(groupUser);
        }

        // GET: GroupUser/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupUser = await _context.GroupUser
                .FirstOrDefaultAsync(m => m.groupUserId == id);
            if (groupUser == null)
            {
                return NotFound();
            }

            return View(groupUser);
        }

        // POST: GroupUser/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var groupUser = await _context.GroupUser.FindAsync(id);
            _context.GroupUser.Remove(groupUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GroupUserExists(int id)
        {
            return _context.GroupUser.Any(e => e.groupUserId == id);
        }
    }
}
