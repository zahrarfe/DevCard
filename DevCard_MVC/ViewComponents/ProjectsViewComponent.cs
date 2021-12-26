using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(1,"اسنپ فود" , "ارسال سریع و فوری غذا از هر کجای دنیا " , "snap" , "project-1.jpg"),
                new Project(2,"اسنپ" , "ارسال سریع و فوری تاکسی از هر کجای دنیا " , "snap" , "project-2.jpg"),
                new Project(3,"لرنایت" , "یادگیری فوری زبان انگلیسی در منزل با کم ترین قیمت و بهترین کیفیت زیر نظر بهترین و حرفه ای ترین تیم آموزشی  و مشاوره رایگان " , "learnit" , "project-3.jpg"),
                new Project(4,"تهران گردی" , "بشین تو خونت و ببین امروز کجا بری بهتره؟ " , "gardesh" , "project-4.jpg"),

                // بدون کانستراکتور
                //new Project
                //{
                //    Id = 1,
                //    Name = "Project Heading",
                //    Description =
                //        "Project intro lorem ipsum dolor sit amet, consectetuer adipiscing elit. Cum sociis natoque penatibus et magnis dis parturient montes.",
                //    Client = "Client: Google",
                //    Img = "project-1.jpg"
                //},
                //new Project
                //{
                //    Id = 2,
                //    Name = "Project Heading",
                //    Description =
                //        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. ",
                //    Client = "Client: Dropbox",
                //    Img = "project-2.jpg"
                //},
                //new Project
                //{
                //    Id = 3,
                //    Name = "Project Heading",
                //    Description =
                //        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.  ",
                //    Client = "Client: Google",
                //    Img = "project-3.jpg"
                //},
                //new Project
                //{
                //    Id = 4,
                //    Name = "Project Heading",
                //    Description =
                //        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. ",
                //    Client = "Client: Uber",
                //    Img = "project-4.jpg"
                //}
            };

            return View("_Projects", projects);
        }
    }
}