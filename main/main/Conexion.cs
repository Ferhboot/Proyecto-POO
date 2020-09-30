using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace main
{
    class Conexion
    {
        //SqlConnection conectar;
        //SqlCommand cmd;
        public SqlConnection conect()
        {
            string cadena;
            string server = "server= poo-proyecto.cx8zwtd8qeeg.us-east-2.rds.amazonaws.com,1433;";
            string db = "database= proyecto_poo;";
            string user = "user id= admin;";
            string pass = "password=poopassword123;";
            cadena = server + db + user + pass;
            SqlConnection conectar = new SqlConnection(cadena);
            conectar.Open();
            return conectar;
        }

        //Este comando será para agregar datos a cualquier tabla
        public void agregarusuario(string table, string userid,string nombre,string pass, int tipo)
        {
            conect();
            string com="";
            com += "insert into " + table +" (userid, nombre, pass, tipocuenta) values ";
            com += "(@userid, @nombre,@pass,@tipocuenta);";
            SqlCommand cmd = new SqlCommand(com,conect());
            cmd.Parameters.Add(new SqlParameter("@userid", SqlDbType.VarChar));
            cmd.Parameters["@userid"].Value = userid;

            cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
            cmd.Parameters["@nombre"].Value = nombre;

            cmd.Parameters.Add(new SqlParameter("@pass", SqlDbType.VarChar));
            cmd.Parameters["@pass"].Value = pass;

            cmd.Parameters.Add(new SqlParameter("@tipocuenta", SqlDbType.Int));
            cmd.Parameters["@tipocuenta"].Value = tipo;

            cmd.ExecuteNonQuery();       
        }

    }
}
