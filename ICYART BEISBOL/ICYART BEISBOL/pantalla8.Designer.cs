namespace ICYART_BEISBOL
{
    partial class pantalla8
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
            this.lbl10v = new System.Windows.Forms.Label();
            this.lbl9v = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl10v
            // 
            this.lbl10v.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl10v.AutoSize = true;
            this.lbl10v.BackColor = System.Drawing.Color.Black;
            this.lbl10v.Font = new System.Drawing.Font("Arial Rounded MT Bold", 650.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10v.ForeColor = System.Drawing.Color.Yellow;
            this.lbl10v.Location = new System.Drawing.Point(627, -157);
            this.lbl10v.Name = "lbl10v";
            this.lbl10v.Size = new System.Drawing.Size(934, 1003);
            this.lbl10v.TabIndex = 11;
            this.lbl10v.Text = "0";
            // 
            // lbl9v
            // 
            this.lbl9v.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl9v.AutoSize = true;
            this.lbl9v.BackColor = System.Drawing.Color.Black;
            this.lbl9v.Font = new System.Drawing.Font("Arial Rounded MT Bold", 650.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl9v.ForeColor = System.Drawing.Color.Yellow;
            this.lbl9v.Location = new System.Drawing.Point(-174, -157);
            this.lbl9v.Name = "lbl9v";
            this.lbl9v.Size = new System.Drawing.Size(934, 1003);
            this.lbl9v.TabIndex = 10;
            this.lbl9v.Text = "0";
            this.lbl9v.Click += new System.EventHandler(this.lbl9v_Click);
            // 
            // pantalla8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1228, 741);
            this.Controls.Add(this.lbl9v);
            this.Controls.Add(this.lbl10v);
            this.Name = "pantalla8";
            this.Text = "Carrera 9-10 visitante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbl10v;
        public System.Windows.Forms.Label lbl9v;
    }
}