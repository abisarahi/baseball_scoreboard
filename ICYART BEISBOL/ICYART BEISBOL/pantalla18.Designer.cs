namespace ICYART_BEISBOL
{
    partial class pantalla18
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
            this.lblhito = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblhito
            // 
            this.lblhito.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblhito.AutoSize = true;
            this.lblhito.BackColor = System.Drawing.Color.Black;
            this.lblhito.Font = new System.Drawing.Font("Arial Rounded MT Bold", 750F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhito.ForeColor = System.Drawing.Color.Yellow;
            this.lblhito.Location = new System.Drawing.Point(200, -168);
            this.lblhito.Name = "lblhito";
            this.lblhito.Size = new System.Drawing.Size(1077, 1157);
            this.lblhito.TabIndex = 4;
            this.lblhito.Text = "0";
            this.lblhito.Click += new System.EventHandler(this.lblhito_Click);
            // 
            // pantalla18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1219, 559);
            this.Controls.Add(this.lblhito);
            this.Name = "pantalla18";
            this.Text = "pantalla18";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblhito;
    }
}