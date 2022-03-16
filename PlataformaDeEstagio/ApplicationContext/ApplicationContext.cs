using Microsoft.EntityFrameworkCore;
using PlataformaDeEstagio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaDeEstagio.Application_Context
{
    public class ApplicationContext :DbContext
    {
        //Registra no banco de dados as entidades da aplicação
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Empresas>().HasKey(e => e.Id);

        }
    }
}
