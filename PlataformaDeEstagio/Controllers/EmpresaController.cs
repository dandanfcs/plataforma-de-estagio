using Microsoft.AspNetCore.Mvc;
using PlataformaDeEstagio.Models;
using PlataformaDeEstagio.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaDeEstagio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpresaController : Controller
    {
        IEmpresaService empresaService;
        public EmpresaController(IEmpresaService _empresaService)
        {
            this.empresaService = _empresaService;
        }

        [HttpPost("add/Empresa")]
        public void AdcionarEmpresa(Empresas empresa)
        {
            empresaService.AdicionarEmpresa(empresa);
        }

        [HttpGet("get/{id}")]
        public Empresas ObterEmpresa(int id)
        {
            var empresa = empresaService.ObterEmpresa(id);
            return empresa;
        }

        [HttpGet("getAll")]
        public List<Empresas> ListarEmpresas(int id)
        {
            var empresa = empresaService.ListarEmpresas();
            return empresa;
        }

        [HttpDelete("delete/{id}")]
        public void DeletarEmpresa(int id)
        {
            empresaService.DeletarEmpresa(id);
        }
    }
}
