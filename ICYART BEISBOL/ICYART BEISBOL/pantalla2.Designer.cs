namespace ICYART_BEISBOL
{
    partial class pantalla2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblP2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 650.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(-174, -157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(934, 1003);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 650.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2.ForeColor = System.Drawing.Color.Yellow;
            this.lblP2.Location = new System.Drawing.Point(627, -157);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(934, 1003);
            this.lblP2.TabIndex = 1;
            this.lblP2.Text = "0";
            // 
            // pantalla2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1299, 741);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblP2);
            this.Name = "pantalla2";
            this.Text = "Carrera Olmeca 1 y 2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.pantalla2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblP2;
    }
}