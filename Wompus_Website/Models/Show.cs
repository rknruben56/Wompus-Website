using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Wompus_Website.Models
{
    public class Show
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime ShowDate { get; set; }
        public string Description { get; set; }
    }

    public class ShowDBContext : DbContext
    {
        public DbSet<Show> Shows { get; set; }
    }
}