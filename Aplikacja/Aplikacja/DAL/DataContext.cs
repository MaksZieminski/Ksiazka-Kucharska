using Aplikacja.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Aplikacja.DataAcces
{
    public class DataConext : DbContext
    {
        private readonly string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\max\\Documents\\Ksiazka-Kucharska\\Aplikacja\\Aplikacja\\App_Data\\DB.mdf;Integrated Security=True;Connect Timeout=30";

        public DataConext() : base("DataContext")
        { }
        public DbSet<Recipe> recipes { get; set; }
        //public DbSet<User> users { get; set; }
        public DbSet<User1> users1 { get; set; }
    }
}