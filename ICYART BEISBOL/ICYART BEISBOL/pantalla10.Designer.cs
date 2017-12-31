namespace ICYART_BEISBOL
{
    partial class pantalla10
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
            this.lbl6o = new System.Windows.Forms.Label();
            this.lbl5o = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl6o
            // 
            this.lbl6o.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl6o.AutoSize = true;
            this.lbl6o.BackColor = System.Drawing.Color.Black;
            this.lbl6o.Font = new System.Drawing.Font("Arial Rounded MT Bold", 650.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6o.ForeColor = System.Drawing.Color.Yellow;
            this.lbl6o.Location = new System.Drawing.Point(627, -157);
            this.lbl6o.Name = "lbl6o";
            this.lbl6o.Size = new System.Drawing.Size(934, 1003);
            this.lbl6o.TabIndex = 17;
            this.lbl6o.Text = "0";
            this.lbl6o.Click += new System.EventHandler(this.lbl6o_Click);
            // 
            // lbl5o
            // 
            this.lbl5o.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl5o.AutoSize = true;
            this.lbl5o.BackColor = System.Drawing.Color.Black;
            this.lbl5o.Font = new System.Drawing.Font("Arial Rounded MT Bold", 650.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5o.ForeColor = System.Drawing.Color.Yellow;
            this.lbl5o.Location = new System.Drawing.Point(-174, -157);
            this.lbl5o.Name = "lbl5o";
            this.lbl5o.Size = new System.Drawing.Size(934, 1003);
            this.lbl5o.TabIndex = 16;
            this.lbl5o.Text = "0";
            // 
            // pantalla10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1228, 741);
            this.Controls.Add(this.lbl6o);
            this.Controls.Add(this.lbl5o);
            this.Name = "pantalla10";
            this.Text = "Olmeca 5-6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbl6o;
        public System.Windows.Forms.Label lbl5o;
    }
}