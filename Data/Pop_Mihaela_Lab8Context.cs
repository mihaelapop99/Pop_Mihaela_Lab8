using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pop_Mihaela_Lab8.Models;

namespace Pop_Mihaela_Lab8.Data
{
    public class Pop_Mihaela_Lab8Context : DbContext
    {
        public Pop_Mihaela_Lab8Context (DbContextOptions<Pop_Mihaela_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Pop_Mihaela_Lab8.Models.Book> Book { get; set; }

        public DbSet<Pop_Mihaela_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Pop_Mihaela_Lab8.Models.Category> Category { get; set; }
    }
}
