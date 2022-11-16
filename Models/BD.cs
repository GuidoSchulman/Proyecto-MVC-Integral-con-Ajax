namespace TP8.Models;
using System;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

public class BD 
{
    private static List<Recetas> _ListadoRecetas = new List<Recetas>();
    private static List<Ingredientes> _ListadoIngredientes = new List<Ingredientes>();
    private static string _connectionString = 
       @"Server=127.0.0.1; Database=Recetados;Trusted_Connection=True;";


    public static void  GuardarRecetas(Recetas Valor)
    {
        
        string sql = "INSERT INTO RecetasCreadas (Nombre, Ingredientes,  FechaCreacion, Likes, Imagen, NombreCreador) VALUES (@pNombre, @pIngredientes,  @pFechaCreacion, @pLikes, @pImagen, @pNombreCreador )";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, new {  pNombre = Valor.Nombre,  pIngredientes = Valor.Ingredientes, pFechaCreacion = Valor.FechaCreacion, pLikes=Valor.Likes, pImagen=Valor.Imagen, pNombreCreador=Valor.NombreCreador});
        } 
        
    }
    public static void  GuardarIngrediente(Ingredientes Valor)
    {
        
        string sql = "INSERT INTO Ingredientes ( Nombre, CantNecesaria,  Calorias,  Imagen) VALUES (@pNombre, @pCantNecesaria,  @pCalorias, @pImagen)";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, new {  pNombre = Valor.Nombre,  pCantNecesaria = Valor.CantNecesaria, pCalorias = Valor.Calorias,  pImagen=Valor.Imagen});
        } 
        
    }

    public static void  GuardarIngredientesXRecetasCreadas(IngredientesXRecetasCreadas Valor)
    {
        
        string sql = "INSERT INTO IngredientesXRecetasCreadas ( ID_Ingredientes, ID_Recetas) VALUES (@pID_Ingredientes, @pID_Recetas)";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, new {pID_Ingredientes=Valor.ID_Ingredientes,pID_Recetas=Valor.ID_Recetas });
        } 
        
    }

    public static int EliminarReceta(int ID)
    {
        
        string sql = "DELETE FROM RecetasCreadas WHERE ID = @pID";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            return db.Execute(sql, new { pID = ID });
        }
    }
    
    public static Ingredientes VerDetalleIngredientes(int ID)
    {
        Ingredientes MiIngrediente;
       using (SqlConnection db = new SqlConnection(_connectionString))
       {
        string sql = "SELECT * FROM Ingredientes WHERE ID=@pID ";
        MiIngrediente=  db.QueryFirstOrDefault<Ingredientes>(sql,new {pID=ID});
       
       }
        return MiIngrediente;
    }
    public static List<Recetas> ListarRecetas()
    {
      
        using (SqlConnection db = new SqlConnection(_connectionString))
                {
                    string sql = "SELECT * FROM RecetasCreadas";
                    _ListadoRecetas =db.Query<Recetas>(sql).ToList();
                
                }
                return _ListadoRecetas;
    }
     public static List<Ingredientes> ListarIngredientes()
    {
      
        using (SqlConnection db = new SqlConnection(_connectionString))
                {
                    string sql = "SELECT * FROM Ingredientes";
                    _ListadoIngredientes =db.Query<Ingredientes>(sql).ToList();
                
                }
                return _ListadoIngredientes;
    }

    
   
}