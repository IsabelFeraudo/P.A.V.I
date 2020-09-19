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
            //this.productosTableAdapter.Fill(this.gestionProductosPlanesTestingDataSet.Productos);

            this.CenterToParent();
            Menu menu = new Menu();
            menu.Close();
            List<ProductoEntidad> productos = ProductoBLL.SelectAll();
            DgvProductos.DataSource = productos;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtProductoNombre.Text != "")
            {
                List<ProductoEntidad> producto = ProductoBLL.ValidarProducto(TxtProductoNombre.Text);
                if (producto != null)
                {
                    DgvProductos.DataSource = producto;

                    //if (MessageBox.Show("El producto: " + TxtProductoNombre.Text + " existe. \n desea modificar el producto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    //{
                    //    ModificarNombre nombre = new ModificarNombre();
                    //    nombre.ShowDialog();
                    //    return;
                    //}

                    //if (MessageBox.Show("El producto: " + TxtProductoNombre.Text + " existe. \n desea borrar el producto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    //{
                    //    ProductoBLL.DeleteProducto(TxtProductoNombre.Text);
                    //    return;
                    //}

                }
                else 
                {
                    if (MessageBox.Show("El producto: " + TxtProductoNombre.Text + " no existe. \n desea agregarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.DgvProductos.SelectedRows.Count > 0)
            {
               int id_producto = int.Parse(this.DgvProductos.SelectedRows[0].Cells[1].Value.ToString());
                
                if (ProductoBLL.DeleteProducto(id_producto) == "ok")
                {
                    MessageBox.Show("Se elimino con exito el Producto.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<ProductoEntidad> productos = ProductoBLL.SelectAll();
                    DgvProductos.DataSource = productos;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un Producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}
