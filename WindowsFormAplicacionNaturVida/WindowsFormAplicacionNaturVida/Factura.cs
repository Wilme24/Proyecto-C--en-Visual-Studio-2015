using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormAplicacionNaturVida
{
    class Factura
    {
         
#region "Objetos"
        BaseDatos bd = new BaseDatos();
        DataSet data = new DataSet();
        #endregion

        #region "Atributos"
        string numeroFactura;
        string producto;
        string fechaFactura;
        string clienteFactura;
        int valorFactura;
        string vendedor;
        int cantidad;
        #endregion

        #region "Propiedades"
        public string NumeroFactura
        {
            set { numeroFactura = value; }
            get { return numeroFactura; }
        }

        public string Producto
        {
            set { producto = value; }
            get { return producto; }
        }

        public string FechaFactura
        {
            set { fechaFactura = value; }
            get { return fechaFactura; }
        }

        public string Cliente
        {
            set { clienteFactura = value; }
            get { return clienteFactura; }
        }

        public int ValorFactura
        {
            set { valorFactura = value; }
            get { return valorFactura; }
        }

        public string Vendedor
        {
            set { vendedor = value; }
            get { return vendedor; }
        }

        public int Cantidad
        {
            set { cantidad = value; }
            get { return cantidad; }
        }
        #endregion

        #region "Funciones DML"

        public bool insertar(string numero, string producto, string fecha, string cliente, int valor, string vendedor, int cantidad)
        {
            string sql = "insert into Facturas(factNumero,factProducto,factFecha,factCliente,factValorTotal,factVendedor,cantFactura)" +
                "values('" + numero + "','"+producto+"','" + fecha + "','" + cliente + "',"+ valor +",'" + vendedor + "',"+cantidad+")";
            return bd.ejecutarSentenciaDML(sql);
        }

        public int mostrarCantidad(string codigo)
        {
            string sql = "select proCantidad from Productos where proCodigo='"+codigo+"'";
            return bd.obtenerCantidad(sql);
        }

        public int sumarCantidadEntrantes(string codigo)
        {
            string sql = "select SUM(cantFactura) from Facturas where factProducto ='" + codigo + "'";
            return bd.obtenerCantidad(sql);
        }

        #endregion


    }
}
