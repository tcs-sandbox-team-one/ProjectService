﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectService.Database.Entities;


namespace ProjectService.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<project> Projects { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"server=ts-management-db; port=3306; database=projectdb; user=user; password=password");
        }
    }
}
