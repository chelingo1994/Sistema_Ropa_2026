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
            this.SWBEstado = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.TXTNombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTCi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.GBDatos = new System.Windows.Forms.GroupBox();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.BTNSalir = new DevComponents.DotNetBar.ButtonX();
            this.BTNLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.BTNGuardar = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.GBDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // OFDElegirImagen
            // 
            this.OFDElegirImagen.Filter = "Elegir Imagen|*.jpeg;*.jpg;*.png";
            // 
            // SWBEstado
            // 
            // 
            // 
            // 
            this.SWBEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.BLTAyuda.SetBalloonCaption(this.SWBEstado, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.SWBEstado, "Estado de la Persona");
            this.SWBEstado.Location = new System.Drawing.Point(6, 40);
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
            this.TXTNombre.Location = new System.Drawing.Point(6, 68);
            this.TXTNombre.Name = "TXTNombre";
            this.TXTNombre.PreventEnterBeep = true;
            this.TXTNombre.Size = new System.Drawing.Size(294, 22);
            this.TXTNombre.TabIndex = 6;
            this.TXTNombre.WatermarkText = "Nombre Completo del Usuario";
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
            this.TXTCi.Location = new System.Drawing.Point(115, 40);
            this.TXTCi.Name = "TXTCi";
            this.TXTCi.PreventEnterBeep = true;
            this.TXTCi.Size = new System.Drawing.Size(103, 22);
            this.TXTCi.TabIndex = 2;
            this.TXTCi.WatermarkText = "CI";
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
            this.textBoxX1.Location = new System.Drawing.Point(6, 105);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(294, 22);
            this.textBoxX1.TabIndex = 24;
            this.textBoxX1.WatermarkText = "Login del Usuario";
            // 
            // GBDatos
            // 
            this.GBDatos.Controls.Add(this.textBoxX1);
            this.GBDatos.Controls.Add(this.BTNSalir);
            this.GBDatos.Controls.Add(this.buttonX2);
            this.GBDatos.Controls.Add(this.BTNLimpiar);
            this.GBDatos.Controls.Add(this.buttonX1);
            this.GBDatos.Controls.Add(this.BTNGuardar);
            this.GBDatos.Controls.Add(this.SWBEstado);
            this.GBDatos.Controls.Add(this.TXTNombre);
            this.GBDatos.Controls.Add(this.TXTCi);
            this.GBDatos.Location = new System.Drawing.Point(22, 51);
            this.GBDatos.Name = "GBDatos";
            this.GBDatos.Size = new System.Drawing.Size(318, 242);
            this.GBDatos.TabIndex = 25;
            this.GBDatos.TabStop = false;
            this.GBDatos.Text = "Datos del Usuario";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Image = global::Sistema.Properties.Resources.agregar;
            this.buttonX2.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.buttonX2.Location = new System.Drawing.Point(264, 40);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(36, 22);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 23;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::Sistema.Properties.Resources.ImgUsuarioBuscar;
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.buttonX1.Location = new System.Drawing.Point(222, 40);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(36, 22);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 22;
            // 
            // BTNSalir
            // 
            this.BTNSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNSalir.Image = global::Sistema.Properties.Resources.ImgUsuarioSalir;
            this.BTNSalir.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNSalir.Location = new System.Drawing.Point(216, 175);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(84, 39);
            this.BTNSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNSalir.TabIndex = 23;
            this.BTNSalir.Text = "Salir";
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNLimpiar.Image = global::Sistema.Properties.Resources.ImgUsuarioLimpiar;
            this.BTNLimpiar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNLimpiar.Location = new System.Drawing.Point(115, 175);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(88, 39);
            this.BTNLimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNLimpiar.TabIndex = 22;
            this.BTNLimpiar.Text = "Limpiar";
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNGuardar.Image = global::Sistema.Properties.Resources.ImgUsuarioGuardar;
            this.BTNGuardar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNGuardar.Location = new System.Drawing.Point(6, 173);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(90, 41);
            this.BTNGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNGuardar.TabIndex = 21;
            this.BTNGuardar.Text = "&Guardar";
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
            // FRMUsuario_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 303);
            this.Controls.Add(this.GBDatos);
            this.Controls.Add(this.labelX1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMUsuario_Registrar";
            this.Text = "FRMUsuario_Registrar";
            this.GBDatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OFDElegirImagen;
        private DevComponents.DotNetBar.BalloonTip BLTAyuda;
        private DevComponents.DotNetBar.Controls.SwitchButton SWBEstado;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTNombre;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTCi;
        private System.Windows.Forms.GroupBox GBDatos;
        private DevComponents.DotNetBar.ButtonX BTNSalir;
        private DevComponents.DotNetBar.ButtonX BTNLimpiar;
        private DevComponents.DotNetBar.ButtonX BTNGuardar;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
    }
}