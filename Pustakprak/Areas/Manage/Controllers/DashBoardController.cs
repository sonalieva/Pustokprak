using Microsoft.AspNetCore.Mvc;
using Pustakprak.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pustakprak.Areas.Manage.Controllers
{
   
    public class DashBoardController : Controller
    {

        [Area("Manage")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
