using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCdemo.Models
{
    public class MovieDB
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Director { get; set; }

        public DateTime Date { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<MovieDB> Movies { get; set; }
    }
}