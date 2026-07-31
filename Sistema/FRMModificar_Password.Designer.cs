namespace Sistema
{
    partial class FRMModificar_Password
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
            this.BTNVerPassword = new DevComponents.DotNetBar.ButtonX();
            this.TXTPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BTNSalir = new DevComponents.DotNetBar.ButtonX();
            this.BTNGuardarPassword = new DevComponents.DotNetBar.ButtonX();
            this.TXTNombreUsuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.TXTConfirmarPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BTNVerConfirmarPassword = new DevComponents.DotNetBar.ButtonX();
            this.LBPasswordCondicion = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // BTNVerPassword
            // 
            this.BTNVerPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNVerPassword.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNVerPassword.Image = global::Sistema.Properties.Resources.mostrar_password_icono;
            this.BTNVerPassword.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTNVerPassword.Location = new System.Drawing.Point(276, 119);
            this.BTNVerPassword.Name = "BTNVerPassword";
            this.BTNVerPassword.Size = new System.Drawing.Size(19, 27);
            this.BTNVerPassword.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNVerPassword.TabIndex = 41;
            this.BTNVerPassword.Click += new System.EventHandler(this.BTNVerPassword_Click);
            // 
            // TXTPassword
            // 
            // 
            // 
            // 
            this.TXTPassword.Border.Class = "DateTimeInputBackground";
            this.TXTPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTPassword.Location = new System.Drawing.Point(59, 119);
            this.TXTPassword.Name = "TXTPassword";
            this.TXTPassword.PreventEnterBeep = true;
            this.TXTPassword.Size = new System.Drawing.Size(211, 21);
            this.TXTPassword.TabIndex = 40;
            this.TXTPassword.UseSystemPasswordChar = true;
            this.TXTPassword.WatermarkText = "Password";
            this.TXTPassword.TextChanged += new System.EventHandler(this.TXTPassword_TextChanged);
            // 
            // BTNSalir
            // 
            this.BTNSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSalir.Image = global::Sistema.Properties.Resources.salir_icono;
            this.BTNSalir.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNSalir.Location = new System.Drawing.Point(195, 257);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(100, 33);
            this.BTNSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNSalir.TabIndex = 39;
            this.BTNSalir.Text = "&Cancelar";
            // 
            // BTNGuardarPassword
            // 
            this.BTNGuardarPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNGuardarPassword.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNGuardarPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGuardarPassword.Image = global::Sistema.Properties.Resources.login_icono;
            this.BTNGuardarPassword.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNGuardarPassword.Location = new System.Drawing.Point(59, 257);
            this.BTNGuardarPassword.Name = "BTNGuardarPassword";
            this.BTNGuardarPassword.Size = new System.Drawing.Size(95, 35);
            this.BTNGuardarPassword.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNGuardarPassword.TabIndex = 38;
            this.BTNGuardarPassword.Text = "&Guardar";
            this.BTNGuardarPassword.Click += new System.EventHandler(this.BTNGuardarPassword_Click);
            // 
            // TXTNombreUsuario
            // 
            // 
            // 
            // 
            this.TXTNombreUsuario.Border.Class = "DateTimeInputBackground";
            this.TXTNombreUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTNombreUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTNombreUsuario.Enabled = false;
            this.TXTNombreUsuario.Location = new System.Drawing.Point(59, 93);
            this.TXTNombreUsuario.Name = "TXTNombreUsuario";
            this.TXTNombreUsuario.PreventEnterBeep = true;
            this.TXTNombreUsuario.Size = new System.Drawing.Size(236, 21);
            this.TXTNombreUsuario.TabIndex = 37;
            this.TXTNombreUsuario.WatermarkText = "Login";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(120, 52);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(131, 23);
            this.labelX1.TabIndex = 36;
            this.labelX1.Text = "Modificar Contraseña";
            // 
            // TXTConfirmarPassword
            // 
            // 
            // 
            // 
            this.TXTConfirmarPassword.Border.Class = "DateTimeInputBackground";
            this.TXTConfirmarPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTConfirmarPassword.Location = new System.Drawing.Point(59, 146);
            this.TXTConfirmarPassword.Name = "TXTConfirmarPassword";
            this.TXTConfirmarPassword.PreventEnterBeep = true;
            this.TXTConfirmarPassword.Size = new System.Drawing.Size(211, 21);
            this.TXTConfirmarPassword.TabIndex = 42;
            this.TXTConfirmarPassword.UseSystemPasswordChar = true;
            this.TXTConfirmarPassword.WatermarkText = "Confirmar Password";
            // 
            // BTNVerConfirmarPassword
            // 
            this.BTNVerConfirmarPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNVerConfirmarPassword.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNVerConfirmarPassword.Image = global::Sistema.Properties.Resources.mostrar_password_icono;
            this.BTNVerConfirmarPassword.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTNVerConfirmarPassword.Location = new System.Drawing.Point(276, 146);
            this.BTNVerConfirmarPassword.Name = "BTNVerConfirmarPassword";
            this.BTNVerConfirmarPassword.Size = new System.Drawing.Size(19, 27);
            this.BTNVerConfirmarPassword.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNVerConfirmarPassword.TabIndex = 43;
            this.BTNVerConfirmarPassword.Click += new System.EventHandler(this.BTNVerConfirmarPassword_Click);
            // 
            // LBPasswordCondicion
            // 
            // 
            // 
            // 
            this.LBPasswordCondicion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBPasswordCondicion.Location = new System.Drawing.Point(59, 174);
            this.LBPasswordCondicion.Name = "LBPasswordCondicion";
            this.LBPasswordCondicion.Size = new System.Drawing.Size(236, 77);
            this.LBPasswordCondicion.TabIndex = 44;
            // 
            // FRMModificar_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 305);
            this.Controls.Add(this.LBPasswordCondicion);
            this.Controls.Add(this.BTNVerConfirmarPassword);
            this.Controls.Add(this.TXTConfirmarPassword);
            this.Controls.Add(this.BTNVerPassword);
            this.Controls.Add(this.TXTPassword);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.BTNGuardarPassword);
            this.Controls.Add(this.TXTNombreUsuario);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMModificar_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMModificarPassword";
            this.Load += new System.EventHandler(this.FRMModificar_Password_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX BTNVerPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTPassword;
        private DevComponents.DotNetBar.ButtonX BTNSalir;
        private DevComponents.DotNetBar.ButtonX BTNGuardarPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTNombreUsuario;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTConfirmarPassword;
        private DevComponents.DotNetBar.ButtonX BTNVerConfirmarPassword;
        private DevComponents.DotNetBar.LabelX LBPasswordCondicion;
    }
}