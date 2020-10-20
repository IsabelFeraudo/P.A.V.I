namespace P.A.V.I_3K5_GestionProductosPlanesTesting
{
    partial class ABMProyecto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbResponsable = new System.Windows.Forms.ComboBox();
            this.gestionProductosPlanesTestingDataSet8 = new P.A.V.I_3K5_GestionProductosPlanesTesting.GestionProductosPlanesTestingDataSet8();
            this.proyectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionProductosPlanesTestingDataSet5 = new P.A.V.I_3K5_GestionProductosPlanesTesting.GestionProductosPlanesTestingDataSet5();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionProductosPlanesTestingDataSet4 = new P.A.V.I_3K5_GestionProductosPlanesTesting.GestionProductosPlanesTestingDataSet4();
            this.gestionProductosPlanesTestingDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionProductosPlanesTestingDataSet = new P.A.V.I_3K5_GestionProductosPlanesTesting.GestionProductosPlanesTestingDataSet();
            this.gestionProductosPlanesTestingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new P.A.V.I_3K5_GestionProductosPlanesTesting.GestionProductosPlanesTestingDataSet5TableAdapters.UsuariosTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtAlcance = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.proyectosTableAdapter = new P.A.V.I_3K5_GestionProductosPlanesTesting.GestionProductosPlanesTestingDataSet8TableAdapters.ProyectosTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdProyecto = new System.Windows.Forms.TextBox();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.rdAltaProyecto = new System.Windows.Forms.RadioButton();
            this.rdModificarProyecto = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gestionProductosPlanesTestingDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionProductosPlanesTestingDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionProductosPlanesTestingDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionProductosPlanesTestingDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionProductosPlanesTestingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionProductosPlanesTestingDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carga de datos - Proyectos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(122, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(122, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Version:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(122, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alcance:";
            // 
            // cmbResponsable
            // 
            this.cmbResponsable.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gestionProductosPlanesTestingDataSet8, "Proyectos.id_responsable", true));
            this.cmbResponsable.DataSource = this.proyectosBindingSource;
            this.cmbResponsable.DisplayMember = "id_responsable";
            this.cmbResponsable.FormattingEnabled = true;
            this.cmbResponsable.Location = new System.Drawing.Point(227, 331);
            this.cmbResponsable.Name = "cmbResponsable";
            this.cmbResponsable.Size = new System.Drawing.Size(271, 21);
            this.cmbResponsable.TabIndex = 4;
            this.cmbResponsable.ValueMember = "id_responsable";
            // 
            // gestionProductosPlanesTestingDataSet8
            // 
            this.gestionProductosPlanesTestingDataSet8.DataSetName = "GestionProductosPlanesTestingDataSet8";
            this.gestionProductosPlanesTestingDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proyectosBindingSource
            // 
            this.proyectosBindingSource.DataMember = "Proyectos";
            this.proyectosBindingSource.DataSource = this.gestionProductosPlanesTestingDataSet8;
            // 
            // gestionProductosPlanesTestingDataSet5
            // 
            this.gestionProductosPlanesTestingDataSet5.DataSetName = "GestionProductosPlanesTestingDataSet5";
            this.gestionProductosPlanesTestingDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.gestionProductosPlanesTestingDataSet5;
            // 
            // gestionProductosPlanesTestingDataSet4
            // 
            this.gestionProductosPlanesTestingDataSet4.DataSetName = "GestionProductosPlanesTestingDataSet4";
            this.gestionProductosPlanesTestingDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestionProductosPlanesTestingDataSet4BindingSource
            // 
            this.gestionProductosPlanesTestingDataSet4BindingSource.DataSource = this.gestionProductosPlanesTestingDataSet4;
            this.gestionProductosPlanesTestingDataSet4BindingSource.Position = 0;
            // 
            // gestionProductosPlanesTestingDataSet
            // 
            this.gestionProductosPlanesTestingDataSet.DataSetName = "GestionProductosPlanesTestingDataSet";
            this.gestionProductosPlanesTestingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestionProductosPlanesTestingDataSetBindingSource
            // 
            this.gestionProductosPlanesTestingDataSetBindingSource.DataSource = this.gestionProductosPlanesTestingDataSet;
            this.gestionProductosPlanesTestingDataSetBindingSource.Position = 0;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(122, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Responsable:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(227, 189);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(271, 20);
            this.txtDescripcion.TabIndex = 6;
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(227, 236);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(271, 20);
            this.txtVersion.TabIndex = 7;
            // 
            // txtAlcance
            // 
            this.txtAlcance.Location = new System.Drawing.Point(227, 288);
            this.txtAlcance.Name = "txtAlcance";
            this.txtAlcance.Size = new System.Drawing.Size(271, 20);
            this.txtAlcance.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(256, 379);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 39);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(383, 379);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 39);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // proyectosTableAdapter
            // 
            this.proyectosTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(122, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID Proyecto:";
            // 
            // txtIdProyecto
            // 
            this.txtIdProyecto.Location = new System.Drawing.Point(227, 90);
            this.txtIdProyecto.Name = "txtIdProyecto";
            this.txtIdProyecto.Size = new System.Drawing.Size(271, 20);
            this.txtIdProyecto.TabIndex = 12;
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblIdProducto.Location = new System.Drawing.Point(122, 139);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(91, 18);
            this.lblIdProducto.TabIndex = 13;
            this.lblIdProducto.Text = "ID Producto:";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(227, 140);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(271, 20);
            this.txtIdProducto.TabIndex = 14;
            // 
            // rdAltaProyecto
            // 
            this.rdAltaProyecto.AutoSize = true;
            this.rdAltaProyecto.Location = new System.Drawing.Point(279, 51);
            this.rdAltaProyecto.Name = "rdAltaProyecto";
            this.rdAltaProyecto.Size = new System.Drawing.Size(43, 17);
            this.rdAltaProyecto.TabIndex = 15;
            this.rdAltaProyecto.TabStop = true;
            this.rdAltaProyecto.Text = "Alta";
            this.rdAltaProyecto.UseVisualStyleBackColor = true;
            // 
            // rdModificarProyecto
            // 
            this.rdModificarProyecto.AutoSize = true;
            this.rdModificarProyecto.Location = new System.Drawing.Point(384, 51);
            this.rdModificarProyecto.Name = "rdModificarProyecto";
            this.rdModificarProyecto.Size = new System.Drawing.Size(85, 17);
            this.rdModificarProyecto.TabIndex = 16;
            this.rdModificarProyecto.TabStop = true;
            this.rdModificarProyecto.Text = "Modificacion";
            this.rdModificarProyecto.UseVisualStyleBackColor = true;
            // 
            // ABMProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.Controls.Add(this.rdModificarProyecto);
            this.Controls.Add(this.rdAltaProyecto);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.lblIdProducto);
            this.Controls.Add(this.txtIdProyecto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtAlcance);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbResponsable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ABMProyecto";
            this.Text = "ABMProyecto";
            this.Load += new System.EventHandler(this.ABMProyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestionProductosPlanesTestingDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionProductosPlanesTestingDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionProductosPlanesTestingDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionProductosPlanesTestingDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionProductosPlanesTestingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionProductosPlanesTestingDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbResponsable;
        private System.Windows.Forms.BindingSource gestionProductosPlanesTestingDataSetBindingSource;
        private GestionProductosPlanesTestingDataSet gestionProductosPlanesTestingDataSet;
        private GestionProductosPlanesTestingDataSet4 gestionProductosPlanesTestingDataSet4;
        private System.Windows.Forms.BindingSource gestionProductosPlanesTestingDataSet4BindingSource;
        private GestionProductosPlanesTestingDataSet5 gestionProductosPlanesTestingDataSet5;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private GestionProductosPlanesTestingDataSet5TableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.TextBox txtAlcance;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private GestionProductosPlanesTestingDataSet8 gestionProductosPlanesTestingDataSet8;
        private System.Windows.Forms.BindingSource proyectosBindingSource;
        private GestionProductosPlanesTestingDataSet8TableAdapters.ProyectosTableAdapter proyectosTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdProyecto;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.RadioButton rdAltaProyecto;
        private System.Windows.Forms.RadioButton rdModificarProyecto;
    }
}