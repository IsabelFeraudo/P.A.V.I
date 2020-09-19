using P.A.V.I_3K5_GestionProductosPlanesTesting.BLL;
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
    public partial class ModificarNombre : Form
    {
        public ModificarNombre()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text != null)
                ProductoBLL.UpdateProducto(TxtNombre.Text);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            this.Close();
        }
    }
}
