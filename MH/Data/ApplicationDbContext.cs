using System;
using System.Collections.Generic;
using System.Text;
using MH.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MH.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Meal> Meals { get; set; }
       

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
