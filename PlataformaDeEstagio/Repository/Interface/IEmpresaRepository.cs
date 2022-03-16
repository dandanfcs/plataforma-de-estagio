using PlataformaDeEstagio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaDeEstagio.Repository.Interface
{
    public interface IEmpresaRepository
    {
        void AdicionarEmpresa(Empresas empresa);

        Empresas ObterEmpresa(int id);
        void DeletarEmpresa(int id);
        void AtualizarEmpresa();
        List<Empresas> ListarEmpresas();
    }
}
