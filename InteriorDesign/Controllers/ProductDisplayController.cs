using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InteriorDesign.Data;
using Microsoft.AspNetCore.Mvc;

namespace InteriorDesign.Controllers
{
    public class ProductDisplayController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductDisplayController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Categories =  _context.Categories.OrderBy(b => b.Areas).ToList();
            return View(Categories);
        }
    }
}
