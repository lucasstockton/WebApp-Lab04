using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab4.Models;

namespace Lab4.Controllers
{
    public class Lab4Controller : Controller
    {
        public IActionResult Index()
        {
            // Creating a DatTime to pass to view
            var myTime = DateTime.Now;

            /*
             * 
             * DateTime(Int32, Int32, Int32, Int32, Int32, Int32) 
             * Initializes a new instance of the DateTime structure 
             * to the specified year, month, day, hour, minute, and second.
*/
       //     myTime = new DateTime(2018, 3, 31, 16, 0, 0); // Testing

            return View(myTime);
        }



        public IActionResult Page2(int id)
        {

            // Profile
            
            List<Profile> Profiles = new List<Profile>();

            for (int a = 1; a <= id; a++) // in new int[] { 1,2,3,4,5})
            {

                Profiles.Add(new Profile(a));


            }



   

            return View(Profiles);
        }


        public IActionResult Page3()
        {

            ViewData["Heading"] = "Beverages.";


            List<String> myList = new List<String>();

            myList.Add("Coffee");
            myList.Add("Tea");
            myList.Add("Coke");
            myList.Add("Beer");
            myList.Add("Wine");

            return View(myList);
        }

    }
}
 