using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Wompus_Website.Models
{
    public class News
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime PublishTime { get; set; }
        public string Description { get; set; }
    }

    public class NewsDBContext : DbContext
    {
        public DbSet<News> Updates { get; set; }
    }
}
