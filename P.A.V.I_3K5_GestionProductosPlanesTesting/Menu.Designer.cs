namespace P.A.V.I_3K5_GestionProductosPlanesTesting
{
    partial class Menu
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
            this.BtnProducto = new System.Windows.Forms.Button();
            this.btnPlanPrueba = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPruebaDetalle = new System.Windows.Forms.Button();
            this.btnCicloPrueba = new System.Windows.Forms.Button();
            this.btnProyecto = new System.Windows.Forms.Button();
            this.btnCasoPrueba = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnProducto
            // 
            this.BtnProducto.Location = new System.Drawing.Point(65, 95);
            this.BtnProducto.Name = "BtnProducto";
            this.BtnProducto.Size = new System.Drawing.Size(147, 46);
            this.BtnProducto.TabIndex = 1;
            this.BtnProducto.Text = "Producto";
            this.BtnProducto.UseVisualStyleBackColor = true;
            this.BtnProducto.Click += new System.EventHandler(this.BtnProducto_Click);
            // 
            // btnPlanPrueba
            // 
            this.btnPlanPrueba.Location = new System.Drawing.Point(629, 95);
            this.btnPlanPrueba.Name = "btnPlanPrueba";
            this.btnPlanPrueba.Size = new System.Drawing.Size(147, 46);
            this.btnPlanPrueba.TabIndex = 4;
            this.btnPlanPrueba.Text = "Plan De Prueba";
            this.btnPlanPrueba.UseVisualStyleBackColor = true;
            this.btnPlanPrueba.Click += new System.EventHandler(this.btnPlanPrueba_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Menu";
            // 
            // btnPruebaDetalle
            // 
            this.btnPruebaDetalle.Location = new System.Drawing.Point(341, 181);
            this.btnPruebaDetalle.Name = "btnPruebaDetalle";
            this.btnPruebaDetalle.Size = new System.Drawing.Size(139, 40);
            this.btnPruebaDetalle.TabIndex = 7;
            this.btnPruebaDetalle.Text = "Prueba Detalle";
            this.btnPruebaDetalle.UseVisualStyleBackColor = true;
            this.btnPruebaDetalle.Click += new System.EventHandler(this.btnPruebaDetalle_Click);
            // 
            // btnCicloPrueba
            // 
            this.btnCicloPrueba.Location = new System.Drawing.Point(533, 181);
            this.btnCicloPrueba.Name = "btnCicloPrueba";
            this.btnCicloPrueba.Size = new System.Drawing.Size(139, 40);
            this.btnCicloPrueba.TabIndex = 8;
            this.btnCicloPrueba.Text = "Ciclo De Prueba";
            this.btnCicloPrueba.UseVisualStyleBackColor = true;
            this.btnCicloPrueba.Click += new System.EventHandler(this.btnCicloPrueba_Click);
            // 
            // btnProyecto
            // 
            this.btnProyecto.Location = new System.Drawing.Point(237, 95);
            this.btnProyecto.Name = "btnProyecto";
            this.btnProyecto.Size = new System.Drawing.Size(147, 46);
            this.btnProyecto.TabIndex = 9;
            this.btnProyecto.Text = "Proyecto";
            this.btnProyecto.UseVisualStyleBackColor = true;
            this.btnProyecto.Click += new System.EventHandler(this.btnProyecto_Click);
            // 
            // btnCasoPrueba
            // 
            this.btnCasoPrueba.Location = new System.Drawing.Point(438, 95);
            this.btnCasoPrueba.Name = "btnCasoPrueba";
            this.btnCasoPrueba.Size = new System.Drawing.Size(147, 46);
            this.btnCasoPrueba.TabIndex = 10;
            this.btnCasoPrueba.Text = "Casos De Prueba";
            this.btnCasoPrueba.UseVisualStyleBackColor = true;
            this.btnCasoPrueba.Click += new System.EventHandler(this.btnCasoPrueba_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(143, 178);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(147, 46);
            this.btnUsuario.TabIndex = 11;
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 390);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnCasoPrueba);
            this.Controls.Add(this.btnProyecto);
            this.Controls.Add(this.btnCicloPrueba);
            this.Controls.Add(this.btnPruebaDetalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlanPrueba);
            this.Controls.Add(this.BtnProducto);
            this.Name = "Menu";
            this.Text = "Gestion de productos y planes de testing";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnProducto;
        private System.Windows.Forms.Button btnPlanPrueba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPruebaDetalle;
        private System.Windows.Forms.Button btnCicloPrueba;
        private System.Windows.Forms.Button btnProyecto;
        private System.Windows.Forms.Button btnCasoPrueba;
        private System.Windows.Forms.Button btnUsuario;
    }
}