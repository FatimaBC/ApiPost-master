using ApiPost.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPost.Data
{
    public class Covid19Context : DbContext
    {
        public Covid19Context(DbContextOptions<Covid19Context> options) : base(options)
        {

        }

        public DbSet<Covid19> covid19 { get; set; }
        public DbSet<Trials> trials { get; set; }

    }
}
