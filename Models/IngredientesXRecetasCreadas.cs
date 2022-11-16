using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace TP8.Models;

public class IngredientesXRecetasCreadas
{
    private int _ID_Ingredientes;
    private int _ID_Recetas;

     

    public IngredientesXRecetasCreadas(int ID_Ingredientes, int ID_Recetas)
    {
        _ID_Ingredientes = ID_Ingredientes;
        _ID_Recetas=ID_Recetas;
       
    }

    public IngredientesXRecetasCreadas()
    {
        _ID_Ingredientes=0;
        _ID_Recetas = 0;
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
   
}