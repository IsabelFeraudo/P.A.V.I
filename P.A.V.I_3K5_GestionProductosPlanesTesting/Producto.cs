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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestionProductosPlanesTestingDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.gestionProductosPlanesTestingDataSet.Productos);

            this.CenterToParent();
            Menu menu = new Menu();
            menu.Close();
            List<ProductoEntidad> productos = ProductoBLL.SelectAll();
            dataGridView1.DataSource = productos;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtProductoNombre.Text != "")
            {
                ProductoEntidad produto = ProductoBLL.ValidarProducto(TxtProductoNombre.Text);
                if (produto != null)
                {
                    if (MessageBox.Show("El producto: " + TxtProductoNombre.Text + "existe <br> desea modificar el producto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ModificarNombre nombre = new ModificarNombre();
                        nombre.ShowDialog();
                        return;
                    }
                    
                    if (MessageBox.Show("El producto: " + TxtProductoNombre.Text + "existe <br> desea borrar el producto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ProductoBLL.DeleteProducto(TxtProductoNombre.Text);
                        return;
                    }

                }
                else 
                {
                    if (MessageBox.Show("El producto: " + TxtProductoNombre.Text + " no existe <br> desea agregarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ProductoBLL.InsertProducto(TxtProductoNombre.Text);
                    }
                }
            }
            else 
            {
                MessageBox.Show("Se debe ingresar un nombre.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productosTableAdapter.FillBy(this.gestionProductosPlanesTestingDataSet.Productos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
