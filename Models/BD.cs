namespace TP8.Models;
using System;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

public class BD 
{
    private static List<Recetas> _ListadoRecetas = new List<Recetas>();
    private static string _connectionString = 
       @"Server=127.0.0.1; Database=Recetados;Trusted_Connection=True;";

    public static void  GuardarRecetas(Recetas Valor)
    {
        
        string sql = "INSERT INTO Recetas (Nombre, Ingredientes,  FechaCreacion, Likes, Imagen, NombreCreador, IdIngredientes) VALUES (@pNombre, @pIngredientes,  @pFechaCreacion, @pLikes, @pImagen, @pNombreCreador, @pIdIngredientes)";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, new {  pNombre = Valor.Nombre,  pIngredientes = Valor.Ingredientes, pFechaCreacion = Valor.FechaCreacion, pLikes=Valor.Likes, pImagen=Valor.Imagen, pNombreCreador=Valor.NombreCreador, pIdIngredientes=Valor.Ingredientes});
        } 
        
    }

    public static int EliminarReceta(int ID)
    {
        
        string sql = "DELETE FROM Recetas WHERE ID = @pID";
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
    
   
}