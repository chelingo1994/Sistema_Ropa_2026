namespace Sistema
{
    partial class FRMCategoriaRegistrar
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
            this.GBDatos = new System.Windows.Forms.GroupBox();
            this.SWBEstado = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.TXTNombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTDescripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BTNSalir = new DevComponents.DotNetBar.ButtonX();
            this.BTNLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.BTNGuardar = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.GBDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBDatos
            // 
            this.GBDatos.Controls.Add(this.SWBEstado);
            this.GBDatos.Controls.Add(this.TXTNombre);
            this.GBDatos.Controls.Add(this.TXTDescripcion);
            this.GBDatos.Location = new System.Drawing.Point(59, 41);
            this.GBDatos.Name = "GBDatos";
            this.GBDatos.Size = new System.Drawing.Size(273, 207);
            this.GBDatos.TabIndex = 25;
            this.GBDatos.TabStop = false;
            this.GBDatos.Text = "Datos de Categoria";
            // 
            // SWBEstado
            // 
            // 
            // 
            // 
            this.SWBEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SWBEstado.Location = new System.Drawing.Point(67, 38);
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
            // 
            // 
            // 
            this.TXTNombre.Border.Class = "TextBoxBorder";
            this.TXTNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTNombre.Location = new System.Drawing.Point(0, 82);
            this.TXTNombre.Name = "TXTNombre";
            this.TXTNombre.PreventEnterBeep = true;
            this.TXTNombre.Size = new System.Drawing.Size(252, 23);
            this.TXTNombre.TabIndex = 6;
            this.TXTNombre.WatermarkText = "Nombre de Categoria";
            this.TXTNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTNombre_KeyDown);
            // 
            // TXTDescripcion
            // 
            // 
            // 
            // 
            this.TXTDescripcion.Border.Class = "TextBoxBorder";
            this.TXTDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTDescripcion.Location = new System.Drawing.Point(0, 111);
            this.TXTDescripcion.Multiline = true;
            this.TXTDescripcion.Name = "TXTDescripcion";
            this.TXTDescripcion.PreventEnterBeep = true;
            this.TXTDescripcion.Size = new System.Drawing.Size(252, 86);
            this.TXTDescripcion.TabIndex = 9;
            this.TXTDescripcion.TabStop = false;
            this.TXTDescripcion.WatermarkText = "Descripcion";
            // 
            // BTNSalir
            // 
            this.BTNSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNSalir.Image = global::Sistema.Properties.Resources.ImgUsuarioSalir;
            this.BTNSalir.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNSalir.Location = new System.Drawing.Point(227, 254);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(95, 37);
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
            this.BTNLimpiar.Location = new System.Drawing.Point(133, 252);
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
            this.BTNGuardar.Location = new System.Drawing.Point(37, 252);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(90, 41);
            this.BTNGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNGuardar.TabIndex = 21;
            this.BTNGuardar.Text = "&Guardar";
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(179, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 20;
            this.labelX1.Text = "Categoria";
            // 
            // FRMCategoriaRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 308);
            this.Controls.Add(this.GBDatos);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.BTNLimpiar);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FRMCategoriaRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMCategoriaRegistrar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMCategoriaRegistrar_FormClosing);
            this.Load += new System.EventHandler(this.FRMCategoriaRegistrar_Load);
            this.GBDatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBDatos;
        private DevComponents.DotNetBar.Controls.SwitchButton SWBEstado;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTNombre;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTDescripcion;
        private DevComponents.DotNetBar.ButtonX BTNSalir;
        private DevComponents.DotNetBar.ButtonX BTNLimpiar;
        private DevComponents.DotNetBar.ButtonX BTNGuardar;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}