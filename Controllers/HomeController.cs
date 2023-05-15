using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04_PaquetesTuristicos_TorreWalsh.Models;

namespace TP04_PaquetesTuristicos_TorreWalsh.Controllers;

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
    public IActionResult GuardarPaquete(string Destino, string Hotel, string Aereo, string Excursion){
        if(Destino!=""&&Hotel!=""&&Aereo!=""&&Excursion!=""){
            Paquete nuevo = new Paquete(Hotel,Aereo,Excursion);
            ORTWorld.IngresarPaquete(Destino,nuevo);
            ViewBag.Paquetes=ORTWorld.Paquetes;
            return View("Index");
        }
        else{
            ViewBag.ComentarioError="Lo ingresado no es válido. Por favor ingrese opciones del menú";
            return View("SelectPaquete");
        }
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