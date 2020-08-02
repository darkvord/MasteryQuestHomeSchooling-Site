using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MasteryQuestHSSite.Controllers
{
    public class AcademicsController : Controller
    {
        public IActionResult Correculum()
        {
            return View();
        }
        public IActionResult EducationPaths()
        {
            return View();
        }
        public IActionResult EmotionalIntelligents()
        {
            return View();
        }
        public IActionResult Standards()
        {
            return View();
        }

    }
}
