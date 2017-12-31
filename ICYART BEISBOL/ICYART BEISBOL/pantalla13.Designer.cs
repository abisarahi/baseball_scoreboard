namespace ICYART_BEISBOL
{
    partial class pantalla13
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
            this.lblout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblout
            // 
            this.lblout.AutoSize = true;
            this.lblout.BackColor = System.Drawing.Color.Black;
            this.lblout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 1100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblout.ForeColor = System.Drawing.Color.Yellow;
            this.lblout.Location = new System.Drawing.Point(-239, 49);
            this.lblout.Name = "lblout";
            this.lblout.Size = new System.Drawing.Size(1580, 1697);
            this.lblout.TabIndex = 1;
            this.lblout.Text = "0";
            // 
            // pantalla13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1230, 1747);
            this.Controls.Add(this.lblout);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "pantalla13";
            this.Text = "pantalla13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblout;
    }
}