using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImobWeb.Models;

namespace ImobWeb.Controllers
{
    public class EstadosController : Controller
    {
        public IActionResult Index()
        {
            List<Estado> lista = new List<Estado>();
            lista.Add(new Estado { Id = 1, Nome = "Minas Gerais", Uf = "MG" });
            lista.Add(new Estado { Id = 2, Nome = "São Paulo", Uf = "SP" });

            return View(lista);
        }
    }
}
