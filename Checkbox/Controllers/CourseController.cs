using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Checkbox.Data;
using Checkbox.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Checkbox.Controllers
{
    public class CourseController : Controller
    {
        private ApplicationDbContext _context;

        public CourseController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var item = await _context.Course.ToListAsync();

            return View(item);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Course course)
        {
            _context.Course.Add(course);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Course");
        }
    }
}