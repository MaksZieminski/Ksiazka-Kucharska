using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplikacja.Models
{
    public class User
    {
        public string login { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string RegisterDate { get; set; }
    }
}