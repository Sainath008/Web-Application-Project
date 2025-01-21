using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace TicketManagement
{
    public class Context:DbContext
    {
        public DbSet<TickDetails>TicketDB1 { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB; Database=TicketDB1; Trusted_Connection=True; TrustServerCertificate=True");
        }

    }
}
