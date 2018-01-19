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
    public partial class MenuPrincipal : Form
    {
        string vend;
        public MenuPrincipal(string usu)
        {
            InitializeComponent();
            vend = usu;
        }

        private bool mostrarVentana(string nombreFormulario)
        {
            foreach (Form unFormulario in this.MdiChildren)
            {
                if (unFormulario.Name == nombreFormulario)
                {
                    unFormulario.Focus();
                    unFormulario.Show();
                    return true;
                }
            }

            return false;
        }

        private void sallirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();

        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mostrarVentana("frmGestionProductos") == true) return;
                frmGestionProductos frmGestionProductos = new frmGestionProductos();
                frmGestionProductos.Name = "frmGestionProductos";
                frmGestionProductos.MdiParent = this;
                frmGestionProductos.Show();

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mostrarVentana("frmGestionClientes") == true) return;
            frmGestionClientes frmGestionClientes = new frmGestionClientes();
            frmGestionClientes.Name = "frmGestionClientes";
            frmGestionClientes.MdiParent = this;
            frmGestionClientes.Show();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mostrarVentana("frmGestionFactura") == true) return;
            frmGestionFactura frmGestionFactura = new frmGestionFactura(vend);
            frmGestionFactura.Name = "frmGestionFactura";
            frmGestionFactura.MdiParent = this;
            frmGestionFactura.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mostrarVentana("frmGestionInventario") == true) return;
            frmGestionInventario frmGestionInventario = new frmGestionInventario();
            frmGestionInventario.Name = "frmGestionInventario";
            frmGestionInventario.MdiParent = this;
            frmGestionInventario.Show();
        }
    }
}
