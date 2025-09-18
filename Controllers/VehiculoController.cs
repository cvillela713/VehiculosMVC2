using Microsoft.AspNetCore.Mvc;
using VehiculosMVC2.Models;

namespace VehiculosMVC2.Controllers
{
    public class VehiculoController : Controller
    {
        public IActionResult Index()
        {
            var auto = new Auto
            {
                Id = 1,
                Marca = "Toyota",
                Modelo = "Corolla",
                Anio = 2022,
                NumeroPuertas = 4
            };

            var moto = new Moto
            {
                Id = 1,
                Marca = "Yamaha",
                Modelo = "XTZ",
                Anio = 2021,
                CilindrajeCC = 250,
                TieneParrilla = true
            };

            ViewBag.Auto = auto;
            ViewBag.Moto = moto;

            return View();
        }
    }
}
