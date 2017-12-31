namespace ICYART_BEISBOL
{
    partial class pantalla19
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
            this.lblerroro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblerroro
            // 
            this.lblerroro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblerroro.AutoSize = true;
            this.lblerroro.BackColor = System.Drawing.Color.Black;
            this.lblerroro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 1100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerroro.ForeColor = System.Drawing.Color.Yellow;
            this.lblerroro.Location = new System.Drawing.Point(-239, 49);
            this.lblerroro.Name = "lblerroro";
            this.lblerroro.Size = new System.Drawing.Size(1580, 1697);
            this.lblerroro.TabIndex = 5;
            this.lblerroro.Text = "0";
            this.lblerroro.Click += new System.EventHandler(this.lblerroro_Click);
            // 
            // pantalla19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1054, 741);
            this.Controls.Add(this.lblerroro);
            this.Name = "pantalla19";
            this.Text = "pantalla19";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblerroro;
    }
}