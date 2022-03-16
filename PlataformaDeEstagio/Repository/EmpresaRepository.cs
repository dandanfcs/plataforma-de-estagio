using PlataformaDeEstagio.Application_Context;
using PlataformaDeEstagio.Models;
using PlataformaDeEstagio.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaDeEstagio.Repository
{
    public class EmpresaRepository : BaseRepository<Empresas>, IEmpresaRepository
    {
        public EmpresaRepository(ApplicationContext context) : base(context)
        {
        }
        public void AdicionarEmpresa(Empresas empresa)
        {
            context.Add(empresa);
            context.SaveChanges();
        }

        public void AtualizarEmpresa()
        {
            throw new NotImplementedException();
        }

        public void DeletarEmpresa(int id)
        {
            var obj = dbSet.Find(id);
            dbSet.Remove(obj);
            context.SaveChanges();
        }

        public List<Empresas> ListarEmpresas()
        {
            return dbSet.ToList();
        }

        public Empresas ObterEmpresa(int id)
        {
            var empresa = dbSet.Find(id);
            return empresa;
        }


    }
}
