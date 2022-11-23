using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace TP8.Models;

public class Todo
{
    private int _ID_Ingredientes;
    private int _ID_Recetas;
    private string _nombreIngrediente;
    private string _nombreReceta;
     

    public Todo()
    {
        _ID_Ingredientes = 0;
        _ID_Recetas=0;
       _nombreIngrediente="";
       _nombreReceta="";
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

     public int ID_Recetas
    {
        get
        {
            return _ID_Recetas;
        }
        set{
            _ID_Recetas = value;
        }
    }
    public string NombreIngrediente
    {
        get
        {
            return _nombreIngrediente;
        }
        set{
            _nombreIngrediente = value;
        }
    }
    public string NombreReceta
    {
        get
        {
            return _nombreReceta;
        }
        set{
            _nombreReceta = value;
        }
    }
   
}