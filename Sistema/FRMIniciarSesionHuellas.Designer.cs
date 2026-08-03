namespace Sistema
{
    partial class FRMIniciarSesionHuellas
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.LBMensaje = new DevComponents.DotNetBar.LabelX();
            this.PCHuellas = new System.Windows.Forms.PictureBox();
            this.VCHuella = new DPFP.Gui.Verification.VerificationControl();
            ((System.ComponentModel.ISupportInitialize)(this.PCHuellas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(227, 32);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(96, 23);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "Iniciar Sesion";
            // 
            // LBMensaje
            // 
            // 
            // 
            // 
            this.LBMensaje.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMensaje.Location = new System.Drawing.Point(12, 61);
            this.LBMensaje.Name = "LBMensaje";
            this.LBMensaje.Size = new System.Drawing.Size(364, 176);
            this.LBMensaje.TabIndex = 7;
            this.LBMensaje.Text = "Coloque su huella  en el lector biometrico";
            // 
            // PCHuellas
            // 
            this.PCHuellas.Image = global::Sistema.Properties.Resources.icono_login_finger;
            this.PCHuellas.Location = new System.Drawing.Point(406, 85);
            this.PCHuellas.Name = "PCHuellas";
            this.PCHuellas.Size = new System.Drawing.Size(123, 125);
            this.PCHuellas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCHuellas.TabIndex = 9;
            this.PCHuellas.TabStop = false;
            // 
            // VCHuella
            // 
            this.VCHuella.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.VCHuella.Location = new System.Drawing.Point(340, 85);
            this.VCHuella.Margin = new System.Windows.Forms.Padding(4);
            this.VCHuella.Name = "VCHuella";
            this.VCHuella.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.VCHuella.Size = new System.Drawing.Size(48, 47);
            this.VCHuella.TabIndex = 10;
            this.VCHuella.OnComplete += new DPFP.Gui.Verification.VerificationControl._OnComplete(this.VCHuella_OnComplete);
            // 
            // FRMIniciarSesionHuellas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 261);
            this.Controls.Add(this.VCHuella);
            this.Controls.Add(this.PCHuellas);
            this.Controls.Add(this.LBMensaje);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMIniciarSesionHuellas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMIniciarSesionHuellas";
            ((System.ComponentModel.ISupportInitialize)(this.PCHuellas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX LBMensaje;
        private System.Windows.Forms.PictureBox PCHuellas;
        private DPFP.Gui.Verification.VerificationControl VCHuella;
    }
}