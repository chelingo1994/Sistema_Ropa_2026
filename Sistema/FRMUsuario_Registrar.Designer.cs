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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMUsuario_Registrar));
            this.OFDElegirImagen = new System.Windows.Forms.OpenFileDialog();
            this.BLTAyuda = new DevComponents.DotNetBar.BalloonTip();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.TXTCi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTNombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SWBEstado = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.BTNGuardar = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.BTNLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.BTNSalir = new DevComponents.DotNetBar.ButtonX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.axDPFPEnrollmentControl1 = new AxDPFPCtlXLib.AxDPFPEnrollmentControl();
            ((System.ComponentModel.ISupportInitialize)(this.axDPFPEnrollmentControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // OFDElegirImagen
            // 
            this.OFDElegirImagen.Filter = "Elegir Imagen|*.jpeg;*.jpg;*.png";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(150, 22);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 20;
            this.labelX1.Text = "Usuario";
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
            // 
            // TXTNombre
            // 
            this.BLTAyuda.SetBalloonCaption(this.TXTNombre, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.TXTNombre, "Nombres de la Persona");
            // 
            // 
            // 
            this.TXTNombre.Border.Class = "TextBoxBorder";
            this.TXTNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTNombre.Location = new System.Drawing.Point(346, 47);
            this.TXTNombre.Name = "TXTNombre";
            this.TXTNombre.PreventEnterBeep = true;
            this.TXTNombre.Size = new System.Drawing.Size(294, 22);
            this.TXTNombre.TabIndex = 6;
            this.TXTNombre.WatermarkText = "Nombre Completo del Usuario";
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
            // BTNGuardar
            // 
            this.BTNGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNGuardar.Image = global::Sistema.Properties.Resources.ImgUsuarioGuardar;
            this.BTNGuardar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNGuardar.Location = new System.Drawing.Point(622, 189);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(90, 41);
            this.BTNGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNGuardar.TabIndex = 21;
            this.BTNGuardar.Text = "&Guardar";
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
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNLimpiar.Image = global::Sistema.Properties.Resources.ImgUsuarioLimpiar;
            this.BTNLimpiar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNLimpiar.Location = new System.Drawing.Point(622, 243);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(88, 39);
            this.BTNLimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNLimpiar.TabIndex = 22;
            this.BTNLimpiar.Text = "Limpiar";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Image = global::Sistema.Properties.Resources.agregar;
            this.buttonX2.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.buttonX2.Location = new System.Drawing.Point(293, 47);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(36, 22);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 23;
            // 
            // BTNSalir
            // 
            this.BTNSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNSalir.Image = global::Sistema.Properties.Resources.ImgUsuarioSalir;
            this.BTNSalir.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNSalir.Location = new System.Drawing.Point(622, 299);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(84, 39);
            this.BTNSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNSalir.TabIndex = 23;
            this.BTNSalir.Text = "Salir";
            // 
            // textBoxX1
            // 
            this.BLTAyuda.SetBalloonCaption(this.textBoxX1, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.textBoxX1, "Nombres de la Persona");
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxX1.Location = new System.Drawing.Point(646, 47);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(162, 22);
            this.textBoxX1.TabIndex = 24;
            this.textBoxX1.WatermarkText = "Login del Usuario";
            // 
            // axDPFPEnrollmentControl1
            // 
            this.axDPFPEnrollmentControl1.Enabled = true;
            this.axDPFPEnrollmentControl1.Location = new System.Drawing.Point(67, 101);
            this.axDPFPEnrollmentControl1.Name = "axDPFPEnrollmentControl1";
            this.axDPFPEnrollmentControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axDPFPEnrollmentControl1.OcxState")));
            this.axDPFPEnrollmentControl1.Size = new System.Drawing.Size(495, 314);
            this.axDPFPEnrollmentControl1.TabIndex = 25;
            // 
            // FRMUsuario_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 488);
            this.Controls.Add(this.axDPFPEnrollmentControl1);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.BTNLimpiar);
            this.Controls.Add(this.TXTCi);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.TXTNombre);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.SWBEstado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMUsuario_Registrar";
            this.Text = "FRMUsuario_Registrar";
            ((System.ComponentModel.ISupportInitialize)(this.axDPFPEnrollmentControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OFDElegirImagen;
        private DevComponents.DotNetBar.BalloonTip BLTAyuda;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTCi;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTNombre;
        private DevComponents.DotNetBar.Controls.SwitchButton SWBEstado;
        private DevComponents.DotNetBar.ButtonX BTNGuardar;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX BTNLimpiar;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX BTNSalir;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private AxDPFPCtlXLib.AxDPFPEnrollmentControl axDPFPEnrollmentControl1;
    }
}