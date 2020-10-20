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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            Producto prducto = new Producto();
            prducto.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            Login login = new Login();
            login.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnCasoPrueba_Click(object sender, EventArgs e)
        {
            CasosDePrueba caso = new CasosDePrueba();
            caso.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.ShowDialog();
        }

        private void btnCicloPrueba_Click(object sender, EventArgs e)
        {
            CicloDePrueba ciclo = new CicloDePrueba();
            ciclo.ShowDialog();
        }

        private void btnPruebaDetalle_Click(object sender, EventArgs e)
        {
            PruebaDetalles prueba = new PruebaDetalles();
            prueba.ShowDialog();
        }

        private void btnPlanPrueba_Click(object sender, EventArgs e)
        {
            PlanPrueba plan = new PlanPrueba();
            plan.ShowDialog();
        }

        private void btnProyecto_Click(object sender, EventArgs e)
        {
            Proyecto proyecto = new Proyecto();
            proyecto.ShowDialog();
        }
    }
}
