using EnterpriseSystemsDevelopment_EPortfolio.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnterpriseSystemsDevelopment_EPortfolio.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //Linking Template model class to database
        public DbSet<Template> Template { get; set; }

        //Linking KSB model class to database
        public DbSet<Evidence> Evidence { get; set; }

        //Linking Apprentice model class to database
        public DbSet<Apprentice> Apprentices { get; set; }



    }
}
