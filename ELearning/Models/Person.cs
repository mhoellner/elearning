﻿using System.Web;

namespace ELearning.Models
{
    public class Person : Item
    {
        public string ProfilePic { get; set; }
        public HtmlString ProfileDescription { get; set; }
    }
}