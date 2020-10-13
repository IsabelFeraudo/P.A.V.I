namespace P.A.V.I_3K5_GestionProductosPlanesTesting
{
    partial class PantallaModificarUsuario
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
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.TxtPerfil = new System.Windows.Forms.TextBox();
            this.LblPerfil = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(38, 55);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(44, 13);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(97, 52);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 1;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(41, 212);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 2;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // TxtPerfil
            // 
            this.TxtPerfil.Location = new System.Drawing.Point(97, 84);
            this.TxtPerfil.Name = "TxtPerfil";
            this.TxtPerfil.Size = new System.Drawing.Size(100, 20);
            this.TxtPerfil.TabIndex = 4;
            // 
            // LblPerfil
            // 
            this.LblPerfil.AutoSize = true;
            this.LblPerfil.Location = new System.Drawing.Point(38, 87);
            this.LblPerfil.Name = "LblPerfil";
            this.LblPerfil.Size = new System.Drawing.Size(30, 13);
            this.LblPerfil.TabIndex = 3;
            this.LblPerfil.Text = "Perfil";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(97, 148);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(100, 20);
            this.TxtPassword.TabIndex = 8;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(38, 151);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(53, 13);
            this.LblPassword.TabIndex = 7;
            this.LblPassword.Text = "Password";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(97, 113);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(100, 20);
            this.TxtEmail.TabIndex = 6;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(38, 116);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(32, 13);
            this.LblEmail.TabIndex = 5;
            this.LblEmail.Text = "Email";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(122, 212);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // PantallaModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 347);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.TxtPerfil);
            this.Controls.Add(this.LblPerfil);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Name = "PantallaModificarUsuario";
            this.Text = "PantallaModificarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.TextBox TxtPerfil;
        private System.Windows.Forms.Label LblPerfil;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Button BtnCancelar;
    }
}