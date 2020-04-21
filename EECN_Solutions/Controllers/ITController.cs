using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EECN_Solutions.Controllers
{
    public class ITController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}