using System;
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
        public IActionResult Contact(Contact form)
        {
            if (ModelState.IsValid == false)
            {
                ViewBag.error= "اطلاعات وارد شده صحیح نیست لطفا دوباره تلاش کنید";
                return View(form);

            }

           ViewBag.success = "فرم شما با موفقیت ارسال شد";
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}