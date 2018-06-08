using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CrudAspNetMvcRelacionamento1N.Models
{
    public class LojaContext: DbContext
    {
        public LojaContext(): base("Loja")
        {
           
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Consultor> Consultores { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
    }
}