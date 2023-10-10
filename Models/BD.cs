using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

public static class BD
{
    private static string _connectionString = @"Server=localHost;DataBase=TP9;Trusted_Connection=True;";

    public static void agregarUsuario(Usuario usuarioP)
    {
        string SQL = "INSERT INTO Usuario (UserName,Contraseña,Nombre,Email,Telefono) VALUES (@UserNameP,@ContraseñaP,@NombreP,@EmailP,@Telefonop)";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(SQL, new {UserNameP = usuarioP.UserName, ContraseñaP = usuarioP.Contraseña,NombreP = usuarioP.Nombre,EmailP = usuarioP.Email,Telefonop = usuarioP.Telefono});
        }
    }

    public static Usuario loginUsuario(Usuario usuarioP)
    {
        Usuario obj = null;
        string SQL ="SELECT * FROM Usuario where UserName = @UserName AND Contraseña = @Contraseña";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            obj = db.QueryFirstOrDefault<Usuario>(SQL, new {UserName = usuarioP.UserName, Contraseña = usuarioP.Contraseña});
        }
        return obj;
    }

    public static string olvideMiContraseña(Usuario usuarioP)
    {
        string contraseña = "";
        string SQL = "SELECT Contraseña FROM Usuario where Email = @Email";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            contraseña = db.QueryFirstOrDefault<string>(SQL, new {Email = usuarioP.Email});
        }
        return contraseña;
    }

}