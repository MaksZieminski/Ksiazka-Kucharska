﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplikacja.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string UserId { get; set; }
        public string Text { get; set; }
        public DateTime PublishDate { get; set; }
    }
}