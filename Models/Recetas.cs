namespace TP8.Models;

public class Recetas
{
    private int _id;
    private string _nombre;
    private string _ingredientes;
    private DateTime _fechaCreacion;
     private int _likes;
     private string _imagen;
     private string _nombreCreador;
    private int _idIngredientes;

    public Recetas(string nombre, string ingredientes,  DateTime fechaCreacion, int likes, string imagen, string nombreCreador, int idIngredientes)
    {
        _nombre = nombre;
        _ingredientes=ingredientes;
        _fechaCreacion = fechaCreacion;
        _likes=likes;
        _imagen = imagen;
        _nombreCreador = nombreCreador;
        _idIngredientes=idIngredientes;
        
    }

    public Recetas()
    {
        _id=0;
        _nombre = "";
        _ingredientes="";
        _likes=0;
        _imagen = "";
        _nombreCreador = "";
        _idIngredientes=0;

    }

     public int ID
    {
        get
        {
            return _id;
        }
        set{
            _id = value;
        }
    }

     public string Nombre
    {
        get
        {
            return _nombre;
        }
        set{
            _nombre = value;
        }
    }
    public string Ingredientes
    {
        get
        {
            return _ingredientes;
        }
        set{
            _ingredientes = value;
        }
    }
    public DateTime FechaCreacion
    {
        get
        {
            return _fechaCreacion;
        }
        set{
            _fechaCreacion = value;
        }
    }
     public int Likes
    {
        get
        {
            return _likes;
        }
        set{
            _likes = value;
        }
    }
    public string Imagen
    {
        get
        {
            return _imagen;
        }
        set{
            _imagen = value;
        }
    }
    public string NombreCreador
    {
        get
        {
            return _nombreCreador;
        }
        set{
            _nombreCreador = value;
        }
    }

    public int idIngredientes
    {
        get
        {
            return _idIngredientes;
        }
        set{
            _idIngredientes = value;
        }
    }
    
}