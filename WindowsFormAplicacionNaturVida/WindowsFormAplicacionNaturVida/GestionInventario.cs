using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormAplicacionNaturVida
{
    public partial class frmGestionInventario : Form
    {
        public frmGestionInventario()
        {
            InitializeComponent();
        }

        #region "Objetos"
        Producto producto = new Producto();
        Factura factura = new Factura();
        Inventario inventario = new Inventario();
        #endregion

        #region "Variables"
        int entradas;
        #endregion


        public void cargarComboBox()
        {
            cboProducto.DataSource = BaseDatos.cargarProductos();
            cboProducto.DisplayMember = "descripcion";
            cboProducto.ValueMember = "codigo";
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            cargarComboBox();
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void limpiar()
        {
            
        }

        

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            gridInventario.Rows.Clear();
            producto.Codigo = cboProducto.SelectedValue.ToString();
            producto.Descripcion = cboProducto.Text;
            entradas = factura.mostrarCantidad(producto.Codigo);
            Console.WriteLine(entradas);
            int cantidadSaliente = factura.sumarCantidadEntrantes(producto.Codigo);
            int cantidadDisponible = entradas - cantidadSaliente;

            int numero = gridInventario.Rows.Add();

            gridInventario.Rows[numero].Cells[0].Value = producto.Codigo;
            gridInventario.Rows[numero].Cells[1].Value = producto.Descripcion;
            gridInventario.Rows[numero].Cells[2].Value = entradas;
            gridInventario.Rows[numero].Cells[3].Value = cantidadSaliente;
            gridInventario.Rows[numero].Cells[4].Value = cantidadDisponible;

        }
    }
}
