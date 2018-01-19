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

namespace WindowsFormAplicacionNaturVida
{
    public partial class frmGestionProductos : Form
    {
        int cantidadProducto;
        public frmGestionProductos()
        {
            InitializeComponent();
        }

        #region "Objetos"
        Producto producto = new Producto();
        DataSet informe = new DataSet();
        #endregion

        private void cargarComboBox()
        {
            cboProducto.DataSource = BaseDatos.cargarProductos();
            cboProducto.DisplayMember = "descripcion";
            cboProducto.ValueMember = "codigo";

            cbxProducto1.DataSource = BaseDatos.cargarProductos();
            cbxProducto1.DisplayMember = "descripcion";
            cbxProducto1.ValueMember = "codigo";

            cbxProducto2.DataSource = BaseDatos.cargarProductos();
            cbxProducto2.DisplayMember = "descripcion";
            cbxProducto2.ValueMember = "codigo";

        }

        private void frmGestionProductos_Load(object sender, EventArgs e)
        {
            cargarComboBox();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void dgbConsultaProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cargarConsulta(string codigo)
        {
            try
            {
                informe = producto.consultar(codigo);
                dgbConsultaProducto.DataSource = informe;
                dgbConsultaProducto.DataMember = "Productos";

            }
            catch
            {
                MessageBox.Show(this.MdiParent,"Error al guardar el Producto","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }

        private void cargarDatos()
        {
            try
            {
                informe = producto.mostrarDatos();
                dgbConsultaProducto.DataSource = informe;
                dgbConsultaProducto.DataMember = "Productos";
            }
            catch
            {
                MessageBox.Show(this.MdiParent, "Error al guardar el Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            producto.Codigo = txtCodigo.Text;
            producto.Descripcion = txtDescripcion.Text;
            producto.Valor = int.Parse(txtValor.Text);
            producto.Cantidad = int.Parse(txtCantidad.Text);
            

            try
            {
                if (txtCodigo.Text == "" || txtDescripcion.Text == "" || txtValor.Text == "" || txtCantidad.Text == "")
                    MessageBox.Show(MdiParent,"Debe digitar todos los datos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                else if (producto.insertar(producto.Codigo, producto.Descripcion, producto.Valor, producto.Cantidad))
                {
                    MessageBox.Show(MdiParent, "Produto Ingresado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            catch
            {
                MessageBox.Show(MdiParent, "Producto No ingresado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void limpiarDatos()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtValor.Text = "";
            txtCantidad.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();

        }

        private void cbxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string seleccion = cboProducto.SelectedValue.ToString();
                cargarConsulta(seleccion);
              

            }
            catch
            {
                MessageBox.Show(MdiParent,"Error al momento de buscar el producto","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cbxProducto1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConsultar1_Click(object sender, EventArgs e)
        {
            try
            {
                string seleccion = cbxProducto1.SelectedValue.ToString();
                informe = producto.consultar(seleccion);
                txtCodigo1.Text = informe.Tables["Productos"].Rows[0]["proCodigo"].ToString();
                txtDescripcion1.Text = informe.Tables["Productos"].Rows[0]["proDescripcion"].ToString();
                txtValor1.Text = informe.Tables["Productos"].Rows[0]["proValor"].ToString();
                txtCantidad1.Text = informe.Tables["Productos"].Rows[0]["proCantidad"].ToString();

            }
            catch
            {
                
                MessageBox.Show(MdiParent,"Error al momento de buscar el producto","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); 
            }
            

        }


        private void btnGuardar1_Click(object sender, EventArgs e)
        {
           
            try
            {
                producto.Codigo = txtCodigo1.Text;
                producto.Descripcion = txtDescripcion1.Text;
                producto.Valor = Convert.ToInt32(txtValor1.Text);
                producto.Cantidad = Convert.ToInt32(txtCantidad1.Text);
                

                if(producto.Codigo=="" || producto.Descripcion=="" || txtValor1.Text=="")
                {
                    MessageBox.Show(this.MdiParent, "Debe llenar todos los espacios", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (producto.modificar(producto.Codigo, producto.Descripcion, producto.Valor, producto.Cantidad))
                {
                    MessageBox.Show(this.MdiParent,"Producto Modificado Correctamente","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    cargarDatos();
                }

            }
            catch
            {
                MessageBox.Show(this.MdiParent,"Datos no modificados","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void cbxProducto2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string seleccion = cbxProducto2.SelectedValue.ToString();
                producto.eliminar(seleccion);
                cargarComboBox();

                MessageBox.Show(this.MdiParent, "Producto Eliminado Exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                
                MessageBox.Show(this.MdiParent, "Producto No Eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
