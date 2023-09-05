namespace Restaurante
{
    partial class imagem
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
            this.cmbBebidas = new System.Windows.Forms.ComboBox();
            this.pictBebida = new System.Windows.Forms.PictureBox();
            this.lblBebidas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictBebida)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBebidas
            // 
            this.cmbBebidas.FormattingEnabled = true;
            this.cmbBebidas.Location = new System.Drawing.Point(321, 78);
            this.cmbBebidas.Name = "cmbBebidas";
            this.cmbBebidas.Size = new System.Drawing.Size(142, 23);
            this.cmbBebidas.TabIndex = 0;
            this.cmbBebidas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictBebida
            // 
            this.pictBebida.Location = new System.Drawing.Point(231, 118);
            this.pictBebida.Name = "pictBebida";
            this.pictBebida.Size = new System.Drawing.Size(334, 331);
            this.pictBebida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBebida.TabIndex = 1;
            this.pictBebida.TabStop = false;
            // 
            // lblBebidas
            // 
            this.lblBebidas.AutoSize = true;
            this.lblBebidas.Font = new System.Drawing.Font("Stencil", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblBebidas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBebidas.Location = new System.Drawing.Point(231, -1);
            this.lblBebidas.Name = "lblBebidas";
            this.lblBebidas.Size = new System.Drawing.Size(306, 76);
            this.lblBebidas.TabIndex = 2;
            this.lblBebidas.Text = "BEBIDAS";
            // 
            // imagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBebidas);
            this.Controls.Add(this.pictBebida);
            this.Controls.Add(this.cmbBebidas);
            this.Name = "imagem";
            this.Text = "imagem";
            this.Load += new System.EventHandler(this.imagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictBebida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbBebidas;
        private PictureBox pictBebida;
        private Label lblBebidas;
    }
}