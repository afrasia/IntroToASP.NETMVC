using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using IntroductionToASP.NETMVCCore.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace IntroductionToASP.NETMVCCore.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Razor()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateSession()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DisplaySession()
        {
            HttpContext.Session.SetString("emailAddress", Request.Form["emailAddress"]);
            HttpContext.Session.SetString("password", Request.Form["password"]); // note you probably wouldn't normally save this value

            return View();
        }

        public IActionResult CreateViewData()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DisplayViewData()
        {
            ViewBag.emailAddress = Request.Form["emailAddress"];
            ViewData["password"] = Request.Form["password"]; // note you probably wouldn't normally save this value

            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DisplayForm(LoginInformationModel model)
        {
            return View(model);
        }

        [HttpGet]
        public IActionResult DisplayDynamicForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DisplayDynamicFormData()
        {
            var res = Request.Form["personDropDown"].ToString();
            if (res.Equals("Student"))
            {
                return DisplayDynamicStudent();
            }
            else
            {
                return DisplayDynamicTeacher();
            }
        }


        [HttpPost]
        public IActionResult DisplayDynamicStudent()
        {
            return View("DisplayDynamic",
                new Student
                {
                    Name = "John",
                    StudentId = "1"
                });
        }

        [HttpPost]
        public IActionResult DisplayDynamicTeacher()
        {
            return View("DisplayDynamic",
                new Teacher
                {
                    Name = "Amir",
                    EmployeeId = "1"
                });
        }
    }
}
