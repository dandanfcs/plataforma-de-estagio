using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using PlataformaDeEstagio.Application_Context;
using System.Threading.Tasks;
using PlataformaDeEstagio.Models;

namespace PlataformaDeEstagio.Repository
{
    public class BaseRepository<T> where T : BaseModel
    {
        protected readonly ApplicationContext context;
        protected readonly DbSet<T> dbSet;

        public BaseRepository(ApplicationContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }
    }
}