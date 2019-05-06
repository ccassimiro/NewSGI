using SGI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.Infra.Data.Context
{
    public class SGIContext : DbContext
    {
        public SGIContext()
            : base("SGI")
        {

        }
        
        //Criação das tabelas.

        public DbSet<Pessoa> Pessoas { get; set; }

    }
}
