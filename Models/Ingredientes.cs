namespace TP8.Models;

public class Ingredientes
{
    private int _id;
    private string _nombre;
    private int _cantNecesaria;
    private int _calorias;
    private string _imagen;
     

    public Ingredientes(string nombre, int cantNecesaria, int calorias, string imagen)
    {
        _nombre = nombre;
        _cantNecesaria=cantNecesaria;
        _calorias=calorias;
        _imagen = imagen;
       
    }

    public Ingredientes()
    {
        _id=0;
        _nombre = "";
        _cantNecesaria=0;
        _calorias=0;
        _imagen="";

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
    public string CantNecesaria
    {
        get
        {
            return _cantNecesaria;
        }
        set{
            _cantNecesaria = value;
        }
    }
    public string Calorias{
        get{
            return _calorias;
        }
        set{
            _calorias=value;
        }
    }
    public string Imagen
    {
        get
        {
            return _imagen;
        }
        set{
            _imagen= value;
        }
    }
    
    
}