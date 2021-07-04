using H_3_2_EFCore_CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H_3_2_EFCore_CodeFirst.Controllers
{
    public class CategoryController : Controller
    {
        private readonly MovieContext _context = null;
        public CategoryController(MovieContext context)
        {
            _context = context;
        }
        public IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CategoryAdd(Category category)
        {
            await _context.Categories.AddAsync(category);

            await _context.SaveChangesAsync();

            return RedirectToAction("Add","Movie");
        }
    }
}
