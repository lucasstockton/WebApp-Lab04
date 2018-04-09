using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab04.Controllers
{
    public class Lab4Controller : Controller
    {
        public IActionResult Index()
        {

            var myTime = DateTime.Now;
        //    var myDate = DateTime.Now.ToString("D");

            //View

            return View(myTime);
        }
    }
}