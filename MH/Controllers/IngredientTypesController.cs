using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MH.Data;
using MH.Models;
using NToastNotify;

namespace MH.Controllers
{
    public class IngredientTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IngredientTypesController(ApplicationDbContext context, IToastNotification toastNotification)
        {
            _context = context;
            _toastNotification = toastNotification;
        }
        private readonly IToastNotification _toastNotification;

        //public IngredientTypesController(IToastNotification toastNotification)
        //{
        //    _toastNotification = toastNotification;
        //}



        // GET: IngredientTypes
        public async Task<IActionResult> Index()
        {
            _toastNotification.AddSuccessToastMessage("Same for success message");
            return View(await _context.IngredientType.ToListAsync());
        }

        // GET: IngredientTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingredientType = await _context.IngredientType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ingredientType == null)
            {
                return NotFound();
            }
            _toastNotification.AddInfoToastMessage(ingredientType.Name);
            return View(ingredientType);
        }

        public void ShowMessage()
        {
            _toastNotification.AddInfoToastMessage("test");
        }



        // GET: IngredientTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: IngredientTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] IngredientType ingredientType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ingredientType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ingredientType);
        }

        // GET: IngredientTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingredientType = await _context.IngredientType.FindAsync(id);
            if (ingredientType == null)
            {
                return NotFound();
            }
            return View(ingredientType);
        }

        // POST: IngredientTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] IngredientType ingredientType)
        {
            if (id != ingredientType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ingredientType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IngredientTypeExists(ingredientType.Id))
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
            return View(ingredientType);
        }

        // GET: IngredientTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingredientType = await _context.IngredientType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ingredientType == null)
            {
                return NotFound();
            }

            return View(ingredientType);
        }

        // POST: IngredientTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ingredientType = await _context.IngredientType.FindAsync(id);
            _context.IngredientType.Remove(ingredientType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IngredientTypeExists(int id)
        {
            return _context.IngredientType.Any(e => e.Id == id);
        }
    }
}
