namespace ICYART_BEISBOL
{
    partial class pantalla12
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
            this.lbl10o = new System.Windows.Forms.Label();
            this.lbl9o = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl10o
            // 
            this.lbl10o.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl10o.AutoSize = true;
            this.lbl10o.BackColor = System.Drawing.Color.Black;
            this.lbl10o.Font = new System.Drawing.Font("Arial Rounded MT Bold", 650.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10o.ForeColor = System.Drawing.Color.Yellow;
            this.lbl10o.Location = new System.Drawing.Point(627, -157);
            this.lbl10o.Name = "lbl10o";
            this.lbl10o.Size = new System.Drawing.Size(934, 1003);
            this.lbl10o.TabIndex = 23;
            this.lbl10o.Text = "0";
            // 
            // lbl9o
            // 
            this.lbl9o.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl9o.AutoSize = true;
            this.lbl9o.BackColor = System.Drawing.Color.Black;
            this.lbl9o.Font = new System.Drawing.Font("Arial Rounded MT Bold", 650.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl9o.ForeColor = System.Drawing.Color.Yellow;
            this.lbl9o.Location = new System.Drawing.Point(-174, -157);
            this.lbl9o.Name = "lbl9o";
            this.lbl9o.Size = new System.Drawing.Size(934, 1003);
            this.lbl9o.TabIndex = 22;
            this.lbl9o.Text = "0";
            // 
            // pantalla12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1228, 741);
            this.Controls.Add(this.lbl9o);
            this.Controls.Add(this.lbl10o);
            this.Name = "pantalla12";
            this.Text = "Olmeca 9-10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbl10o;
        public System.Windows.Forms.Label lbl9o;
    }
}