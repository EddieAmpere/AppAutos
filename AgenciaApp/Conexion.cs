using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AgenciaApp
{
    class Conexion
    {
        SqlConnection Conecta = new SqlConnection("Data Source=DESKTOP-O8B72AR; Initial Catalog=aplicacioncarros;Integrated Security=true");
        public void Conectar()
        {
            Conecta.Open();
        }
        public void Desconectar()
        {
            Conecta.Close();
        }
        public DataTable Consulta()
        {
            Conectar();
            SqlCommand cmd = new SqlCommand("Select * From inventario", Conecta);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Desconectar();
            return dt;
        }

        public void altas(string modelo, string marca, string color, int año, int precio, int kilometraje, string transmisión)
        {
            Conectar();
            SqlCommand cmd = new SqlCommand("Insert Into inventario Values (@Modelo, @Marca, @Color, @Año, @Precio, @Kilometraje, @Transmision)", Conecta);
            cmd.Parameters.Add("@Modelo", SqlDbType.VarChar, 60).Value = modelo;
            cmd.Parameters.Add("@Marca", SqlDbType.VarChar, 60).Value = marca;
            cmd.Parameters.Add("@Color", SqlDbType.VarChar, 60).Value = color;
            cmd.Parameters.Add("@Año", SqlDbType.Int, 4).Value = año;
            cmd.Parameters.Add("@Precio", SqlDbType.Int, 7).Value = precio;
            cmd.Parameters.Add("@Kilometraje", SqlDbType.Int, 7).Value = kilometraje;
            cmd.Parameters.Add("@Transmision", SqlDbType.VarChar, 60).Value = transmisión;
            cmd.ExecuteNonQuery();
            Desconectar();
        }

        public DataTable Buscar(int IdVehiculo)
        {
            Conectar();
            SqlCommand cmd = new SqlCommand("Select * from inventario where IdVehiculo=@IdVehiculo", Conecta);
            cmd.Parameters.Add("@IdVehiculo", SqlDbType.Int, 4).Value = IdVehiculo;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Desconectar();
            return dt;
        }

        public bool Bajas(int IdVehiculo)
        {
            Conectar();
            bool baja = false;
            SqlCommand cmd = new SqlCommand("Delete from inventario Where IdVehiculo=@IdVehiculo", Conecta);
            cmd.Parameters.Add("@IdVehiculo", SqlDbType.Int, 4).Value = IdVehiculo;
            try
            {
                cmd.ExecuteNonQuery();
                baja = true;
                return baja;
            }
            catch
            {
                return baja;
            }
            finally
            {
                Desconectar();
            }
        }

        public void Cambios(int IdVehiculo, string modelo, string marca, string color, int año, int precio, int kilometraje, string transmision)
        {
            Conectar();
            SqlCommand cmd = new SqlCommand("Update inventario set Modelo=@Modelo, Marca=@Marca, Color=@Color, Año=@Año, Precio=@Precio, Kilometraje=@Kilometraje, Transmisión=@Transmisión Where IdVehiculo=@IdVehiculo", Conecta);
            cmd.Parameters.Add("@IdVehiculo", SqlDbType.Int, 4).Value = IdVehiculo;
            cmd.Parameters.Add("@Modelo", SqlDbType.VarChar, 60).Value = modelo;
            cmd.Parameters.Add("@Marca", SqlDbType.VarChar, 60).Value = marca;
            cmd.Parameters.Add("@Color", SqlDbType.VarChar, 60).Value = color; 
            cmd.Parameters.Add("@Año", SqlDbType.Int, 4).Value = año;
            cmd.Parameters.Add("@Precio", SqlDbType.Int, 7).Value = precio;
            cmd.Parameters.Add("@Kilometraje", SqlDbType.Int, 7).Value = kilometraje;
            cmd.Parameters.Add("@Transmisión", SqlDbType.VarChar, 60).Value = transmision;
            cmd.ExecuteNonQuery();
            Desconectar();
        }

        public void altascliente(string nombre, string apellido, string telefono, int edad, string domicilio)
        {
            Conectar();
            SqlCommand cmd = new SqlCommand("Insert Into cliente Values (@Nombre, @Apellido, @Telefono, @Edad, @Domicilio)", Conecta);
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 60).Value = nombre;
            cmd.Parameters.Add("@Apellido", SqlDbType.VarChar, 60).Value = apellido;
            cmd.Parameters.Add("@Telefono", SqlDbType.VarChar, 60).Value = telefono;
            cmd.Parameters.Add("@Edad", SqlDbType.Int, 3).Value = edad;
            cmd.Parameters.Add("@Domicilio", SqlDbType.VarChar, 60).Value = domicilio;
            cmd.ExecuteNonQuery();
            Desconectar();
        }
        public DataTable BuscarCliente(int IdCliente)
        {
            Conectar();
            SqlCommand cmd = new SqlCommand("Select * from Cliente where IdCliente=@IdCliente", Conecta);
            cmd.Parameters.Add("@IdCliente", SqlDbType.Int, 4).Value = IdCliente;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Desconectar();
            return dt;
        }

        public bool BajasCliente(int IdCliente)
        {
            Conectar();
            bool baja = false;
            SqlCommand cmd = new SqlCommand("Delete from Cliente Where IdCliente=@IdCliente", Conecta);
            cmd.Parameters.Add("@IdCliente", SqlDbType.Int, 4).Value = IdCliente;
            try
            {
                cmd.ExecuteNonQuery();
                baja = true;
                return baja;
            }
            catch
            {
                return baja;
            }
            finally
            {
                Desconectar();
            }
        }
            
            public void CambiosCliente(int IdCliente, string nombre, string apellido, string telefono, int edad, string domicilio)
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("Update Cliente set Nombre=@Nombre, Apellido=@Apellido, Telefono=@Telefono, Edad=@Edad, Domicilio=@Domicilio Where IdCliente=@IdCliente", Conecta);
                cmd.Parameters.Add("@IdCliente", SqlDbType.Int, 4).Value = IdCliente;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 60).Value = nombre;
                cmd.Parameters.Add("@Apellido", SqlDbType.VarChar, 60).Value = apellido;
                cmd.Parameters.Add("@Telefono", SqlDbType.VarChar, 60).Value = telefono;
                cmd.Parameters.Add("@Edad", SqlDbType.Int, 4).Value = edad;
                cmd.Parameters.Add("@Domicilio", SqlDbType.VarChar, 60).Value = domicilio;
                cmd.ExecuteNonQuery();
                Desconectar();
            }
        }
    }


