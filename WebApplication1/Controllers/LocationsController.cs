using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MasteryQuestHSSite.Controllers
{
    public class LocationsController : Controller
    {
        public IActionResult LocationSouthBay()
        {
            return View();
        }

        public IActionResult LocationBaldwinHills()
        {
            return View();
        }

        public IActionResult CreateGroup()
        {
            return View();
        }



        
    }
}
