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
        public void agregarusuario(string table, Datos datos)
        {
            conect();
            string com1 = "Select userid from Usuarios where userid=@userid";
            SqlCommand cm = new SqlCommand(com1, conect());
            cm.Parameters.Add(new SqlParameter("@userid", SqlDbType.VarChar));
            cm.Parameters["@userid"].Value = datos.IDusuario;
            SqlDataReader rd = cm.ExecuteReader();


            string com2 = "Select email from Usuarios where email=@email";
            SqlCommand cm2 = new SqlCommand(com2, conect());
            cm2.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar));
            cm2.Parameters["@email"].Value = datos.Email;
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
                com += "insert into Usuarios (userid,email, pass, tipocuenta) values ";
                com += "(@userid,@email,@pass,@tipocuenta);";
                SqlCommand cmd = new SqlCommand(com, conect());
                cmd.Parameters.Add(new SqlParameter("@userid", SqlDbType.VarChar));
                cmd.Parameters["@userid"].Value = datos.IDusuario;

                cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar));
                cmd.Parameters["@email"].Value = datos.Email;

                cmd.Parameters.Add(new SqlParameter("@pass", SqlDbType.VarChar));
                cmd.Parameters["@pass"].Value = datos.Contra;

                cmd.Parameters.Add(new SqlParameter("@tipocuenta", SqlDbType.Int));
                cmd.Parameters["@tipocuenta"].Value = datos.Idtipousuario;

                cmd.ExecuteNonQuery();


                com = "";
                com += "insert into Datos (nombre, apellido, departamento, municipio, direccion, telefono, idUsuario) values ";
                com += "(@nombre, @apellido, @departamento, @municipio, @direccion, @telefono, @idUsuario);";
                cmd = new SqlCommand(com, conect());

                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
                cmd.Parameters["@nombre"].Value = datos.Nombre;

                cmd.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar));
                cmd.Parameters["@apellido"].Value = datos.Apellido;

                cmd.Parameters.Add(new SqlParameter("@departamento", SqlDbType.VarChar));
                cmd.Parameters["@departamento"].Value = datos.Departamento;

                cmd.Parameters.Add(new SqlParameter("@municipio", SqlDbType.VarChar));
                cmd.Parameters["@municipio"].Value = datos.Municipio;

                cmd.Parameters.Add(new SqlParameter("@direccion", SqlDbType.VarChar));
                cmd.Parameters["@direccion"].Value = datos.Direccion;

                cmd.Parameters.Add(new SqlParameter("@telefono", SqlDbType.VarChar));
                cmd.Parameters["@telefono"].Value = datos.Telefono;

                cmd.Parameters.Add(new SqlParameter("@idUsuario", SqlDbType.VarChar));
                cmd.Parameters["@idUsuario"].Value = datos.IDusuario;

                cmd.ExecuteNonQuery();

            }
        }


        public void agregarempresa(string table, Empresa empresa)
        {
            conect();
            string com1 = "Select userid from Usuarios where userid=@userid";
            SqlCommand cm = new SqlCommand(com1, conect());
            cm.Parameters.Add(new SqlParameter("@userid", SqlDbType.VarChar));
            cm.Parameters["@userid"].Value = empresa.IDusuario;
            SqlDataReader rd = cm.ExecuteReader();


            string com2 = "Select email from Usuarios where email=@email";
            SqlCommand cm2 = new SqlCommand(com2, conect());
            cm2.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar));
            cm2.Parameters["@email"].Value = empresa.Email;
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
                com += "insert into Usuarios (userid,email, pass, tipocuenta) values ";
                com += "(@userid,@email,@pass,@tipocuenta);";
                SqlCommand cmd = new SqlCommand(com, conect());
                cmd.Parameters.Add(new SqlParameter("@userid", SqlDbType.VarChar));
                cmd.Parameters["@userid"].Value = empresa.IDusuario;

                cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar));
                cmd.Parameters["@email"].Value = empresa.Email;

                cmd.Parameters.Add(new SqlParameter("@pass", SqlDbType.VarChar));
                cmd.Parameters["@pass"].Value = empresa.Contra;

                cmd.Parameters.Add(new SqlParameter("@tipocuenta", SqlDbType.Int));
                cmd.Parameters["@tipocuenta"].Value = empresa.Idtipousuario;

                cmd.ExecuteNonQuery();


                com = "";
                com += "insert into Datos (nombre, apellido, departamento, municipio, direccion, telefono, idUsuario) values ";
                com += "(@nombre, @apellido, @departamento, @municipio, @direccion, @telefono, @idUsuario);";
                cmd = new SqlCommand(com, conect());

                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
                cmd.Parameters["@nombre"].Value = empresa.Nombre;

                cmd.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar));
                cmd.Parameters["@apellido"].Value = empresa.Apellido;

                cmd.Parameters.Add(new SqlParameter("@departamento", SqlDbType.VarChar));
                cmd.Parameters["@departamento"].Value = empresa.Departamento;

                cmd.Parameters.Add(new SqlParameter("@municipio", SqlDbType.VarChar));
                cmd.Parameters["@municipio"].Value = empresa.Municipio;

                cmd.Parameters.Add(new SqlParameter("@direccion", SqlDbType.VarChar));
                cmd.Parameters["@direccion"].Value = empresa.Direccion;

                cmd.Parameters.Add(new SqlParameter("@telefono", SqlDbType.VarChar));
                cmd.Parameters["@telefono"].Value = empresa.Telefono;

                cmd.Parameters.Add(new SqlParameter("@idUsuario", SqlDbType.VarChar));
                cmd.Parameters["@idUsuario"].Value = empresa.IDusuario;

                cmd.ExecuteNonQuery();



                string getIdDatos = "select iddatos from datos where idusuario=@iduser;";
                SqlCommand obteneridDatos = new SqlCommand(getIdDatos, conect());
                obteneridDatos.Parameters.Add(new SqlParameter("@iduser", SqlDbType.VarChar));
                obteneridDatos.Parameters["@iduser"].Value = empresa.IDusuario;
                SqlDataReader rdid = obteneridDatos.ExecuteReader();
                rdid.Read();
                int iddatos = int.Parse(rdid["iddatos"].ToString());



                com = "";
                com += "insert into Empresa (nombreEmpresa, idDatos) values ";
                com += "(@nombreEmpresa,@idDatos);";
                cmd = new SqlCommand(com, conect());

                cmd.Parameters.Add(new SqlParameter("@nombreEmpresa", SqlDbType.VarChar));
                cmd.Parameters["@nombreEmpresa"].Value = empresa.NombreEmpresa;
                cmd.Parameters.Add(new SqlParameter("@idDatos", SqlDbType.Int));
                cmd.Parameters["@idDatos"].Value = /*empresa.IdDatos*/ iddatos;


                cmd.ExecuteNonQuery();

            }
        }


        public Usuario login(string user, string pass)
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
                Usuario u = new Usuario();
                u.IDusuario = rd["userid"].ToString();
                u.Email = rd["email"].ToString();
                u.Contra = rd["pass"].ToString();
                u.Idtipousuario = int.Parse(rd["tipocuenta"].ToString());

                return u;
            }
            
            else
            {
                throw new Exception("¡Datos Erróneos!");
            }
        }


        public Datos obtenerDatos(Usuario user)
        {
            string com = "Select * from datos where idUsuario=@idUsuario;";
            SqlCommand cmd = new SqlCommand(com, conect());

            cmd.Parameters.Add(new SqlParameter("@idUsuario", SqlDbType.VarChar));
            cmd.Parameters["@idUsuario"].Value = user.IDusuario;

            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                Datos d = new Datos();
                d.IdDatos = int.Parse(rd["idDatos"].ToString());
                d.Nombre = rd["nombre"].ToString();
                d.Apellido = rd["apellido"].ToString();
                d.Departamento = rd["departamento"].ToString();
                d.Municipio = rd["municipio"].ToString();
                d.Direccion = rd["direccion"].ToString();
                d.Telefono = rd["idDatos"].ToString();
                d.IDusuario = user.IDusuario;
                d.Email = user.Email;
                d.Idtipousuario = user.Idtipousuario;

                return d;
            }

            else
            {
                throw new Exception("¡Datos Erróneos!");
            }
        }


        public Empresa obtenerEmpresa(Datos datos)
        {
            string com = "Select * from empresa where idDatos=@idDatos;";
            SqlCommand cmd = new SqlCommand(com, conect());

            cmd.Parameters.Add(new SqlParameter("@idDatos", SqlDbType.Int));
            cmd.Parameters["@idDatos"].Value = datos.IdDatos;

            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                Empresa e = new Empresa();

                e.IdEmpresa = int.Parse(rd["idEmpresa"].ToString());
                e.NombreEmpresa = rd["nombreEmpresa"].ToString();
                e.IdDatos = datos.IdDatos;
                e.Nombre = datos.Nombre;
                e.Apellido = datos.Apellido;
                e.Departamento = datos.Departamento;
                e.Municipio = datos.Municipio;
                e.Direccion = datos.Direccion;
                e.Telefono = datos.Telefono;
                e.IDusuario = datos.IDusuario;
                e.Email = datos.Email;               
                e.Idtipousuario = datos.Idtipousuario;

                return e;
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

