using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class Article
    {
        public int Id { get; set; }

        public  string Title { get; set; }
        public  string Description { get; set; }
        public  string Img { get; set; }

        public Article(int id, string title, string description, string img)
        {
            Id = id;
            Title = title;
            Description = description;
            Img = img;
        }
    }
}
