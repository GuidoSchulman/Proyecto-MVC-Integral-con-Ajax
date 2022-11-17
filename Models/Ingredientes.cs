using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace TP8.Models;

public class Ingredientes
{
    private int _ID_Ingredientes;
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
        _ID_Ingredientes=0;
        _nombre = "";
        _cantNecesaria=0;
        _calorias=0;
        _imagen="";

    }

     public int ID_Ingredientes
    {
        get
        {
            return _ID_Ingredientes;
        }
        set{
            _ID_Ingredientes = value;
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
    public int CantNecesaria
    {
        get
        {
            return _cantNecesaria;
        }
        set{
            _cantNecesaria = value;
        }
    }
    public int Calorias{
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