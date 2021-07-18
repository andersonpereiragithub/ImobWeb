using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ImobWeb.Models
{
    public class ImobWebContext : DbContext
    {
        public ImobWebContext (DbContextOptions<ImobWebContext> options)
            : base(options)
        {
        }

        public DbSet<ImobWeb.Models.Estado> Estado { get; set; }
    }
}
