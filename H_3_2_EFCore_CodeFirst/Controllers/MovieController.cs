using H_3_2_EFCore_CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H_3_2_EFCore_CodeFirst.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieContext _context=null;

        public MovieController(MovieContext context) 
        {
            _context=context;
        }

       

        public async Task<IActionResult> Add()
        {
            ViewBag.Categories = await _context.Categories.ToListAsync();
            return View();
        }

        [HttpPost]
        public IActionResult Add(MovieViewModel model)
        {
            return View();
        }
    }
}
