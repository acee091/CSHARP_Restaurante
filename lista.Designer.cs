namespace Restaurante
{
    partial class lista
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
            this.lstPratos = new System.Windows.Forms.ListBox();
            this.lblPratos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstPratos
            // 
            this.lstPratos.FormattingEnabled = true;
            this.lstPratos.ItemHeight = 15;
            this.lstPratos.Location = new System.Drawing.Point(277, 152);
            this.lstPratos.Name = "lstPratos";
            this.lstPratos.Size = new System.Drawing.Size(214, 214);
            this.lstPratos.TabIndex = 0;
            // 
            // lblPratos
            // 
            this.lblPratos.AutoSize = true;
            this.lblPratos.Font = new System.Drawing.Font("Showcard Gothic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPratos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPratos.Location = new System.Drawing.Point(277, 28);
            this.lblPratos.Name = "lblPratos";
            this.lblPratos.Size = new System.Drawing.Size(214, 79);
            this.lblPratos.TabIndex = 1;
            this.lblPratos.Text = "MENU";
            // 
            // lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPratos);
            this.Controls.Add(this.lstPratos);
            this.Name = "lista";
            this.Text = "lista";
            this.Load += new System.EventHandler(this.lista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstPratos;
        private Label lblPratos;
    }
}