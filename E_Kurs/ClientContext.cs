using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Kurs
{
    public class ClientContext : DbContext
    {
        public ClientContext() : base("DbConnectionString") { }

        public DbSet<DefaultClient> Clients { get; set; }
        public DbSet<BuyedByModels> BuyedModels { get; set; }
    }
}
