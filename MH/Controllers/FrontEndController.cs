using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MH.Controllers
{
    public class FrontEndController : Controller
    {
        public IActionResult FrontEndTesting()
        {
            return View("FrontEndTest");
        }
    }
}