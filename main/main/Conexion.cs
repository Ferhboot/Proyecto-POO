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

        //Este comando será para agregar datos a USUARIOS
        public void agregarusuario(string table, string userid, string nombre, string email, string pass, int tipo)
        {
            conect();
            string com1 = "Select userid from Usuarios where userid=@userid";
            SqlCommand cm = new SqlCommand(com1, conect());
            cm.Parameters.Add(new SqlParameter("@userid", SqlDbType.VarChar));
            cm.Parameters["@userid"].Value = userid;
            SqlDataReader rd = cm.ExecuteReader();


            string com2 = "Select email from Usuarios where email=@email";
            SqlCommand cm2 = new SqlCommand(com2, conect());
            cm2.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar));
            cm2.Parameters["@email"].Value = email;
            SqlDataReader rd2 = cm2.ExecuteReader();


            if (rd.Read())
            {
                throw new Exception("¡El usuario ya existe!");

            }

            else if (rd2.Read())
            {
                throw new Exception("¡El correo indicado ya está registrado!");

            }
            else
            {
                string com = "";
                com += "insert into " + table + " (userid, nombre,email, pass, tipocuenta) values ";
                com += "(@userid, @nombre,@email,@pass,@tipocuenta);";
                SqlCommand cmd = new SqlCommand(com, conect());
                cmd.Parameters.Add(new SqlParameter("@userid", SqlDbType.VarChar));
                cmd.Parameters["@userid"].Value = userid;

                cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar));
                cmd.Parameters["@email"].Value = email;

                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
                cmd.Parameters["@nombre"].Value = nombre;

                cmd.Parameters.Add(new SqlParameter("@pass", SqlDbType.VarChar));
                cmd.Parameters["@pass"].Value = pass;

                cmd.Parameters.Add(new SqlParameter("@tipocuenta", SqlDbType.Int));
                cmd.Parameters["@tipocuenta"].Value = tipo;

                cmd.ExecuteNonQuery();
            }
        }

            public Datos login(string user, string pass)
        {
            string com = "Select * from Usuarios where userid=@userid and pass=@pass;";
            SqlCommand cmd = new SqlCommand(com, conect());

            cmd.Parameters.Add(new SqlParameter("@userid", SqlDbType.VarChar));
            cmd.Parameters["@userid"].Value = user;

            cmd.Parameters.Add(new SqlParameter("@pass", SqlDbType.VarChar));
            cmd.Parameters["@pass"].Value = pass;

            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                Datos d = new Datos();
                d.IDusuario = rd["userid"].ToString();
                d.Nombre = rd["nombre"].ToString();
                d.Email = rd["email"].ToString();
                d.Contra = rd["pass"].ToString();
                d.Idtipousuario = int.Parse(rd["tipocuenta"].ToString());
                d.Departamento = rd["departamento"].ToString();
                d.Municipio = rd["municipio"].ToString();
                d.Direccion = rd["direccion"].ToString();
                d.Telefono = rd["telefono"].ToString();
                return d;
            }
            
            else
            {
                throw new Exception("¡Datos Erróneos!");
            }
        }

        public DataSet leercat()
        {
            string cmd = "select nombre from categorias;";
            DataSet datos = new DataSet();
            SqlDataAdapter ad = new SqlDataAdapter(cmd, conect());
            ad.Fill(datos, "categorias");
            return datos;
        }

        public void actualizarpass(string user, string pass)
        {
            conect();
            string com = "update usuarios set pass=@pass where userid=@userid;";
            SqlCommand cmd = new SqlCommand(com, conect());
            cmd.Parameters.Add(new SqlParameter("@pass", SqlDbType.VarChar));
            cmd.Parameters["@pass"].Value = pass;
            cmd.Parameters.Add(new SqlParameter("@userid", SqlDbType.VarChar));
            cmd.Parameters["@userid"].Value = user;
            cmd.ExecuteNonQuery();
        }


        public void actualizardatos(string nom, string dep, string mun, string dir, string tel, string id)
        {
            string com = "update usuarios set departamento=@departamento, nombre=@nombre, " +
                "municipio=@municipio, direccion=@direccion, telefono=@telefono " +
                "where userid=@userid;";
            SqlCommand cmd = new SqlCommand(com, conect());

            cmd.Parameters.Add(new SqlParameter("@departamento", SqlDbType.VarChar));
            cmd.Parameters["@departamento"].Value = dep;

            cmd.Parameters.Add(new SqlParameter("@municipio", SqlDbType.VarChar));
            cmd.Parameters["@municipio"].Value = mun;

            cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
            cmd.Parameters["@nombre"].Value = nom; 

            cmd.Parameters.Add(new SqlParameter("@direccion", SqlDbType.VarChar));
            cmd.Parameters["@direccion"].Value = dir;

            cmd.Parameters.Add(new SqlParameter("@telefono", SqlDbType.VarChar));
            cmd.Parameters["@telefono"].Value = tel;

            cmd.Parameters.Add(new SqlParameter("@userid", SqlDbType.VarChar));
            cmd.Parameters["@userid"].Value = id;
            
            cmd.ExecuteNonQuery();
        }
              
        }

    }

