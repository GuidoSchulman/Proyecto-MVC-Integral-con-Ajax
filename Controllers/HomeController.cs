using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Proyecto_MVC_Integral_con_Ajax.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using TP8.Models;

namespace Proyecto_MVC_Integral_con_Ajax.Controllers;

public class HomeController : Controller
{
    private IWebHostEnvironment Environment;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
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

    public IActionResult Mostrar(int val){
        ViewBag.Pantalla=val;
        return View("Mostrar", new {val=val});
    }

     public IActionResult VerDetalleIngredientes(int ID)
    {
          ViewBag.VerDetalleIngredientes = BD.VerDetalleIngredientes(ID);
      
        return View("VerDetalleIngredientes");
//detalle de ingredientes card boton
    }

// los ID se llaman igual y en un momento hablo de ingredientes y en otro de recetas
    public IActionResult AgregarReceta(int ID)
    {
        ViewBag.ID = ID;

        return View("AgregarReceta");
    }

//agregar receta en la view mostrar

public IActionResult EliminarReceta(int ID)
    {
       BD.EliminarReceta(ID);
       return RedirectToAction("Mostrar", new {ID=ID});
    }
public IActionResult MostrarRecetas()
{
    ViewBag.Receta=BD.ListarRecetas();
    return View("MostrarRecetasUsuarios");

}

// elininar receta en el menu recetas

     //form
    [HttpPost]
    public IActionResult GuardarReceta(string Nombre, string Ingredientes,  DateTime FechaCreacion, int Likes, IFormFile Imagen, string NombreCreador, int IdIngredientes)
     {
        if(Imagen.Length>0)
        { 
            string wwwRootLocal= this.Environment.ContentRootPath + @"\wwwroot\" + Imagen.FileName;
            using(var stream=System.IO.File.Create(wwwRootLocal))
            {
                Imagen.CopyToAsync(stream);
            }
        }

       //form agregar receta

        //crea un nuevo jugador con los datos pasados por parametros EN JUG
        Recetas Valor= new Recetas(Nombre,  Ingredientes,   FechaCreacion, Likes ,(""+ Imagen.FileName),  NombreCreador,  IdIngredientes);
        //manda al jugador Jug a la base de datos
        BD.GuardarRecetas(Valor);
         //Redirecciona a VerDetalleEquipo para ver al jugador en la tabla y pasa el IdEquipo
        return RedirectToAction("Mostrar", "Home", new {ID = Valor.ID});

       
     }

}
