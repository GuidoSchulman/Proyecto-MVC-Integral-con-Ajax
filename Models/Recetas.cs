using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace TP8.Models;

public class Recetas
{
    private int _ID_Recetas;
    private string _nombre;
    private string _ingredientes;
    private DateTime _fechaCreacion;
     private int _likes;
     private string _imagen;
     private string _nombreCreador;

    public Recetas(string nombre, string ingredientes,  DateTime fechaCreacion, int likes, string imagen, string nombreCreador)
    {
        _nombre = nombre;
        _ingredientes=ingredientes;
        _fechaCreacion = fechaCreacion;
        _likes=likes;
        _imagen = imagen;
        _nombreCreador = nombreCreador;
       
        
    }

    public Recetas()
    {
        _ID_Recetas=0;
        _nombre = "";
        _ingredientes="";
        _likes=0;
        _imagen = "";
        _nombreCreador = "";


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

    
}