﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Http;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact();

            return View(model);
        }

        [HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{

        //    return Json(Ok());
        //}

        //public JsonResult Contact(IFormCollection form)
        //{
        //    var Name = form["Name"];
        //    return Json(Ok());
        //}
        public JsonResult Contact(Contact form)
        {
            Console.WriteLine((form.ToString()));
            return Json(Ok());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}