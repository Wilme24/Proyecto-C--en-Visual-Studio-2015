using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormAplicacionNaturVida
{
    class Producto
    {
        #region "Objetos"
        BaseDatos bd = new BaseDatos();
        DataSet res = new DataSet();
        #endregion

        #region "Atributos"
        string codigo;
        string descripcion;
        int valor;
        int cantidad;
        #endregion

        #region "Propiedades"
        public string Codigo
        {
            set{ codigo = value; }
            get{ return codigo; }
        }

        public string Descripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }

        public int Valor
        {
            set { valor = value; }
            get { return valor; }
        }

        public int Cantidad
        {
            set { cantidad = value; }
            get { return cantidad; }
        }
        #endregion

        #region "Funciones DML"

        public bool insertar(string codigo, string descripcion, int valor, int cantidad)
        {
            string sentenciaSQL = "INSERT INTO Productos(proCodigo, proDescripcion, proValor, proCantidad)"+
                "values('"+codigo+ "','"+descripcion+ "','"+valor+ "','"+cantidad+"')";
            return bd.ejecutarSentenciaDML(sentenciaSQL);
        }

        public bool eliminar(string codigo)
        {
            string sentenciaSQL = "DELETE FROM Productos where proCodigo='"+codigo+"'";
            return bd.ejecutarSentenciaDML(sentenciaSQL);
        }

        public bool modificar(string codigo, string descripcion, int valor, int cantidad)
        {
            string sentenciaSQL = "UPDATE Productos " +
                "set proCodigo='" + codigo + "'," +
                "proDescripcion='" + descripcion + "'," +
                "proValor=" + valor + "," +
                "proCantidad=" + cantidad + " " +
                "WHERE proCodigo='" + codigo + "'"; 
            return bd.ejecutarSentenciaDML(sentenciaSQL);
        }

        public bool modificarCantidad(string codigo,int cantidad)
        {
            string sql = "UPDATE Productos " +
                "set proCantidad=" + cantidad + " " +
                "where proCodigo='"+codigo+"'";
            return bd.ejecutarSentenciaDML(sql);
        }

        public DataSet consultar(string codigo)
        {
            string sentenciaSQL = "select * from Productos where proCodigo='"+codigo+"'";
            return bd.ejecutarComando(sentenciaSQL,"Productos");
        }

        public DataSet mostrarValorProducto(string codigo)
        {
            string sql = "select proValor from Productos where proCodigo='" + codigo + "'";
            return bd.ejecutarComando(sql, "Productos");
        }

        public DataSet mostrarDatos()
        {
            string sentenciaSQL = "select proCodigo as Codigo, proDescripcion as Descripcion, proCantidad as Cantidad,"+
                "proValor as Valor from Productos";
            return bd.ejecutarComando(sentenciaSQL, "Productos");
        }


        public DataSet mostrarReportes()
        {
            string sentenciaSQL = "select * from Productos";
            return bd.ejecutarComando(sentenciaSQL, "Productos");
        }

        public DataSet cargarCodigosProducto()
        {
            string sentenciaSQL = "select proCodigo from Productos";
            return bd.ejecutarComando(sentenciaSQL, "Productos");
        }
        #endregion

    }
}
