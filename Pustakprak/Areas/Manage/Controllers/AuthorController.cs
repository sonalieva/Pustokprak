using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustakprak.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pustakprak.Areas.Manage.Controllers
{
    [Area("manage")]
    public class AuthorController : Controller
    {
        private readonly AppDbContext _context;

        public AuthorController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Authors.Include(x => x.Books).ToList();
            return View(data);
        }
    }
}
