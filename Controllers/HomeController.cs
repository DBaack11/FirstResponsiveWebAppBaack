/***************************************************************
* Name        : UserAge
* Author      : Devin Baack
* Created     : 5/31/2021
* Course      : CIS 174 - Advanced C#
* Version     : 1.0
* OS          : Windows 10, Visual Studio
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program creates a web page displaying information about the user.
*               Input:  None
*               Output: Formatted web page with all created model attributes
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.
***************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserAge.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Index(StudentWorker.Model.UserAgeModel model)
        {
            
                ViewBag.Age = model.AgeThisYear();
            
            
            
            return View(model);
        }
    }
}
