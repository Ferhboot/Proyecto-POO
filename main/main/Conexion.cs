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

        string cadena;
        string server = "server= poo-proyecto.cx8zwtd8qeeg.us-east-2.rds.amazonaws.com,1433;";
        string db = "database= proyecto_poo;";
        string user = "user id= admin;";
        string pass = "password=poopassword123;";


        public SqlConnection conect()
        {
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
                d.Telefono = rd["telefono"].ToString();
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

        public DataSet cargarReportes(string param)
        {
            string cmd = "select * from inforeporte " + param + ";";
            DataSet Datos = new DataSet();
            SqlDataAdapter ad = new SqlDataAdapter(cmd, conect());
            ad.Fill(Datos, "reportes");
            return Datos;
        }

        public void cambiarEstadoReporte(int id)
        {
            string com = "update reporte set estado = 'Leido' where idreporte= @id;";
            SqlCommand cmd = new SqlCommand(com, conect());

            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmd.Parameters["@id"].Value = id;

            cmd.ExecuteNonQuery();
        }

        public void eliminarReporte(int id)
        {
            cadena = server + db + user + pass;
            SqlConnection conectar = new SqlConnection(cadena);
            conectar.Open();
            string com = "delete from reporte where idreporte=@id;";
            SqlCommand cmd = new SqlCommand(com, conectar);
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmd.Parameters["@id"].Value = id;

            cmd.ExecuteNonQuery();
            conectar.Close();
        }

        public DataSet leercat1()
        {
            string cmd = "select * from categorias;";
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


        public void actualizardatos(string nom, string ap, string dep, string mun, string dir, string tel, string id)
        {
            string com = "update datos set departamento=@departamento, nombre=@nombre, " +
                "municipio=@municipio, direccion=@direccion, telefono=@telefono, apellido=@apellido " +
                "where idusuario=@userid;";
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

            cmd.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar));
            cmd.Parameters["@apellido"].Value = ap;

            cmd.Parameters.Add(new SqlParameter("@userid", SqlDbType.VarChar));
            cmd.Parameters["@userid"].Value = id;

            cmd.ExecuteNonQuery();
        }



        public void agregarBienOServicio(string table, BienOServicio b)
        {
            conect();

            string com = "";
            com += "insert into BienOServicio (nombre, descripcion, precio,cantidad,imagen,mayoreo,idCategoria,idUsuario) values ";
            com += "(@nombre,@descripcion,@precio,@cantidad,@imagen,@mayoreo,@idCategoria,@idUsuario);";

            SqlCommand cmd = new SqlCommand(com, conect());

            cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
            cmd.Parameters["@nombre"].Value = b.Nombre;

            cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.Text));
            cmd.Parameters["@descripcion"].Value = b.Descripcion;

            cmd.Parameters.Add(new SqlParameter("@precio", SqlDbType.Float));
            cmd.Parameters["@precio"].Value = b.Precio;

            cmd.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Int));
            cmd.Parameters["@cantidad"].Value = b.Cantidad;

            cmd.Parameters.Add(new SqlParameter("@imagen", SqlDbType.Image));
            cmd.Parameters["@imagen"].Value = b.Imagen;

            cmd.Parameters.Add(new SqlParameter("@mayoreo", SqlDbType.Int));
            cmd.Parameters["@mayoreo"].Value = b.Mayoreo;

            cmd.Parameters.Add(new SqlParameter("@idCategoria", SqlDbType.Int));
            cmd.Parameters["@idCategoria"].Value = b.Cat.Idcategoria;

            cmd.Parameters.Add(new SqlParameter("@idUsuario", SqlDbType.VarChar));
            cmd.Parameters["@idUsuario"].Value = b.User.IDusuario;

            cmd.ExecuteNonQuery();

        }

        public List<BienOServicio> listaBienOServicio()
        {
            string consulta = "select * from BienOServicio WHERE cantidad>0 or cantidad=-1;";
            SqlCommand cmd = new SqlCommand(consulta, conect());

            List<BienOServicio> lista = new List<BienOServicio>();

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                BienOServicio b = new BienOServicio();

                b.IdBienOServicio = int.Parse(rd["idBienOServicio"].ToString());
                b.Precio = float.Parse(rd["precio"].ToString());
                b.Imagen = (byte[])rd["imagen"];
                b.Nombre = rd["nombre"].ToString();

                lista.Add(b);
            }

            return lista;

        }

        public List<BienOServicio> listaPorCategoria(string categoria)
        {

            string getIdCat = "SELECT idcategoria FROM categorias WHERE nombre = @nombre;";
            SqlCommand obteneridCat = new SqlCommand(getIdCat, conect());
            obteneridCat.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
            obteneridCat.Parameters["@nombre"].Value = categoria;
            SqlDataReader rdid = obteneridCat.ExecuteReader();
            rdid.Read();
            int idcategoria = int.Parse(rdid["idcategoria"].ToString());

            string consulta = "select * from BienOServicio WHERE (cantidad>0 or cantidad=-1) AND (idCategoria = @idCategoria);";
            SqlCommand cmd = new SqlCommand(consulta, conect());

            cmd.Parameters.Add(new SqlParameter("@idCategoria", SqlDbType.Int));
            cmd.Parameters["@idCategoria"].Value = idcategoria;

            List<BienOServicio> lista = new List<BienOServicio>();

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                BienOServicio b = new BienOServicio();

                b.IdBienOServicio = int.Parse(rd["idBienOServicio"].ToString());
                b.Precio = float.Parse(rd["precio"].ToString());
                b.Imagen = (byte[])rd["imagen"];
                b.Nombre = rd["nombre"].ToString();

                lista.Add(b);
            }

            return lista;

        }


        public List<BienOServicio> buscarBienOServicio(string nombre)
        {
            string consulta = "select * from BienOServicio WHERE (cantidad>0 or cantidad=-1) AND nombre like '%'+@nombre+'%' ;";
            SqlCommand cmd = new SqlCommand(consulta, conect());
            cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
            cmd.Parameters["@nombre"].Value = nombre;

            List<BienOServicio> lista = new List<BienOServicio>();

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                BienOServicio b = new BienOServicio();

                b.IdBienOServicio = int.Parse(rd["idBienOServicio"].ToString());
                b.Precio = float.Parse(rd["precio"].ToString());
                b.Imagen = (byte[])rd["imagen"];
                b.Nombre = rd["nombre"].ToString();

                lista.Add(b);
            }

            return lista;

        }

        //Para leer datos de una categoría
        public Categoria datoscat(int id)
        {
            SqlCommand cmd = new SqlCommand("select top 1 * from datoscategoria where id=@id;", conect());
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmd.Parameters["@id"].Value = id;
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            Categoria cat = new Categoria();
            cat.Idcategoria = int.Parse(rd[0].ToString());
            cat.Nombre = rd[1].ToString();
            cat.Cantidad = int.Parse(rd[2].ToString());

            return cat;
        }

        //Para modificar una categoría
        public bool modificarCat(int id, string nuevoNombre)
        {
            string com = "update categorias set nombre = @nuevonombre where idcategoria=@id;";
            SqlCommand cmd = new SqlCommand(com, conect());
            cmd.Parameters.Add(new SqlParameter("@nuevonombre", SqlDbType.VarChar));
            cmd.Parameters["@nuevonombre"].Value = nuevoNombre;

            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmd.Parameters["@id"].Value = id;

            if (cmd.ExecuteNonQuery() > 0) return true;
            else return false;
        }

        public bool agregarCat(string nom)
        {
            cadena = cadena = server + db + user + pass;
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            string com = "insert into categorias (Nombre) values (@nom)";
            SqlCommand cmd = new SqlCommand(com, conexion);
            cmd.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar));
            cmd.Parameters["@nom"].Value = nom;
            if (cmd.ExecuteNonQuery() > 0) { conexion.Close(); return true; }
            else { conexion.Close(); return false; }
        }

        public bool eliminarCat(int id)
        {
            cadena = cadena = server + db + user + pass;
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            string com = "delete from categorias where idcategoria =@id";
            SqlCommand cmd = new SqlCommand(com, conexion);
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmd.Parameters["@id"].Value = id;
            if (cmd.ExecuteNonQuery() > 0) { conexion.Close(); return true; }
            else { conexion.Close(); return false; }
        }

        public void enviarReporte(string id, string mensaje)
        {
            cadena = server + db + user + pass;
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();

            string com = "insert into reporte (userid, mensaje) values (@id, @mensaje);";
            SqlCommand cmd = new SqlCommand(com, conexion);

            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.VarChar));
            cmd.Parameters["@id"].Value = id;

            cmd.Parameters.Add(new SqlParameter("@mensaje", SqlDbType.VarChar));
            cmd.Parameters["@mensaje"].Value = mensaje;

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public DataSet mostrarAdmin()
        {
            cadena = server + db + user + pass;
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();

            string com = "select userid as [ID Usuario], email as [Email] from Usuarios where tipocuenta=3;";
            DataSet ds = new DataSet();
            SqlDataAdapter ad = new SqlDataAdapter(com, conexion);
            ad.Fill(ds, "administradores");
            conexion.Close();
            return ds;
        }

        public void agregarAdmin(string id, string email, string clave)
        {
            cadena = server + db + user + pass;
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();

            string com = "insert into usuarios values (@id, @email, @pass, 3);";

            SqlCommand cmd = new SqlCommand(com, conexion);

            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.VarChar));
            cmd.Parameters["@id"].Value = id;

            cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar));
            cmd.Parameters["@email"].Value = email;

            cmd.Parameters.Add(new SqlParameter("@pass", SqlDbType.VarChar));
            cmd.Parameters["@pass"].Value = clave;

            cmd.ExecuteNonQuery();

            conexion.Close();
        }

        public int numeroMensajes(string id)
        {
            cadena = server + db + user + pass;
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            string com = "select count(estado) from mensaje where id_destino=@id and estado='no leido';";

            SqlCommand cmd = new SqlCommand(com, conexion);
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.VarChar));
            cmd.Parameters["@id"].Value = id;

            SqlDataReader rd = cmd.ExecuteReader();
            int num = 0;
            if (rd.Read())
            {
                num = int.Parse(rd[0].ToString());
            }
            return num;
        }

        public DataSet verMensajes(string id, string param)
        {
            cadena = server + db + user + pass;
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            string com = "select idmensaje as [ID Mensaje] " +
                ",id_origen as [Usuario Remitente], Datos.nombre +' ' +Datos.apellido as 'Nombre', " +
                "mensaje as 'Mensaje', estado as 'Estado' from mensaje " +
                "left join Datos on Datos.idUsuario = mensaje.id_origen " +
                "where id_destino='" + id + "' " + param + ";";
            DataSet ds = new DataSet();
            SqlDataAdapter ad = new SqlDataAdapter(com, conexion);
            ad.Fill(ds, "mensajes");
            return ds;
        }

        public bool eliminarMensaje(int idmensaje)
        {
            cadena = server + db + user + pass;
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            string com = "delete from mensaje where idmensaje=@idmensaje;";
            SqlCommand cmd = new SqlCommand(com, conexion);

            cmd.Parameters.Add(new SqlParameter("@idmensaje", SqlDbType.Int));
            cmd.Parameters["@idmensaje"].Value = idmensaje;

            cmd.ExecuteNonQuery();

            conexion.Close();
            return true;
        }

        public void enviarMensaje(string origen, string destino, string mensaje)
        {
            cadena = server + db + user + pass;
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            string com = "insert into mensaje (id_destino, id_origen, mensaje) " +
                "values (@destino, @origen, @mensaje);";
            SqlCommand cmd = new SqlCommand(com, conexion);

            cmd.Parameters.Add(new SqlParameter("@destino", SqlDbType.VarChar));
            cmd.Parameters["@destino"].Value = destino;

            cmd.Parameters.Add(new SqlParameter("@origen", SqlDbType.VarChar));
            cmd.Parameters["@origen"].Value = origen;

            cmd.Parameters.Add(new SqlParameter("@mensaje", SqlDbType.VarChar));
            cmd.Parameters["@mensaje"].Value = mensaje;

            cmd.ExecuteNonQuery();

            conexion.Close();
        }

        public void cambiarEstadoMensaje(int id)
        {
            cadena = server + db + user + pass;
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            string com = "update mensaje set estado = 'Leido' where idmensaje= @id;";
            SqlCommand cmd = new SqlCommand(com, conexion);
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmd.Parameters["@id"].Value = id;

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public BienOServicio verProducto(int id)
        {
            cadena = server + db + user + pass;
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            string com = "select BienOServicio.*, categorias.nombre as 'categoria' from BienOServicio INNER JOIN categorias on categorias.idcategoria = BienOServicio.idCategoria WHERE BienOServicio.idBienOServicio=" + id + ";";
            SqlCommand cmd = new SqlCommand(com, conexion);

            SqlDataReader rd = cmd.ExecuteReader();

            BienOServicio b = new BienOServicio();

            if (rd.Read())
            {

                b.IdBienOServicio = int.Parse(rd["idBienOServicio"].ToString());
                b.Precio = float.Parse(rd["precio"].ToString());
                b.Imagen = (byte[])rd["imagen"];
                b.Nombre = rd["nombre"].ToString();
                b.Descripcion = rd["descripcion"].ToString();
                b.Cantidad = int.Parse(rd["cantidad"].ToString());
                b.Cat = new Categoria();
                b.Cat.Nombre = rd["categoria"].ToString();
                b.User = new Usuario();
                b.User.IDusuario = rd["idUsuario"].ToString();

            }

            conexion.Close();
            return b;
        }

        public String nombre(string userid)
        {
            cadena = server + db + user + pass;
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            string com = "select Empresa.nombreEmpresa FROM Empresa INNER JOIN Datos on Datos.idDatos = Empresa.idDatos INNER JOIN Usuarios on Usuarios.userid = Datos.idUsuario WHERE Usuarios.userid='" + userid + "';";
            SqlCommand cmd = new SqlCommand(com, conexion);
            SqlDataReader rd = cmd.ExecuteReader();

            string nom;

            if (rd.Read())
            {

                nom = rd["nombreEmpresa"].ToString();

            }
            else
            {
                string com1 = "select Datos.nombre,Datos.apellido FROM Datos INNER JOIN Usuarios on Usuarios.userid = Datos.idUsuario WHERE Usuarios.userid='" + userid + "';";
                SqlCommand cmd1 = new SqlCommand(com, conexion);
                SqlDataReader rd1 = cmd.ExecuteReader();

                if (rd1.Read())
                {

                    nom = rd["nombre"].ToString() + rd["nombre"].ToString();

                }
                else
                {
                    nom = "";
                }

            }

            conexion.Close();
            return nom;

        }


        public bool agregarPedido(string idUsuario, int idBienOServicio, int cantidad)
        {

            cadena = server + db + user + pass + "MultipleActiveResultSets=true;";
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();

            if (obtenerIdCompra(idUsuario) == 0)
            {
                DateTime fechaActual = DateTime.Today;

                string com = "insert into compra (fechaCompra, estadoCompra, idUsuario) " +
                "values (@fechaCompra, @estadoCompra, @idUsuario);";
                SqlCommand cmd = new SqlCommand(com, conexion);

                cmd.Parameters.Add(new SqlParameter("@fechaCompra", SqlDbType.Date));
                cmd.Parameters["@fechaCompra"].Value = fechaActual;

                cmd.Parameters.Add(new SqlParameter("@estadoCompra", SqlDbType.Int));
                cmd.Parameters["@estadoCompra"].Value = 0;

                cmd.Parameters.Add(new SqlParameter("@idUsuario", SqlDbType.VarChar));
                cmd.Parameters["@idUsuario"].Value = idUsuario;

                cmd.ExecuteNonQuery();

            }


            string getCantidad = "select cantidad from BienOServicio where idBienOServicio=@idBienOServicio;";
            SqlCommand obtenerCantidad = new SqlCommand(getCantidad, conexion);
            obtenerCantidad.Parameters.Add(new SqlParameter("@idBienOServicio", SqlDbType.Int));
            obtenerCantidad.Parameters["@idBienOServicio"].Value = idBienOServicio;

            SqlDataReader rdc = obtenerCantidad.ExecuteReader();

            int cant = 0;
            if (rdc.Read())
            {
                cant = int.Parse(rdc["cantidad"].ToString());
            }


            string getPedido = "select COUNT(idBienOServicio) AS total from Carrito where idBienOServicio=@idBienOServicio;";
            SqlCommand obtenerPedidos = new SqlCommand(getPedido, conexion);
            obtenerPedidos.Parameters.Add(new SqlParameter("@idBienOServicio", SqlDbType.Int));
            obtenerPedidos.Parameters["@idBienOServicio"].Value = idBienOServicio;

            SqlDataReader rdc1 = obtenerPedidos.ExecuteReader();

            int total = 0;
            if (rdc1.Read())
            {
                total = int.Parse(rdc1["total"].ToString());
            }




            if (cant == -1 && total == 0)
            {


                string com1 = "insert into Carrito (idBienOServicio, idCompra) " +
                                "values (@idBienOServicio, @idCompra);";
                SqlCommand cmd1 = new SqlCommand(com1, conexion);

                cmd1.Parameters.Add(new SqlParameter("@idBienOServicio", SqlDbType.Int));
                cmd1.Parameters["@idBienOServicio"].Value = idBienOServicio;

                cmd1.Parameters.Add(new SqlParameter("@idCompra", SqlDbType.Int));
                cmd1.Parameters["@idCompra"].Value = obtenerIdCompra(idUsuario);

                cmd1.ExecuteNonQuery();


            }
            else
            {
                if (cant >= cantidad)
                {


                    for (int i = 0; i < cantidad; i++)
                    {

                        string com3 = "insert into Carrito (idBienOServicio, idCompra) " +
                                "values (@idBienOServicio, @idCompra);";
                        SqlCommand cmd3 = new SqlCommand(com3, conexion);

                        cmd3.Parameters.Add(new SqlParameter("@idBienOServicio", SqlDbType.Int));
                        cmd3.Parameters["@idBienOServicio"].Value = idBienOServicio;

                        cmd3.Parameters.Add(new SqlParameter("@idCompra", SqlDbType.Int));
                        cmd3.Parameters["@idCompra"].Value = obtenerIdCompra(idUsuario);

                        cmd3.ExecuteNonQuery();

                        string com2 = "update BienOServicio SET cantidad = cantidad - @cantidad WHERE idBienOServicio=@idBienOServicio;";
                        SqlCommand cmd2 = new SqlCommand(com2, conexion);

                        cmd2.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Int));
                        cmd2.Parameters["@cantidad"].Value = cantidad;

                        cmd2.Parameters.Add(new SqlParameter("@idBienOServicio", SqlDbType.Int));
                        cmd2.Parameters["@idBienOServicio"].Value = idBienOServicio;

                        cmd2.ExecuteNonQuery();

                    }

                }
                else
                {
                    return false;
                }
            }

            conexion.Close();
            return true;
        }


        public int obtenerIdCompra(String iduser)
        {

            cadena = server + db + user + pass;
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();


            string getIdCompra = "select idCompra from Compra where estadoCompra=@estadoCompra and idUsuario=@idUsuario;";
            SqlCommand obteneridCompra = new SqlCommand(getIdCompra, conexion);
            obteneridCompra.Parameters.Add(new SqlParameter("@estadoCompra", SqlDbType.Int));
            obteneridCompra.Parameters["@estadoCompra"].Value = 0;
            obteneridCompra.Parameters.Add(new SqlParameter("@idUsuario", SqlDbType.VarChar));
            obteneridCompra.Parameters["@idUsuario"].Value = iduser;
            SqlDataReader rdid = obteneridCompra.ExecuteReader();
            int idCompra = 0;
            if (rdid.Read()) {
                idCompra = int.Parse(rdid["idCompra"].ToString());
            }

            conexion.Close();

            return idCompra;

        }

        public int numeroCarrito(string id)
        {
            cadena = server + db + user + pass;
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            string com = "select COUNT(Carrito.idCarrito) from Compra INNER JOIN Carrito on Carrito.idCompra = Compra.idCompra where Compra.estadoCompra=0 and Compra.idUsuario=@idUsuario;";

            SqlCommand cmd = new SqlCommand(com, conexion);
            cmd.Parameters.Add(new SqlParameter("@idUsuario", SqlDbType.VarChar));
            cmd.Parameters["@idUsuario"].Value = id;

            SqlDataReader rd = cmd.ExecuteReader();
            int num = 0;
            if (rd.Read())
            {
                num = int.Parse(rd[0].ToString());
            }
            return num;
        }

        public DataSet verCarrito(string id)
        {
            cadena = server + db + user + pass;
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            string com = "select BienOServicio.idBienOServicio AS [ID],BienOServicio.cantidad AS [TIPO], BienOServicio.nombre AS [NOMBRE], CAST(BienOServicio.descripcion AS NVARCHAR(100)) AS [DESCRIPCION], COUNT(Carrito.idCarrito) AS [CANTIDAD], BienOServicio.precio AS [PRECIO UNITARIO], BienOServicio.idUsuario as [Vendedor]  from Compra INNER JOIN Carrito on Carrito.idCompra = Compra.idCompra INNER JOIN BienOServicio on BienOServicio.idBienOServicio = Carrito.idBienOServicio where Compra.estadoCompra=0 and Compra.idUsuario='" + id + "' group by BienOServicio.idBienOServicio, BienOServicio.cantidad, BienOServicio.nombre, CAST(BienOServicio.descripcion AS NVARCHAR(100)), BienOServicio.precio, BienOServicio.idUsuario;";
            DataSet ds = new DataSet();
            SqlDataAdapter ad = new SqlDataAdapter(com, conexion);
            ad.Fill(ds, "carrito");

            conexion.Close();
            return ds;
        }


        public int precioTotal(string id)
        {
            cadena = server + db + user + pass;
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            string com = "select sum(BienOServicio.precio) AS [PRECIO] from Compra INNER JOIN Carrito on Carrito.idCompra = Compra.idCompra INNER JOIN BienOServicio on BienOServicio.idBienOServicio = Carrito.idBienOServicio where Compra.estadoCompra=0 and Compra.idUsuario='" + id + "';";

            SqlCommand cmd = new SqlCommand(com, conexion);
            cmd.Parameters.Add(new SqlParameter("@idUsuario", SqlDbType.VarChar));
            cmd.Parameters["@idUsuario"].Value = id;

            SqlDataReader rd = cmd.ExecuteReader();
            int num = 0;
            if (rd.Read())
            {
                num = int.Parse(rd[0].ToString());
            }
            conexion.Close();
            return num;
        }



        public bool actualizarCarrito(string idUsuario, int idBienOServicio, int cantidad, int cantidadActual)
        {

            cadena = server + db + user + pass + "MultipleActiveResultSets=true;";
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();


            if (cantidadActual > cantidad)
            {
                int diferencia = cantidadActual - cantidad;
                //string com3 = "delete from Carrito where idCarrrito in (select top @cantidad Carrito.idCarrito from Carrito INNER JOIN Compra on Compra.idCompra = Carrito.idCompra where idBienOServicio=@idBienOServicio and Compra.estadoCompra=0); ";
                string com3 = "delete from Carrito where idCarrito in (select top " + diferencia.ToString() +" Carrito.idCarrito from Carrito INNER JOIN Compra on Compra.idCompra = Carrito.idCompra where idBienOServicio=@idBienOServicio and Compra.estadoCompra=0); ";
                SqlCommand cmd3 = new SqlCommand(com3, conexion);

                cmd3.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Int));
                cmd3.Parameters["@cantidad"].Value = cantidad;

                cmd3.Parameters.Add(new SqlParameter("@idBienOServicio", SqlDbType.Int));
                cmd3.Parameters["@idBienOServicio"].Value = idBienOServicio;

                cmd3.ExecuteNonQuery();

                string com2 = "update BienOServicio SET cantidad = cantidad+ @cantidad WHERE idBienOServicio=@idBienOServicio;";
                SqlCommand cmd2 = new SqlCommand(com2, conexion);

                cmd2.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Int));
                cmd2.Parameters["@cantidad"].Value = diferencia;

                cmd2.Parameters.Add(new SqlParameter("@idBienOServicio", SqlDbType.Int));
                cmd2.Parameters["@idBienOServicio"].Value = idBienOServicio;

                cmd2.ExecuteNonQuery();

                
            }else if(cantidadActual < cantidad)
            {

                int diferencia2 = cantidad - cantidadActual;
                string getCantidad = "select cantidad from BienOServicio where idBienOServicio=@idBienOServicio;";
                SqlCommand obtenerCantidad = new SqlCommand(getCantidad, conexion);
                obtenerCantidad.Parameters.Add(new SqlParameter("@idBienOServicio", SqlDbType.Int));
                obtenerCantidad.Parameters["@idBienOServicio"].Value = idBienOServicio;

                SqlDataReader rdc = obtenerCantidad.ExecuteReader();

                int cant = 0;
                if (rdc.Read())
                {
                    cant = int.Parse(rdc["cantidad"].ToString());
                }


                if (cant >= cantidad) { 

                    for (int i = 0; i < diferencia2; i++)
                    {

                        string com3 = "insert into Carrito (idBienOServicio, idCompra) " +
                                "values (@idBienOServicio, @idCompra);";
                        SqlCommand cmd3 = new SqlCommand(com3, conexion);

                        cmd3.Parameters.Add(new SqlParameter("@idBienOServicio", SqlDbType.Int));
                        cmd3.Parameters["@idBienOServicio"].Value = idBienOServicio;

                        cmd3.Parameters.Add(new SqlParameter("@idCompra", SqlDbType.Int));
                        cmd3.Parameters["@idCompra"].Value = obtenerIdCompra(idUsuario);

                        cmd3.ExecuteNonQuery();

                    }


                    string com2 = "update BienOServicio SET cantidad = cantidad - @cantidad WHERE idBienOServicio=@idBienOServicio;";
                    SqlCommand cmd2 = new SqlCommand(com2, conexion);

                    cmd2.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Int));
                    cmd2.Parameters["@cantidad"].Value = diferencia2;

                    cmd2.Parameters.Add(new SqlParameter("@idBienOServicio", SqlDbType.Int));
                    cmd2.Parameters["@idBienOServicio"].Value = idBienOServicio;

                    cmd2.ExecuteNonQuery();


                }
                else
                {
                    return false;
                }

                conexion.Close();
            }

            conexion.Close();
            return true;
        }

        public void eliminarDelCarrito(int idProducto, string userid, int cantidad)
        {
            cadena = server + db + user + pass;
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();

            int idcompra = obtenerIdCompra(userid);
            string com1 = "delete from carrito where idcompra=@idcompra and idbienoservicio=@idproducto;";
            SqlCommand cmd1 = new SqlCommand(com1, conexion);
            cmd1.Parameters.Add(new SqlParameter("@idcompra", SqlDbType.Int));
            cmd1.Parameters["@idcompra"].Value = idcompra;
            cmd1.Parameters.Add(new SqlParameter("@idproducto", SqlDbType.Int));
            cmd1.Parameters["@idproducto"].Value = idProducto;
            cmd1.ExecuteNonQuery();
            
            if (cantidad != -1)
            {
                string com2 = "update bienoservicio set cantidad=cantidad+@cantidad where idbienoservicio=@idproducto;";
                SqlCommand cmd2 = new SqlCommand(com2, conexion);
                cmd2.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Int));
                cmd2.Parameters["@cantidad"].Value = cantidad;
                cmd2.Parameters.Add(new SqlParameter("@idproducto", SqlDbType.Int));
                cmd2.Parameters["@idproducto"].Value = idProducto;
                cmd2.ExecuteNonQuery();
            }

            conexion.Close();
        }

        public string ObtenerDatosConf(string idusuario)
        {
            cadena = server + db + user + pass;
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            string com = "select top 1 nombre + ' ' + apellido as Nombre, direccion as Direccion, municipio + ', ' + departamento as Municipio, telefono as Telefono from Datos where idUsuario = @id;";
            SqlCommand cmd = new SqlCommand(com, conexion);
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.VarChar));
            cmd.Parameters["@id"].Value = idusuario;
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                string nom = rd[0].ToString();
                string dir = rd[1].ToString();
                string mun = rd[2].ToString();
                string tel = rd[3].ToString();

                string info = nom + ", " + dir + ". " + mun + ". " + tel;
                conexion.Close();
                return info;
            }
            else
            {
                conexion.Close();
                throw new Exception("Hubo un error grave, por favor intente en breve");
            }

        }

        public string ObtenerNombre(string idusuario)
        {
            cadena = server + db + user + pass;
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            string com = "select top 1 nombre + ' ' + apellido as Nombre from datos where idUsuario = @id;";
            SqlCommand cmd = new SqlCommand(com, conexion);
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.VarChar));
            cmd.Parameters["@id"].Value = idusuario;
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                string nom = rd[0].ToString();
                conexion.Close();
                return nom;               
            }
            else
            {
                conexion.Close();
                throw new Exception("Hubo un error grave, por favor intente en breve");                
            }
        }

        public void AlertarCompra(string origen, string destino, string mensaje)
        {
            cadena = server + db + user + pass;
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            string com = "insert into mensaje (id_destino, id_origen, mensaje) values (@destino, @origen, @mensaje);";
            SqlCommand cmd = new SqlCommand(com, conexion);
            cmd.Parameters.Add(new SqlParameter("@destino", SqlDbType.VarChar));
            cmd.Parameters["@destino"].Value = destino;
            cmd.Parameters.Add(new SqlParameter("@origen", SqlDbType.VarChar));
            cmd.Parameters["@origen"].Value = origen;
            cmd.Parameters.Add(new SqlParameter("@mensaje", SqlDbType.VarChar));
            cmd.Parameters["@mensaje"].Value = mensaje;
            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void CambiarEstadoCompra(string idusuario)
        {
            cadena = server + db + user + pass;
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            string com = "update Compra set estadocompra=1 where idusuario=@user and estadocompra=0;";
            SqlCommand cmd = new SqlCommand(com, conexion);
            cmd.Parameters.Add(new SqlParameter("@user", SqlDbType.VarChar));
            cmd.Parameters["@user"].Value = idusuario;
            cmd.ExecuteNonQuery();
            conexion.Close();
        }



        public List<ComprobanteVenta> verComprobante(string id)
        {
            cadena = server + db + user + pass;
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            string com = "select BienOServicio.nombre AS [NOMBRE], COUNT(Carrito.idCarrito) AS [CANTIDAD], BienOServicio.precio AS [PRECIO UNITARIO] from Compra INNER JOIN Carrito on Carrito.idCompra = Compra.idCompra INNER JOIN BienOServicio on BienOServicio.idBienOServicio = Carrito.idBienOServicio where Compra.estadoCompra=0 and Compra.idUsuario='" + id + "' group by BienOServicio.nombre, BienOServicio.precio;";

            SqlCommand cmd = new SqlCommand(com, conexion);

            List<ComprobanteVenta> lista = new List<ComprobanteVenta>();

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ComprobanteVenta cv = new ComprobanteVenta();

                cv.Precio = float.Parse(rd["PRECIO UNITARIO"].ToString());
                cv.Nombre = rd["NOMBRE"].ToString();
                cv.Cantidad = int.Parse(rd["CANTIDAD"].ToString());

                lista.Add(cv);
            }

            conexion.Close();
            return lista;
        }


    }

}

