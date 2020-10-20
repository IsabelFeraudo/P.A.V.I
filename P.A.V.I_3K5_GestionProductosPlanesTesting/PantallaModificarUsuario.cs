using P.A.V.I_3K5_GestionProductosPlanesTesting.BLL;
using P.A.V.I_3K5_GestionProductosPlanesTesting.ENTIDAD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P.A.V.I_3K5_GestionProductosPlanesTesting
{
    public partial class PantallaModificarUsuario : Form
    {
        public PantallaModificarUsuario()
        {
            InitializeComponent();
        }
        
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            // hace un update a usuario y a perfil
            if (MessageBox.Show("Desea modificar este usuario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //buscar el id del usuario en base para pasar en la actualizacion
                UsuarioEntidad usuario = UsuarioBLL.ValidarLogeado();
                UsuarioBLL.UpdateUsuario(usuario.IdUsuario, TxtNombre.Text, TxtPerfil.Text, TxtPassword.Text, TxtEmail.Text);
            }
        }
   
    }
}
