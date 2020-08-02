using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MasteryQuestHSSite.Controllers
{
    public class EnrollmentController : Controller
    {
        public IActionResult CharterSchools()
        {
            return View();
        }
        public IActionResult Courses()
        {
            return View();
        }
        public IActionResult PersonalPayments()
        {
            return View();
        }

    }
}
