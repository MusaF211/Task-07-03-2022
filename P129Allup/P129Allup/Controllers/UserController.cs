using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P129Allup.Controllers
{
    [Area("manage")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        public ActionResult ForgotPassword()
        {
            return View();
        }

    }
}
