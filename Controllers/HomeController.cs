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
        cargarListas();
        return View();
    }
    void cargarListas(){
        ViewBag.Destinos=ORTWorld.ListaDestinos;
        ViewBag.Hoteles=ORTWorld.ListaHoteles;
        ViewBag.Aerolineas=ORTWorld.ListaAereos;
        ViewBag.Excursiones=ORTWorld.ListaExcursiones;
    }
    void mensajeError(){
        ViewBag.ComentarioError="Lo ingresado no es válido. Por favor ingrese opciones del menú";
    }
    void cargarORTWPaq(){
        ViewBag.Paquetes=ORTWorld.Paquetes;
    }
    public IActionResult GuardarPaquete(int Destino, string Hotel, string Aereo, string Excursion){
        if(Destino!=0&&Hotel!=""&&Aereo!=""&&Excursion!=""){
            Paquete nuevo = new Paquete(Hotel,Aereo,Excursion);
            ORTWorld.IngresarPaquete(ORTWorld.ListaDestinos[Destino-1],nuevo);
            cargarORTWPaq();
            return View("Index");
        }
        else{
            mensajeError();
            cargarListas();
            return View("SelectPaquete");
        }
    }
    public IActionResult BorrarPaquete(string Destino){
        ORTWorld.BorrarPaquete(Destino);
        cargarORTWPaq();
        return View("Index");
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