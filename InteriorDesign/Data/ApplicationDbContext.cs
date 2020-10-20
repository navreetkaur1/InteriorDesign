using System;
using System.Collections.Generic;
using System.Text;
using InteriorDesign.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InteriorDesign.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
