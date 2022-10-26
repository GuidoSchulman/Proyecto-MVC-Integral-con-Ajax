namespace TP8.Models;

public class Vinos
{
    private int _id;
    private string _nombre;
    private int _porcentajedealcohol;
    private string _paisDeCreacion;
    private DateTime _fechaCreacion;
     

    public Vinos(string nombre, string porcentajedealcohol, string paisDeCreacion, DateTime fechaCreacion)
    {
        _nombre = nombre;
        _porcentajedealcohol=porcentajedealcohol;
        _paisDeCreacion=paisDeCreacion;
        _fechaCreacion = fechaCreacion;
       
    }

    public Recetas()
    {
        _id=0;
        _nombre = "";
       _porcentajedealcohol=0;
        _paisDeCreacion="";

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
    public string Porcentajedealcohol
    {
        get
        {
            return _porcentajedealcohol;
        }
        set{
            _porcentajedealcohol = value;
        }
    }
    public string PaisDeCreacion{
        get{
            return _paisDeCreacion;
        }
        set{
            _paisDeCreacion=value;
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
    
    
}