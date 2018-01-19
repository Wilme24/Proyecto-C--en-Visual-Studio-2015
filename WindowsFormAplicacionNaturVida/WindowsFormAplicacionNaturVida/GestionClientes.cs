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
    public partial class frmGestionClientes : Form
    {
        public frmGestionClientes()
        {
            InitializeComponent();
        }

        #region "Objetos"
        Cliente cliente = new Cliente();
        DataSet informe = new DataSet();
        #endregion



        public void cargarComboBox()
        {

            cboCliente.DataSource = BaseDatos.cargarClientes();
            cboCliente.DisplayMember = "nombre";
            cboCliente.ValueMember = "identificacion";

            cboCliente1.DataSource = BaseDatos.cargarClientes();
            cboCliente1.DisplayMember = "nombre";
            cboCliente1.ValueMember = "identificacion";

            cboCliente2.DataSource = BaseDatos.cargarClientes();
            cboCliente2.DisplayMember = "nombre";
            cboCliente2.ValueMember = "identificacion";
        }

        public void cargarConsulta(string codigo)
        {
            informe = cliente.consultar(codigo);
            dgbConsultaCliente.DataSource = informe;
            dgbConsultaCliente.DataMember = "Clientes";
        }

        public void cargarBusqueda(String id)
        {
            informe = cliente.mostrarConsulta(id);
            dgbConsultaCliente.DataSource = informe;
            dgbConsultaCliente.DataMember = "Clientes";
        }

        public void cargarDatos()
        {
            informe = cliente.mostrarDatos();
            dgbConsultaCliente.DataSource = informe;
            dgbConsultaCliente.DataMember = "Clientes";
        }

        private void frmGestionClientes_Load(object sender, EventArgs e)
        {
            cboTipoID.DataSource = BaseDatos.cargarTipoID();
            cboTipoID.DisplayMember = "id";
            cboTipoID.ValueMember = "codigoID";
            cargarComboBox();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cliente.Identificacion = txtIdentificacion.Text;
            cliente.Nombre = txtNombre.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Correo = txtCorreo.Text;

            try
            {
                if (txtIdentificacion.Text == "" || txtNombre.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtCorreo.Text == "")
                    MessageBox.Show(this.MdiParent, "Debe digitar todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (cliente.insertar(cliente.Identificacion, cliente.Nombre, cliente.Direccion, cliente.Telefono, cliente.Correo))
                {
                    MessageBox.Show(MdiParent, "Cliente registrado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarComboBox();

                }
            }
            catch
            {
                
                MessageBox.Show(MdiParent, "Cliente no registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void limpiar()
        {
            txtIdentificacion.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string seleccion = cboCliente.SelectedValue.ToString();
                cargarBusqueda(seleccion);
            }
            catch
            {
                MessageBox.Show(this.MdiParent, "Error al momento de buscar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar1_Click(object sender, EventArgs e)
        {
            try
            {
                string seleccion = cboCliente1.SelectedValue.ToString();
                informe = cliente.consultar(seleccion);
                txtIdentificacion1.Text = informe.Tables["Clientes"].Rows[0]["cliDocumento"].ToString();
                txtNombre1.Text = informe.Tables["Clientes"].Rows[0]["cliNombre"].ToString();
                txtDireccion1.Text = informe.Tables["Clientes"].Rows[0]["cliDireccion"].ToString();
                txtTelefono1.Text = informe.Tables["Clientes"].Rows[0]["cliTelefono"].ToString();
                txtCorreo1.Text = informe.Tables["Clientes"].Rows[0]["cliCorreo"].ToString();

            }
            catch
            {
                
                MessageBox.Show(MdiParent, "Error al momento de buscar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar1_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.Identificacion = txtIdentificacion1.Text;
                cliente.Nombre = txtNombre1.Text;
                cliente.Direccion = txtDireccion1.Text;
                cliente.Telefono = txtTelefono1.Text;
                cliente.Correo = txtCorreo1.Text;

                if (cliente.Identificacion == "" || cliente.Nombre == "" || cliente.Direccion == "" || cliente.Telefono == "" || cliente.Correo == "")
                {
                    MessageBox.Show(this.MdiParent, "Debe llenar todos los espacios", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cliente.modificar(cliente.Identificacion, cliente.Nombre, cliente.Direccion,cliente.Telefono, cliente.Correo))
                {
                    MessageBox.Show(this.MdiParent, "Datos del Cliente Modificados Exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDatos();
                    cargarComboBox();
                }

            }
            catch
            {
                
               MessageBox.Show(this.MdiParent, "Datos no modificados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string seleccion = cboCliente2.SelectedValue.ToString();
                cliente.eliminar(seleccion);
                cargarComboBox();

                MessageBox.Show(this.MdiParent, "Cliente eliminado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(this.MdiParent,"Cliente no eliminado","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }
    }
}
