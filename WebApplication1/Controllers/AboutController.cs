using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MasteryQuestHSSite.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult TheQuest()
        {            
            return View();
        }
        public IActionResult Approach()
        {
            return View();
        }
        public IActionResult Assessment()
        {
            return View();
        }

    }
}
