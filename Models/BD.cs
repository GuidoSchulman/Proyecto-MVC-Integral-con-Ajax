namespace TP8.Models;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

public class BD 
{
    private static List<Recetas> _ListadoRecetas = new List<Recetas>();
    private static string _connectionString = 
        @"Server=A-PHZ2-AMI-003;DataBase=Qatar2022;Trusted_Connection=True";

    public static void  GuardarRecetas(Recetas Valor)
    {
        
        string sql = "INSERT INTO Recetas (Nombre, Ingredientes,  FechaCreacion, Likes, Imagen, NombreCreador, IdIngredientes) VALUES (@pNombre, @pIngredientes,  @pFechaCreacion, @pLikes, @pImagen, @pNombreCreador, @pIdIngredientes)";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, new {  pNombre = Valor.Nombre,  pIngredientes = Valor.Ingredientes, pFechaCreacion = Valor.FechaCreacion, pLikes=Valor.Likes, pImagen=Valor.Imagen, pNombreCreador=Valor.NombreCreador, pIdIngredietes});
        } 
        
    }

    public static int EliminarReceta(int Id)
    {
        
        string sql = "DELETE FROM Recetas WHERE ID = @pID";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            return db.Execute(sql, new { pID = ID });
        }
    }
    
    public static Recetas VerDetalleEquipo(int ID)
    {
        Recetas MiReceta;
       using (SqlConnection db = new SqlConnection(_connectionString))
       {
        string sql = "SELECT * FROM Recetas WHERE ID=@pID ";
        MiReceta=  db.QueryFirstOrDefault<Recetas>(sql,new {pID=ID});
       
       }
        return MiReceta;
    }
    public static List<Recetas> ListarRecetas()
    {
       using (SqlConnection db = new SqlConnection(_connectionString))
       {
       
        string sql = "SELECT * FROM Recetas";
        return db.Query<Equipo>(sql).ToList();
       
       }
    }
   
}