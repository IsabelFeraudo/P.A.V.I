using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P.A.V.I_3K5_GestionProductosPlanesTesting.ENTIDAD;
using P.A.V.I_3K5_GestionProductosPlanesTesting.BLL;

namespace P.A.V.I_3K5_GestionProductosPlanesTesting
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            Menu menu = new Menu();
            menu.Close();
            List<UsuarioEntidad> usuario = UsuarioBLL.SelectAll();
            DgvUsuarios.DataSource = usuario;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ABMusuario abm = new ABMusuario();
            abm.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestionProductosPlanesTestingDataSet9.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.gestionProductosPlanesTestingDataSet9.Usuarios);

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            ABMusuario abm = new ABMusuario();
            abm.ShowDialog();
        }
    }
}
