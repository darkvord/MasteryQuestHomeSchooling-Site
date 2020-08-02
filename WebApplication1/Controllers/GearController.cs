using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MasteryQuestHSSite.Controllers
{
    public class GearController : Controller
    {
        public IActionResult GearOrdering()
        {
            return View();
        }
        public IActionResult MasteryQuest()
        {
            return View();
        }
        public IActionResult SaberGames()
        {
            return View();
        }

    }
}
