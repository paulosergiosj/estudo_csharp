﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AspNetMVC.Models
{
    public class AspNetMVCContext : DbContext
    {
        public AspNetMVCContext (DbContextOptions<AspNetMVCContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetMVC.Models.Department> Department { get; set; }
    }
}
