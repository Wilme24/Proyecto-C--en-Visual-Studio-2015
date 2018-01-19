using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;


namespace WindowsFormAplicacionNaturVida
{
    public partial class frmGestionFactura : Form
    {
        string usuVendedor;

        public frmGestionFactura(string vend)
        {
            InitializeComponent();
            usuVendedor = vend;
        }

        #region "Objetos"
        Producto producto = new Producto();
        Factura factura = new Factura();
        Inventario inventario = new Inventario();
        DataSet informe = new DataSet();
        #endregion

        private void cargarComboBox()
        {
            cboCliente.DataSource = BaseDatos.cargarClientes();
            cboCliente.DisplayMember = "nombre";
            cboCliente.ValueMember = "identificacion";

            cboProducto.DataSource = BaseDatos.cargarProductos();
            cboProducto.DisplayMember = "descripcion";
            cboProducto.ValueMember = "codigo";
            
        }

        public void cargarProductosDataGrid()
        {
            try
            {
                informe = producto.mostrarDatos();
                gridProductos.DataSource = informe;
                gridProductos.DataMember= "Productos";

            }
            catch
            {
                MessageBox.Show(this.MdiParent, "Error al cargar el producto en la factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmGestionFactura_Load(object sender, EventArgs e)
        {
            cargarComboBox();
        }

        private void gridProductos_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void gridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                string seleccion = cboProducto.SelectedValue.ToString();
                producto.Descripcion = seleccion;
                string cant = txtCantidad.Text;
                producto.Cantidad = Int32.Parse(cant);
                int numero = producto.Cantidad;
                informe = producto.mostrarValorProducto(seleccion);
                int cantidadEntradas = factura.mostrarCantidad(producto.Descripcion);
                int cantSalidas = factura.sumarCantidadEntrantes(seleccion);
                if (cantidadEntradas <= cantSalidas)
                {
                    MessageBox.Show(this.MdiParent, "La cantidad vendida es mayor que la cantidad existente del producto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
  
                        int num = gridProductos.Rows.Add();
                        gridProductos.Rows[num].Cells[0].Value = producto.Descripcion;
                        gridProductos.Rows[num].Cells[1].Value = cboProducto.Text;
                        gridProductos.Rows[num].Cells[2].Value = numero;
                        gridProductos.Rows[num].Cells[3].Value = informe.Tables[0].Rows[0][0];

                }


                
                

            }
            catch
            {
                
                MessageBox.Show(this.MdiParent, "Error al agregar el producto a la factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            try
            {
            
            int totalCantidad = 0;
            int totalValor = 0;

            foreach (DataGridViewRow dataGrid in gridProductos.Rows)
            {
                totalCantidad += Convert.ToInt16(dataGrid.Cells["Column3"].Value);
                totalValor += Convert.ToInt16(dataGrid.Cells["Column4"].Value);
            }
            
            string valorTotal = Convert.ToString(totalCantidad * totalValor);

            txtTotalFactura.Text = valorTotal;

            factura.NumeroFactura = txtNumero.Text;
            factura.FechaFactura = dateTimePicker1.Value.Date.ToString("dd/MM/yyyy");
            factura.Cliente = cboCliente.SelectedValue.ToString();
            factura.ValorFactura = Convert.ToInt32(valorTotal);
            factura.Cantidad = Convert.ToInt32(txtCantidad.Text);
            factura.Vendedor = usuVendedor;

                foreach (DataGridViewRow dataGrid in gridProductos.Rows)
                {
                     
                    factura.Producto = Convert.ToString(dataGrid.Cells["Column1"].Value);
                    Console.WriteLine(factura.Producto.ToString());
                    if (factura.NumeroFactura == "" || factura.Producto == "" || factura.FechaFactura == "" || factura.Cliente == "" || valorTotal=="" || factura.Vendedor == "")
                    {
                        MessageBox.Show(this.MdiParent, "Debe digitar todos los campos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (factura.insertar(factura.NumeroFactura, factura.Producto, factura.FechaFactura, factura.Cliente, factura.ValorFactura, factura.Vendedor,factura.Cantidad))
                    {
                       
                    }
                }

                MessageBox.Show(this.MdiParent, "Factura generada exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                
                MessageBox.Show(this.MdiParent, "Factura No Ha sido Generada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textTotalFactura_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            txtCantidad.Text = "";
            gridProductos.Rows.Clear();
        }
    }
}
