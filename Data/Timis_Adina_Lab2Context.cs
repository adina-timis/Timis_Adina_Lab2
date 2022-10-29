using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Timis_Adina_Lab2.Models;

namespace Timis_Adina_Lab2.Data
{
    public class Timis_Adina_Lab2Context : DbContext
    {
        public Timis_Adina_Lab2Context (DbContextOptions<Timis_Adina_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Timis_Adina_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Timis_Adina_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Timis_Adina_Lab2.Models.Author> Author { get; set; }
    }
}
