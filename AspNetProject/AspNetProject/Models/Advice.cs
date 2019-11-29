﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetProject.Models
{
    public class Advice
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Photo { get; set; }
        public string Date { get; set; }

    }
}