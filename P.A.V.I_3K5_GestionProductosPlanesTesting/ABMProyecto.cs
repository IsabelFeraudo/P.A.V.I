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
    public partial class ABMProyecto : Form
    {
        public ABMProyecto()
        {
            InitializeComponent();
        }

        private void ABMProyecto_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            Menu menu = new Menu();
            menu.Close();
            // TODO: esta línea de código carga datos en la tabla 'gestionProductosPlanesTestingDataSet8.Proyectos' Puede moverla o quitarla según sea necesario.
            this.proyectosTableAdapter.Fill(this.gestionProductosPlanesTestingDataSet8.Proyectos);
            txtIdProyecto.Text = "";
            txtIdProducto.Text = "";
            txtDescripcion.Text = "";
            txtVersion.Text = "";
            txtAlcance.Text = "";
            List<ProyectoEntidad> lista = ProyectoBLL.SelectDoc();
            foreach (ProyectoEntidad item in lista)
            {
                cmbResponsable.Items.Add(item);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rdAltaProyecto.Checked==true)
            {
                CargarProyecto();
            }

            if(rdModificarProyecto.Checked == true)
            {
                ModificarProyecto();
            }
        }

        private void CargarProyecto()
        {
            ProyectoEntidad proyecto = new ProyectoEntidad();
            proyecto = ProyectoBLL.InsertProyecto(int.Parse(txtIdProyecto.Text), int.Parse(txtIdProducto.Text), txtDescripcion.Text, txtVersion.Text, txtAlcance.Text, int.Parse(cmbResponsable.SelectedValue.ToString()), false);
            if (txtIdProyecto.Text == "")
            {
                MessageBox.Show("Debe ingresar un ID de proyecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtIdProducto.Text == "")
            {
                MessageBox.Show("Debe ingresar un ID de producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Se debe ingresar una descripcion.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtVersion.Text == "")
            {
                MessageBox.Show("Se debe ingresar una version.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtAlcance.Text == "")
            {
                MessageBox.Show("Se debe ingresar un alcance.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!string.IsNullOrEmpty(proyecto.Descripcion.ToString()))
            {
                //this.Close();
                Menu menu = new Menu();
                menu.ShowDialog();
            }
            else
            {
                proyecto.IdProyecto = int.Parse(txtIdProyecto.Text);
                proyecto.IdProducto = int.Parse(txtIdProducto.Text);
                proyecto.Descripcion = txtDescripcion.Text;
                proyecto.Version = txtVersion.Text;
                proyecto.Alcance = txtAlcance.Text;
                proyecto.IdResponsable = cmbResponsable.SelectedIndex;
                proyecto.Borrado = false;

                MessageBox.Show("Proyecto guardado con exito");
                this.Close();
            }
        }
        private void ModificarProyecto()
        {
            ProyectoEntidad proyecto = new ProyectoEntidad();
            proyecto = ProyectoBLL.UpdateProyecto(txtDescripcion.Text, txtVersion.Text, txtAlcance.Text, int.Parse(cmbResponsable.SelectedValue.ToString()));
            proyecto = ProyectoBLL.SelectProyecto(int.Parse(txtIdProyecto.Text));

            //txtIdProyecto.Text;
        }
    }

}
 
