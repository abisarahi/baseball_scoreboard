namespace ICYART_BEISBOL
{
    partial class pantalla11
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
            this.lbl8o = new System.Windows.Forms.Label();
            this.lbl7o = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl8o
            // 
            this.lbl8o.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl8o.AutoSize = true;
            this.lbl8o.BackColor = System.Drawing.Color.Black;
            this.lbl8o.Font = new System.Drawing.Font("Arial Rounded MT Bold", 650.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8o.ForeColor = System.Drawing.Color.Yellow;
            this.lbl8o.Location = new System.Drawing.Point(627, -157);
            this.lbl8o.Name = "lbl8o";
            this.lbl8o.Size = new System.Drawing.Size(934, 1003);
            this.lbl8o.TabIndex = 20;
            this.lbl8o.Text = "0";
            // 
            // lbl7o
            // 
            this.lbl7o.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl7o.AutoSize = true;
            this.lbl7o.BackColor = System.Drawing.Color.Black;
            this.lbl7o.Font = new System.Drawing.Font("Arial Rounded MT Bold", 650.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7o.ForeColor = System.Drawing.Color.Yellow;
            this.lbl7o.Location = new System.Drawing.Point(-174, -157);
            this.lbl7o.Name = "lbl7o";
            this.lbl7o.Size = new System.Drawing.Size(934, 1003);
            this.lbl7o.TabIndex = 19;
            this.lbl7o.Text = "0";
            // 
            // pantalla11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1228, 741);
            this.Controls.Add(this.lbl7o);
            this.Controls.Add(this.lbl8o);
            this.Name = "pantalla11";
            this.Text = "Olmeca 7-8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbl8o;
        public System.Windows.Forms.Label lbl7o;
    }
}