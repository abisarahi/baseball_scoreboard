namespace ICYART_BEISBOL
{
    partial class pantalla6
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
            this.lbl6v = new System.Windows.Forms.Label();
            this.lbl5v = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl6v
            // 
            this.lbl6v.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl6v.AutoSize = true;
            this.lbl6v.BackColor = System.Drawing.Color.Black;
            this.lbl6v.Font = new System.Drawing.Font("Arial Rounded MT Bold", 650.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6v.ForeColor = System.Drawing.Color.Yellow;
            this.lbl6v.Location = new System.Drawing.Point(627, -157);
            this.lbl6v.Name = "lbl6v";
            this.lbl6v.Size = new System.Drawing.Size(934, 1003);
            this.lbl6v.TabIndex = 5;
            this.lbl6v.Text = "0";
            this.lbl6v.Click += new System.EventHandler(this.lbl6v_Click);
            // 
            // lbl5v
            // 
            this.lbl5v.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl5v.AutoSize = true;
            this.lbl5v.BackColor = System.Drawing.Color.Black;
            this.lbl5v.Font = new System.Drawing.Font("Arial Rounded MT Bold", 650.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5v.ForeColor = System.Drawing.Color.Yellow;
            this.lbl5v.Location = new System.Drawing.Point(-174, -157);
            this.lbl5v.Name = "lbl5v";
            this.lbl5v.Size = new System.Drawing.Size(934, 1003);
            this.lbl5v.TabIndex = 4;
            this.lbl5v.Text = "0";
            // 
            // pantalla6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1228, 741);
            this.Controls.Add(this.lbl6v);
            this.Controls.Add(this.lbl5v);
            this.Enabled = false;
            this.Name = "pantalla6";
            this.Text = "Carrera 5-6 Visitante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbl6v;
        public System.Windows.Forms.Label lbl5v;
    }
}