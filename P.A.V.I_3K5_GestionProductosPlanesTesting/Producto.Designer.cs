namespace P.A.V.I_3K5_GestionProductosPlanesTesting
{
    partial class Producto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label = new System.Windows.Forms.Label();
            this.TxtProductoNombre = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.idproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gestionProductosPlanesTestingDataSet1 = new P.A.V.I_3K5_GestionProductosPlanesTesting.GestionProductosPlanesTestingDataSet1();
            this.productosTableAdapter1 = new P.A.V.I_3K5_GestionProductosPlanesTesting.GestionProductosPlanesTestingDataSet1TableAdapters.ProductosTableAdapter();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionProductosPlanesTestingDataSet = new P.A.V.I_3K5_GestionProductosPlanesTesting.GestionProductosPlanesTestingDataSet();
            this.productosTableAdapter = new P.A.V.I_3K5_GestionProductosPlanesTesting.GestionProductosPlanesTestingDataSetTableAdapters.ProductosTableAdapter();
            this.productoEntidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionProductosPlanesTestingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionProductosPlanesTestingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoEntidadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(34, 34);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(50, 13);
            this.Label.TabIndex = 0;
            this.Label.Text = "Nombre: ";
            // 
            // TxtProductoNombre
            // 
            this.TxtProductoNombre.Location = new System.Drawing.Point(90, 31);
            this.TxtProductoNombre.Name = "TxtProductoNombre";
            this.TxtProductoNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtProductoNombre.TabIndex = 1;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(196, 31);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(277, 31);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // DgvProductos
            // 
            this.DgvProductos.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.idproducto});
            this.DgvProductos.DataSource = this.productosBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvProductos.Location = new System.Drawing.Point(37, 57);
            this.DgvProductos.Name = "DgvProductos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvProductos.Size = new System.Drawing.Size(315, 148);
            this.DgvProductos.TabIndex = 6;
            this.DgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idproducto
            // 
            this.idproducto.DataPropertyName = "idproducto";
            this.idproducto.HeaderText = "id producto";
            this.idproducto.Name = "idproducto";
            this.idproducto.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // productosBindingSource1
            // 
            this.productosBindingSource1.DataMember = "Productos";
            this.productosBindingSource1.DataSource = this.gestionProductosPlanesTestingDataSet1;
            // 
            // gestionProductosPlanesTestingDataSet1
            // 
            this.gestionProductosPlanesTestingDataSet1.DataSetName = "GestionProductosPlanesTestingDataSet1";
            this.gestionProductosPlanesTestingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosTableAdapter1
            // 
            this.productosTableAdapter1.ClearBeforeFill = true;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.gestionProductosPlanesTestingDataSet;
            // 
            // gestionProductosPlanesTestingDataSet
            // 
            this.gestionProductosPlanesTestingDataSet.DataSetName = "GestionProductosPlanesTestingDataSet";
            this.gestionProductosPlanesTestingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // productoEntidadBindingSource
            // 
            this.productoEntidadBindingSource.DataSource = typeof(P.A.V.I_3K5_GestionProductosPlanesTesting.ENTIDAD.ProductoEntidad);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(196, 224);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 270);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.DgvProductos);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtProductoNombre);
            this.Controls.Add(this.Label);
            this.Name = "Producto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionProductosPlanesTestingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionProductosPlanesTestingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoEntidadBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox TxtProductoNombre;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnAgregar;
        private GestionProductosPlanesTestingDataSet gestionProductosPlanesTestingDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private GestionProductosPlanesTestingDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.DataGridView DgvProductos;
        private GestionProductosPlanesTestingDataSet1 gestionProductosPlanesTestingDataSet1;
        private System.Windows.Forms.BindingSource productosBindingSource1;
        private GestionProductosPlanesTestingDataSet1TableAdapters.ProductosTableAdapter productosTableAdapter1;
        private System.Windows.Forms.BindingSource productoEntidadBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEliminar;
    }
}