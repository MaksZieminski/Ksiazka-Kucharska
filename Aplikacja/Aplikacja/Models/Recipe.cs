using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplikacja.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishedDate { get; set; }
        public int UserLogin { get; set; }
        public double Score { get; set; }
    }
}