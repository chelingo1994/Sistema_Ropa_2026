namespace Sistema
{
    partial class FRMIniciar_Sesion
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
            this.TXTNombreUsuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.TXTPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BTNVerPassword = new DevComponents.DotNetBar.ButtonX();
            this.BTNSalir = new DevComponents.DotNetBar.ButtonX();
            this.BTNGuardar = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // TXTNombreUsuario
            // 
            // 
            // 
            // 
            this.TXTNombreUsuario.Border.Class = "DateTimeInputBackground";
            this.TXTNombreUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTNombreUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTNombreUsuario.Location = new System.Drawing.Point(31, 73);
            this.TXTNombreUsuario.Name = "TXTNombreUsuario";
            this.TXTNombreUsuario.PreventEnterBeep = true;
            this.TXTNombreUsuario.Size = new System.Drawing.Size(236, 20);
            this.TXTNombreUsuario.TabIndex = 1;
            this.TXTNombreUsuario.WatermarkText = "Login";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(114, 32);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(96, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Iniciar Sesion";
            // 
            // TXTPassword
            // 
            // 
            // 
            // 
            this.TXTPassword.Border.Class = "DateTimeInputBackground";
            this.TXTPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTPassword.Location = new System.Drawing.Point(31, 99);
            this.TXTPassword.Name = "TXTPassword";
            this.TXTPassword.PreventEnterBeep = true;
            this.TXTPassword.Size = new System.Drawing.Size(211, 20);
            this.TXTPassword.TabIndex = 2;
            this.TXTPassword.UseSystemPasswordChar = true;
            this.TXTPassword.WatermarkText = "Password";
            // 
            // BTNVerPassword
            // 
            this.BTNVerPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNVerPassword.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNVerPassword.Image = global::Sistema.Properties.Resources.mostrar_password_icono;
            this.BTNVerPassword.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTNVerPassword.Location = new System.Drawing.Point(248, 99);
            this.BTNVerPassword.Name = "BTNVerPassword";
            this.BTNVerPassword.Size = new System.Drawing.Size(19, 27);
            this.BTNVerPassword.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNVerPassword.TabIndex = 3;
            this.BTNVerPassword.Click += new System.EventHandler(this.BTNVerPassword_Click);
            // 
            // BTNSalir
            // 
            this.BTNSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSalir.Image = global::Sistema.Properties.Resources.salir_icono;
            this.BTNSalir.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNSalir.Location = new System.Drawing.Point(167, 142);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(100, 33);
            this.BTNSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNSalir.TabIndex = 5;
            this.BTNSalir.Text = "&Cancelar";
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGuardar.Image = global::Sistema.Properties.Resources.login_icono;
            this.BTNGuardar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNGuardar.Location = new System.Drawing.Point(31, 140);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(95, 35);
            this.BTNGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNGuardar.TabIndex = 4;
            this.BTNGuardar.Text = "&Entrar";
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // FRMIniciar_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 212);
            this.Controls.Add(this.BTNVerPassword);
            this.Controls.Add(this.TXTPassword);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.TXTNombreUsuario);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMIniciar_Sesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMIniciar_Sesion";
            this.Load += new System.EventHandler(this.FRMIniciar_Sesion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX TXTNombreUsuario;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX BTNSalir;
        private DevComponents.DotNetBar.ButtonX BTNGuardar;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTPassword;
        private DevComponents.DotNetBar.ButtonX BTNVerPassword;
    }
}