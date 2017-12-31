namespace ICYART_BEISBOL
{
    partial class pantalla7
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
            this.lbl8v = new System.Windows.Forms.Label();
            this.lbl7v = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl8v
            // 
            this.lbl8v.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl8v.AutoSize = true;
            this.lbl8v.BackColor = System.Drawing.Color.Black;
            this.lbl8v.Font = new System.Drawing.Font("Arial Rounded MT Bold", 650.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8v.ForeColor = System.Drawing.Color.Yellow;
            this.lbl8v.Location = new System.Drawing.Point(627, -157);
            this.lbl8v.Name = "lbl8v";
            this.lbl8v.Size = new System.Drawing.Size(934, 1003);
            this.lbl8v.TabIndex = 8;
            this.lbl8v.Text = "0";
            // 
            // lbl7v
            // 
            this.lbl7v.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl7v.AutoSize = true;
            this.lbl7v.BackColor = System.Drawing.Color.Black;
            this.lbl7v.Font = new System.Drawing.Font("Arial Rounded MT Bold", 650.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7v.ForeColor = System.Drawing.Color.Yellow;
            this.lbl7v.Location = new System.Drawing.Point(-174, -157);
            this.lbl7v.Name = "lbl7v";
            this.lbl7v.Size = new System.Drawing.Size(934, 1003);
            this.lbl7v.TabIndex = 7;
            this.lbl7v.Text = "0";
            // 
            // pantalla7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1228, 741);
            this.Controls.Add(this.lbl7v);
            this.Controls.Add(this.lbl8v);
            this.Name = "pantalla7";
            this.Text = "Carrera 7-8 Visitante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbl8v;
        public System.Windows.Forms.Label lbl7v;
    }
}