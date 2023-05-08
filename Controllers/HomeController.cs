using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04-PaquetesTuristicos_TorreWalsh.Models;

namespace TP04-PaquetesTuristicos_TorreWalsh.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Paquetes=ORTWorld.Paquetes;
        return View();
    }
    public IActionResult SelectPaquete(){
        ViewBag.Destinos=ORTWorld.ListaDestinos;
        ViewBag.Hoteles=ORTWorld.ListaHoteles;
        ViewBag.Aerolineas=ORTWorld.ListaAereos;
        ViewBag.Excursiones=ORTWorld.ListaExcursiones;
        return View();
    }
    public IActionResult GuardarPaquete(int Destino, int Hotel, int Aereo, int Excursion){
        
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
