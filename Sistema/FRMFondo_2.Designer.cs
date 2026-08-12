namespace Sistema
{
    partial class FRMFondo_2
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
            this.components = new System.ComponentModel.Container();
            this.PNBarraInferior = new DevComponents.DotNetBar.PanelEx();
            this.LBUsuario = new DevComponents.DotNetBar.LabelX();
            this.LBFecha = new DevComponents.DotNetBar.LabelX();
            this.TMReloj = new System.Windows.Forms.Timer(this.components);
            this.PNBarraInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNBarraInferior
            // 
            this.PNBarraInferior.CanvasColor = System.Drawing.SystemColors.Control;
            this.PNBarraInferior.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PNBarraInferior.Controls.Add(this.LBFecha);
            this.PNBarraInferior.Controls.Add(this.LBUsuario);
            this.PNBarraInferior.DisabledBackColor = System.Drawing.Color.Empty;
            this.PNBarraInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PNBarraInferior.Location = new System.Drawing.Point(0, 455);
            this.PNBarraInferior.Name = "PNBarraInferior";
            this.PNBarraInferior.Size = new System.Drawing.Size(815, 45);
            this.PNBarraInferior.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PNBarraInferior.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PNBarraInferior.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PNBarraInferior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PNBarraInferior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PNBarraInferior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PNBarraInferior.Style.GradientAngle = 90;
            this.PNBarraInferior.TabIndex = 0;
            // 
            // LBUsuario
            // 
            // 
            // 
            // 
            this.LBUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBUsuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.LBUsuario.Location = new System.Drawing.Point(0, 0);
            this.LBUsuario.Name = "LBUsuario";
            this.LBUsuario.Size = new System.Drawing.Size(402, 45);
            this.LBUsuario.TabIndex = 0;
            this.LBUsuario.Text = "Usuario: Marcelo Justiniano";
            // 
            // LBFecha
            // 
            // 
            // 
            // 
            this.LBFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBFecha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LBFecha.Location = new System.Drawing.Point(402, 3);
            this.LBFecha.Name = "LBFecha";
            this.LBFecha.Size = new System.Drawing.Size(413, 42);
            this.LBFecha.TabIndex = 1;
            this.LBFecha.Text = "Bermejo,12 de Agosto de 2026 16:02:25";
            this.LBFecha.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // TMReloj
            // 
            this.TMReloj.Interval = 1000;
            this.TMReloj.Tick += new System.EventHandler(this.TMReloj_Tick);
            // 
            // FRMFondo_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 500);
            this.Controls.Add(this.PNBarraInferior);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FRMFondo_2";
            this.Text = "FRMFondo_2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRMFondo_2_FormClosed);
            this.Load += new System.EventHandler(this.FRMFondo_2_Load);
            this.PNBarraInferior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx PNBarraInferior;
        private DevComponents.DotNetBar.LabelX LBFecha;
        private DevComponents.DotNetBar.LabelX LBUsuario;
        private System.Windows.Forms.Timer TMReloj;
    }
}