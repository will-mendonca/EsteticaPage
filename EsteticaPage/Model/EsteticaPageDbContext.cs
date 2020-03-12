using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsteticaPage.Model
{
    public class EsteticaPageDbContext : DbContext
    {
        public DbSet<Procedimento> Procedimentos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<ItemServico> ItemServicos { get; set; }

        public EsteticaPageDbContext(DbContextOptions<EsteticaPageDbContext> options) :base(options) { }

        
    }
}
