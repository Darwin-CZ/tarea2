using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aporte5tod.clases
{
    public class conexion
    {
        string cadena = "server=localhost; datebase=empleado; Uid=root; pwd=;";
        MySqlCommand comando = new MySqlCommand();
        MySqlConnection con = new MySqlConnection();


    public void Insertar( string nombre, string edad, string dias,  string iess, string ir, string bono1, string total1)
        {
            MySqlConnection conn = new MySqlConnection(cadena);
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO gestion_pago(nombre_empleado,edad,sueldo,dias,descuento_iess,descuento_ir,bono)"+
                "VALUES (@nombre,@edad,@sueldo,@dias,@descuento_iess,@descuento_ir,@bono)";

            cmd.Parameters.AddWithValue("@nombre" , nombre);
            cmd.Parameters.AddWithValue("@edad", edad);
            cmd.Parameters.AddWithValue("@dias", dias);
            cmd.Parameters.AddWithValue("@descuento_iess", iess);
            cmd.Parameters.AddWithValue("@descuento_ir", bono1);

        }
    }

}