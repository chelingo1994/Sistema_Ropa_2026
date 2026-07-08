namespace Sistema
{
    partial class FRMUsuario_Registrar
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
            this.OFDElegirImagen = new System.Windows.Forms.OpenFileDialog();
            this.BLTAyuda = new DevComponents.DotNetBar.BalloonTip();
            this.TXTCi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTNombres = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SWBEstado = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.TXTNombreLogin = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.BTNSalir = new DevComponents.DotNetBar.ButtonX();
            this.BTNLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.BTNGuardar = new DevComponents.DotNetBar.ButtonX();
            this.DPEHuellas = new DPFP.Gui.Enrollment.EnrollmentControl();
            this.SuspendLayout();
            // 
            // OFDElegirImagen
            // 
            this.OFDElegirImagen.Filter = "Elegir Imagen|*.jpeg;*.jpg;*.png";
            // 
            // TXTCi
            // 
            this.BLTAyuda.SetBalloonCaption(this.TXTCi, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.TXTCi, "Numero de Documento de Identidad de la Persona");
            // 
            // 
            // 
            this.TXTCi.Border.Class = "TextBoxBorder";
            this.TXTCi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTCi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTCi.Location = new System.Drawing.Point(142, 47);
            this.TXTCi.Name = "TXTCi";
            this.TXTCi.PreventEnterBeep = true;
            this.TXTCi.Size = new System.Drawing.Size(103, 22);
            this.TXTCi.TabIndex = 2;
            this.TXTCi.WatermarkText = "CI";
            this.TXTCi.Enter += new System.EventHandler(this.TXTCi_Enter);
            this.TXTCi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTCi_KeyDown);
            // 
            // TXTNombres
            // 
            this.BLTAyuda.SetBalloonCaption(this.TXTNombres, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.TXTNombres, "Nombres de la Persona");
            // 
            // 
            // 
            this.TXTNombres.Border.Class = "TextBoxBorder";
            this.TXTNombres.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTNombres.Location = new System.Drawing.Point(293, 47);
            this.TXTNombres.Name = "TXTNombres";
            this.TXTNombres.PreventEnterBeep = true;
            this.TXTNombres.Size = new System.Drawing.Size(294, 22);
            this.TXTNombres.TabIndex = 6;
            this.TXTNombres.WatermarkText = "Nombre Completo del Usuario";
            this.TXTNombres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTNombres_KeyDown);
            // 
            // SWBEstado
            // 
            // 
            // 
            // 
            this.SWBEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.BLTAyuda.SetBalloonCaption(this.SWBEstado, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.SWBEstado, "Estado de la Persona");
            this.SWBEstado.Location = new System.Drawing.Point(33, 47);
            this.SWBEstado.Name = "SWBEstado";
            this.SWBEstado.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SWBEstado.OffText = "Inhabilitado";
            this.SWBEstado.OffTextColor = System.Drawing.Color.White;
            this.SWBEstado.OnBackColor = System.Drawing.Color.LimeGreen;
            this.SWBEstado.OnText = "Habilitado";
            this.SWBEstado.OnTextColor = System.Drawing.Color.White;
            this.SWBEstado.Size = new System.Drawing.Size(103, 22);
            this.SWBEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SWBEstado.TabIndex = 0;
            this.SWBEstado.TabStop = false;
            this.SWBEstado.Value = true;
            this.SWBEstado.ValueObject = "Y";
            // 
            // TXTNombreLogin
            // 
            this.BLTAyuda.SetBalloonCaption(this.TXTNombreLogin, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.TXTNombreLogin, "Nombres de la Persona");
            // 
            // 
            // 
            this.TXTNombreLogin.Border.Class = "TextBoxBorder";
            this.TXTNombreLogin.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTNombreLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTNombreLogin.Location = new System.Drawing.Point(593, 47);
            this.TXTNombreLogin.Name = "TXTNombreLogin";
            this.TXTNombreLogin.PreventEnterBeep = true;
            this.TXTNombreLogin.Size = new System.Drawing.Size(162, 22);
            this.TXTNombreLogin.TabIndex = 24;
            this.TXTNombreLogin.WatermarkText = "Login del Usuario";
            this.TXTNombreLogin.Enter += new System.EventHandler(this.TXTCi_Enter);
            this.TXTNombreLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTNombreLogin_KeyDown);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(309, 18);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 20;
            this.labelX1.Text = "Usuario";
            // 
            // BTNSalir
            // 
            this.BTNSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNSalir.Image = global::Sistema.Properties.Resources.ImgUsuarioSalir;
            this.BTNSalir.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNSalir.Location = new System.Drawing.Point(671, 435);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(84, 39);
            this.BTNSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNSalir.TabIndex = 23;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNLimpiar.Image = global::Sistema.Properties.Resources.ImgUsuarioLimpiar;
            this.BTNLimpiar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNLimpiar.Location = new System.Drawing.Point(219, 437);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(88, 39);
            this.BTNLimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNLimpiar.TabIndex = 22;
            this.BTNLimpiar.Text = "Limpiar";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::Sistema.Properties.Resources.ImgUsuarioBuscar;
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.buttonX1.Location = new System.Drawing.Point(251, 47);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(36, 22);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 22;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNGuardar.Image = global::Sistema.Properties.Resources.ImgUsuarioGuardar;
            this.BTNGuardar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNGuardar.Location = new System.Drawing.Point(67, 435);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(90, 41);
            this.BTNGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNGuardar.TabIndex = 21;
            this.BTNGuardar.Text = "&Guardar";
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // DPEHuellas
            // 
            this.DPEHuellas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DPEHuellas.EnrolledFingerMask = 0;
            this.DPEHuellas.Location = new System.Drawing.Point(153, 92);
            this.DPEHuellas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DPEHuellas.MaxEnrollFingerCount = 4;
            this.DPEHuellas.Name = "DPEHuellas";
            this.DPEHuellas.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.DPEHuellas.Size = new System.Drawing.Size(492, 314);
            this.DPEHuellas.TabIndex = 25;
            this.DPEHuellas.OnDelete += new DPFP.Gui.Enrollment.EnrollmentControl._OnDelete(this.DPEHuellas_OnDelete);
            this.DPEHuellas.OnEnroll += new DPFP.Gui.Enrollment.EnrollmentControl._OnEnroll(this.DPEHuellas_OnEnroll);
            // 
            // FRMUsuario_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 488);
            this.Controls.Add(this.DPEHuellas);
            this.Controls.Add(this.TXTNombreLogin);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.BTNLimpiar);
            this.Controls.Add(this.TXTCi);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.TXTNombres);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.SWBEstado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMUsuario_Registrar";
            this.Text = "FRMUsuario_Registrar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMUsuario_Registrar_FormClosing);
            this.Load += new System.EventHandler(this.FRMUsuario_Registrar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OFDElegirImagen;
        private DevComponents.DotNetBar.BalloonTip BLTAyuda;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTCi;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTNombres;
        private DevComponents.DotNetBar.Controls.SwitchButton SWBEstado;
        private DevComponents.DotNetBar.ButtonX BTNGuardar;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX BTNLimpiar;
        private DevComponents.DotNetBar.ButtonX BTNSalir;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTNombreLogin;
        private DPFP.Gui.Enrollment.EnrollmentControl DPEHuellas;
    }
}