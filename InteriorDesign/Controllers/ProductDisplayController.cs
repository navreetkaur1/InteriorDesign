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

        // GET: /Shop/Browse/3
        public IActionResult Browse(int id)
        {
            // query the db for the products in the selected
            var product = _context.Categories.Where(b => b.Id == id).OrderBy(b => b.Id).ToList();
            // load the Browse view & pass the list of products for display
            return View(product);

        }
    }
}
