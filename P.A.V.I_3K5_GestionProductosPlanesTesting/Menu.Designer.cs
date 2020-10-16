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
            this.BtnProyecto = new System.Windows.Forms.Button();
            this.BtnCasoPruebra = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnAregarUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPruebaDetalle = new System.Windows.Forms.Button();
            this.btnCicloPrueba = new System.Windows.Forms.Button();
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
            // BtnProyecto
            // 
            this.BtnProyecto.Location = new System.Drawing.Point(249, 95);
            this.BtnProyecto.Name = "BtnProyecto";
            this.BtnProyecto.Size = new System.Drawing.Size(147, 46);
            this.BtnProyecto.TabIndex = 2;
            this.BtnProyecto.Text = "Proyecto";
            this.BtnProyecto.UseVisualStyleBackColor = true;
            // 
            // BtnCasoPruebra
            // 
            this.BtnCasoPruebra.Location = new System.Drawing.Point(440, 95);
            this.BtnCasoPruebra.Name = "BtnCasoPruebra";
            this.BtnCasoPruebra.Size = new System.Drawing.Size(147, 46);
            this.BtnCasoPruebra.TabIndex = 3;
            this.BtnCasoPruebra.Text = "Caso De Prueba";
            this.BtnCasoPruebra.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Plan De Prueba";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnAregarUsuario
            // 
            this.BtnAregarUsuario.Location = new System.Drawing.Point(138, 181);
            this.BtnAregarUsuario.Name = "BtnAregarUsuario";
            this.BtnAregarUsuario.Size = new System.Drawing.Size(147, 41);
            this.BtnAregarUsuario.TabIndex = 5;
            this.BtnAregarUsuario.Text = "Usuario";
            this.BtnAregarUsuario.UseVisualStyleBackColor = true;
            this.BtnAregarUsuario.Click += new System.EventHandler(this.BtnAregarUsuario_Click);
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
            // 
            // btnCicloPrueba
            // 
            this.btnCicloPrueba.Location = new System.Drawing.Point(533, 181);
            this.btnCicloPrueba.Name = "btnCicloPrueba";
            this.btnCicloPrueba.Size = new System.Drawing.Size(139, 40);
            this.btnCicloPrueba.TabIndex = 8;
            this.btnCicloPrueba.Text = "Ciclo De Prueba";
            this.btnCicloPrueba.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 390);
            this.Controls.Add(this.btnCicloPrueba);
            this.Controls.Add(this.btnPruebaDetalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAregarUsuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCasoPruebra);
            this.Controls.Add(this.BtnProyecto);
            this.Controls.Add(this.BtnProducto);
            this.Name = "Menu";
            this.Text = "Gestion de productos y planes de testing";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnProducto;
        private System.Windows.Forms.Button BtnProyecto;
        private System.Windows.Forms.Button BtnCasoPruebra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnAregarUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPruebaDetalle;
        private System.Windows.Forms.Button btnCicloPrueba;
    }
}