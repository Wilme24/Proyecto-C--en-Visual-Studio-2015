using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormAplicacionNaturVida
{
    class BaseDatos
    {
        Int32 cantidad;
        string valor;
        public DataSet ejecutarComando(string sql, string nombreTabla)
        {
            string comandoConexion = "Data Source=DESKTOP-BED3LUO; Initial Catalog=BdTienda; Integrated Security=true";
            SqlConnection conexion = new SqlConnection(comandoConexion);
            DataSet datos = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexion);
            adaptador.Fill(datos, nombreTabla);
            return datos;
        }

        public bool ejecutarSentenciaDML(String DML)
        {
            
            string comandoConexion = "Data Source=DESKTOP-BED3LUO; Initial Catalog=BdTienda; Integrated Security=true";
            SqlConnection conexion = new SqlConnection(comandoConexion);
            conexion.Open();
            SqlCommand comando = new SqlCommand(DML, conexion);
            if (comando.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
                return false;
        }

        public int obtenerCantidad(string DML)
        {
            string comandoConexion = "Data Source=DESKTOP-BED3LUO; Initial Catalog=BdTienda; Integrated Security=true";
            SqlConnection conexion = new SqlConnection(comandoConexion);
            conexion.Open();
            SqlCommand comando = new SqlCommand(DML, conexion);
            cantidad = (Int32)(comando.ExecuteScalar());
            return cantidad;
        }


        public static List<Producto> cargarProductos()
        {
            List<Producto> listaProductos = new List<Producto>();
            string comandoConexion = "Data Source=DESKTOP-BED3LUO; Initial Catalog=BdTienda; Integrated Security=true";
            SqlConnection conexion = new SqlConnection(comandoConexion);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select proCodigo, proDescripcion, proValor from Productos",conexion);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Producto producto = new Producto();

                producto.Codigo = lector.GetString(0);
                producto.Descripcion = lector.GetString(1);
                if (!producto.Descripcion.Equals("prueba")){
                    listaProductos.Add(producto);
                }

                
            }

            return listaProductos;
        }

        public static List<TipoID> cargarTipoID()
        {
            List<TipoID> listaTipoID = new List<TipoID>();
            string comandoConexion = "Data Source=DESKTOP-BED3LUO; Initial Catalog=BdTienda; Integrated Security=true";
            SqlConnection conexion = new SqlConnection(comandoConexion);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select codigoID,tipoDocumento from tipoID", conexion);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                TipoID tipoID = new TipoID();

                tipoID.CodigoID = lector.GetString(0);
                tipoID.ID = lector.GetString(1);

                listaTipoID.Add(tipoID);
            }

            return listaTipoID;
        }

        public static List<Cliente> cargarClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            string comandoConexion = "Data Source=DESKTOP-BED3LUO; Initial Catalog=BdTienda; Integrated Security=true";
            SqlConnection conexion = new SqlConnection(comandoConexion);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select cliDocumento, cliNombre from Clientes", conexion);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Cliente unCliente = new Cliente();

                unCliente.Identificacion = lector.GetString(0);
                unCliente.Nombre = lector.GetString(1);

                listaClientes.Add(unCliente);
            }

            return listaClientes;
        }

    }
}
