namespace ICYART_BEISBOL
{
    partial class pantalla5
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
            this.lbl3a = new System.Windows.Forms.Label();
            this.lbl4a = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl3a
            // 
            this.lbl3a.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl3a.AutoSize = true;
            this.lbl3a.BackColor = System.Drawing.Color.Black;
            this.lbl3a.Font = new System.Drawing.Font("Arial Rounded MT Bold", 650.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3a.ForeColor = System.Drawing.Color.Yellow;
            this.lbl3a.Location = new System.Drawing.Point(-174, -157);
            this.lbl3a.Name = "lbl3a";
            this.lbl3a.Size = new System.Drawing.Size(934, 1003);
            this.lbl3a.TabIndex = 1;
            this.lbl3a.Text = "0";
            // 
            // lbl4a
            // 
            this.lbl4a.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl4a.AutoSize = true;
            this.lbl4a.BackColor = System.Drawing.Color.Black;
            this.lbl4a.Font = new System.Drawing.Font("Arial Rounded MT Bold", 650.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4a.ForeColor = System.Drawing.Color.Yellow;
            this.lbl4a.Location = new System.Drawing.Point(627, -157);
            this.lbl4a.Name = "lbl4a";
            this.lbl4a.Size = new System.Drawing.Size(934, 1003);
            this.lbl4a.TabIndex = 2;
            this.lbl4a.Text = "0";
            // 
            // pantalla5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1228, 741);
            this.Controls.Add(this.lbl3a);
            this.Controls.Add(this.lbl4a);
            this.Name = "pantalla5";
            this.Text = "Carrera 3-4 Visitante ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl3a;
        public System.Windows.Forms.Label lbl4a;
    }
}