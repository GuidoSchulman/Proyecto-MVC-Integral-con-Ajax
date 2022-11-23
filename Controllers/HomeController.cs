using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Proyecto_MVC_Integral_con_Ajax.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using TP8.Models;

namespace Proyecto_MVC_Integral_con_Ajax.Controllers;

public class HomeController : Controller
{

    private readonly ILogger<HomeController> _logger;
    private IWebHostEnvironment Environment;

    public HomeController(ILogger<HomeController> logger, IWebHostEnvironment environment)
    {
        Environment=environment;
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
        return View("Mostrar");
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
        ViewBag.Ingredientes= BD.ListarIngredientes();
        return View("AgregarReceta");
    }
    public IActionResult AgregarIngrediente(int ID)
    {
        ViewBag.ID = ID;

        return View("AgregarIngrediente");
    }
//agregar receta en la view mostrar

public IActionResult EliminarReceta(int ID)
    {
       BD.EliminarReceta(ID);
       return RedirectToAction("MostrarRecetas");
    }
public IActionResult MostrarRecetas()
{
    ViewBag.Ingredientes=BD.ListarIngredientes();
    ViewBag.Receta=BD.ListarRecetas();
    ViewBag.Conjunto=BD.ListarEInnerJoin();
    return View("MostrarRecetasUsuarios");

}

// elininar receta en el menu recetas

     //form
    [HttpPost]
    public IActionResult GuardarReceta(string Nombre,  DateTime FechaCreacion, int Likes, IFormFile Imagen, string NombreCreador)
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

        
        Recetas Valor= new Recetas(Nombre,   FechaCreacion, Likes ,("/"+ Imagen.FileName),  NombreCreador);
       int rec=BD.GuardarRecetas(Valor);
        
        return RedirectToAction("SeleccionarIngredientes", "Home", new {ID_Recetas = rec});

        
     }

     [HttpPost]
    public IActionResult GuardarIngrediente(string Nombre, int CantNecesaria, int Calorias, IFormFile Imagen)
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

       
        Ingredientes Valor= new Ingredientes( Nombre,  CantNecesaria,  Calorias,("/" + Imagen.FileName));
       
        BD.GuardarIngrediente(Valor);
        
        return RedirectToAction("Index", "Home", new {ID_Ingredientes = Valor.ID_Ingredientes});

       
     }
     public IActionResult SeleccionarIngredientes(int ID_Recetas)
     {
        ViewBag.Ingredientes=BD.ListarIngredientes();
        ViewBag.ID_Recetas=ID_Recetas;
        return View("SeleccionarIngredientes");
       

       
     }
     //recibe un array de int (ingredientes)
     public IActionResult GuardarSelecIngredientes(int[] ingredientes,int ID_Recetas)
     {
        //recorrer ingredientes e insertar de a 1 ingrediente
        for (int i = 0; i < ingredientes.Length; i++)
        {
            IngredientesXRecetasCreadas Valor= new IngredientesXRecetasCreadas(ingredientes[i],ID_Recetas);
            BD.GuardarIngredientesXRecetasCreadas(Valor);
        }
        return RedirectToAction("Index", "Home");
     }

}
