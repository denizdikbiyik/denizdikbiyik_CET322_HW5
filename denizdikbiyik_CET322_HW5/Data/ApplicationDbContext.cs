using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace denizdikbiyik_CET322_HW5.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<denizdikbiyik_CET322_HW5.Models.Student> Student { get; set; }

        public DbSet<denizdikbiyik_CET322_HW5.Models.Department> Department { get; set; }
    }
}
