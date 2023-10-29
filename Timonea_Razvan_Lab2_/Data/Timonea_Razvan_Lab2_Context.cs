using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Timonea_Razvan_Lab2_.Models;

namespace Timonea_Razvan_Lab2_.Data
{
    public class Timonea_Razvan_Lab2_Context : DbContext
    {
        public Timonea_Razvan_Lab2_Context (DbContextOptions<Timonea_Razvan_Lab2_Context> options)
            : base(options)
        {
        }

        public DbSet<Timonea_Razvan_Lab2_.Models.Book> Book { get; set; } = default!;

        public DbSet<Timonea_Razvan_Lab2_.Models.Publisher>? Publisher { get; set; }
    }
}
