using P.A.V.I_3K5_GestionProductosPlanesTesting.BLL;
using P.A.V.I_3K5_GestionProductosPlanesTesting.ENTIDAD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P.A.V.I_3K5_GestionProductosPlanesTesting
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        // buscar como centralizar al agrandar

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if ((TxtUsuario.Text == ""))
            {
                MessageBox.Show("Se debe ingresar un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if ((TxtPassword.Text == ""))
            {
                MessageBox.Show("Se debe ingresar una contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Usuario user = new Usuario();
            user = UsuarioBLL.ValidarLogin(TxtUsuario.Text, TxtPassword.Text);

            if (!string.IsNullOrEmpty(user.Nombre.ToString()))
            {
                MessageBox.Show("Login OK.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
                Menu menu = new Menu();
                menu.ShowDialog();
                
            }
            else 
            {
                TxtUsuario.Text = "";
                TxtPassword.Text = "";
                TxtPassword.Focus();
                MessageBox.Show("Debe ingresar usuario y/o contraseña válidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
