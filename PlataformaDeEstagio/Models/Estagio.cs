using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaDeEstagio.Models
{
    public class Estagio : BaseModel
    {
        public Empresas Empresa { get; set; }
        public bool Remoto { get; set; }
        public int CargaHoraria { get; set; }
        public string DescricaoDaVaga { get; set; }
        public bool Remunerado { get; set; }
        public string Bolsa { get; set; }

    }
}
