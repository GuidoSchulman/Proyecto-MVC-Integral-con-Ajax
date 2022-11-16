using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace TP8.Models;

public class IngredientesXRecetasCreadas
{
    private int _ID_Ingredintes;
    private int _ID_Recetas;

     

    public IngredientesXRecetasCreadas(int ID_Ingredintes, int ID_Recetas)
    {
        _ID_Ingredintes = ID_Ingredintes;
        _ID_Recetas=ID_Recetas;
       
    }

    public IngredientesXRecetasCreadas()
    {
        _ID_Ingredintes=0;
        _ID_Recetas = 0;
    }
      

     public int ID_Ingredintes
    {
        get
        {
            return _ID_Ingredintes;
        }
        set{
            _ID_Ingredintes = value;
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