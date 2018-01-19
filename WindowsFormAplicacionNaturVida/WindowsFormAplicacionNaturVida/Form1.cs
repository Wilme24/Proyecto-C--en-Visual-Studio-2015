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
    public partial class frmLogin : Form
    {
        public string usu;
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUsuario.Text) && !String.IsNullOrEmpty(txtContrasena.Text))
            {
                try
                {
                    Login lg = new Login();
                    Boolean res = lg.iniciarSesion(txtUsuario.Text, txtContrasena.Text);
                    if (res)
                    {
                        usu = txtUsuario.Text;
                        MenuPrincipal mp = new MenuPrincipal(usu);
                        mp.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Datos Incorrectos");
                        txtContrasena.Clear();
                    }
                }
                catch(Exception es)
                {
                    
                    MessageBox.Show(es.Message);
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
          
            

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
