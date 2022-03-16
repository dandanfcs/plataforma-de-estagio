using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaDeEstagio.Models
{
    public class Empresas : BaseModel
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Site { get; set; }
        public string Email { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }

        List<Estagio> Estagios { get; set; }
    }
}
