namespace ICYART_BEISBOL
{
    partial class pantalla9
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
            this.lbl4o = new System.Windows.Forms.Label();
            this.lbl3o = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl4o
            // 
            this.lbl4o.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl4o.AutoSize = true;
            this.lbl4o.BackColor = System.Drawing.Color.Black;
            this.lbl4o.Font = new System.Drawing.Font("Arial Rounded MT Bold", 650.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4o.ForeColor = System.Drawing.Color.Yellow;
            this.lbl4o.Location = new System.Drawing.Point(667, -124);
            this.lbl4o.Name = "lbl4o";
            this.lbl4o.Size = new System.Drawing.Size(934, 1003);
            this.lbl4o.TabIndex = 14;
            this.lbl4o.Text = "0";
            // 
            // lbl3o
            // 
            this.lbl3o.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl3o.AutoSize = true;
            this.lbl3o.BackColor = System.Drawing.Color.Black;
            this.lbl3o.Font = new System.Drawing.Font("Arial Rounded MT Bold", 650.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3o.ForeColor = System.Drawing.Color.Yellow;
            this.lbl3o.Location = new System.Drawing.Point(-146, -124);
            this.lbl3o.Name = "lbl3o";
            this.lbl3o.Size = new System.Drawing.Size(934, 1003);
            this.lbl3o.TabIndex = 13;
            this.lbl3o.Text = "0";
            // 
            // pantalla9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1317, 741);
            this.Controls.Add(this.lbl4o);
            this.Controls.Add(this.lbl3o);
            this.Name = "pantalla9";
            this.Text = "Olmecas 3-4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbl4o;
        public System.Windows.Forms.Label lbl3o;
    }
}