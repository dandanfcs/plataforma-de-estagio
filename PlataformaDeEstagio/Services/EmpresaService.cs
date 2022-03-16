using PlataformaDeEstagio.Models;
using PlataformaDeEstagio.Repository.Interface;
using PlataformaDeEstagio.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaDeEstagio.Services
{
    public class EmpresaService : IEmpresaService
    {
        IEmpresaRepository empresaRepository;

        public EmpresaService(IEmpresaRepository empresaRepository)
        {
            this.empresaRepository = empresaRepository;
        }

        public void AdicionarEmpresa(Empresas empresa)
        {
            empresaRepository.AdicionarEmpresa(empresa);
        }

        public void AtualizarEmpresa()
        {
            throw new NotImplementedException();
        }

        public void DeletarEmpresa(int id)
        {
            empresaRepository.DeletarEmpresa(id);
        }

        public List<Empresas> ListarEmpresas()
        {
            var listaDeEmpresas = empresaRepository.ListarEmpresas();
            return listaDeEmpresas;
        }

        public Empresas ObterEmpresa(int id)
        {
            var empresa = empresaRepository.ObterEmpresa(id);
            return empresa;
        }
    }
}
