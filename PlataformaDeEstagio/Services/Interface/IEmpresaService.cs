using PlataformaDeEstagio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaDeEstagio.Services.Interface
{
   public interface IEmpresaService
    {
        public void AdicionarEmpresa(Empresas empresa);

        public Empresas ObterEmpresa(int id);
        void DeletarEmpresa(int id);
        void AtualizarEmpresa();
        List<Empresas> ListarEmpresas();
    }
}
