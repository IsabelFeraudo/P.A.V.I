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
    public partial class Proyecto : Form
    {
        public Proyecto()
        {
            InitializeComponent();
        }

        private void Proyecto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestionProductosPlanesTestingDataSet.Productos' Puede moverla o quitarla según sea necesario.
            //this.productosTableAdapter.Fill(this.gestionProductosPlanesTestingDataSet.Productos);

            this.CenterToParent();
            Menu menu = new Menu();
            menu.Close();
            List<ProyectoEntidad> proyectos = ProyectoBLL.SelectAll();
            DgvProyectos.DataSource = proyectos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ABMProyecto abm = new ABMProyecto();
            abm.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ABMProyecto abm = new ABMProyecto();
            abm.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void Proyecto_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestionProductosPlanesTestingDataSet6.Proyectos' Puede moverla o quitarla según sea necesario.
            this.proyectosTableAdapter.Fill(this.gestionProductosPlanesTestingDataSet6.Proyectos);

        }
    }
}
