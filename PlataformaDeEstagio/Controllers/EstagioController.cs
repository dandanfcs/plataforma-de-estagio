using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaDeEstagio.Controllers
{
    public class EstagioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
