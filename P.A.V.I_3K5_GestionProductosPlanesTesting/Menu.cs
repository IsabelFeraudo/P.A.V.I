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
    }
}
