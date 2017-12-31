namespace ICYART_BEISBOL
{
    partial class Pantalla4
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
            this.lblnum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.BackColor = System.Drawing.Color.Black;
            this.lblnum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 1100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum.ForeColor = System.Drawing.Color.Yellow;
            this.lblnum.Location = new System.Drawing.Point(-239, 49);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(1580, 1697);
            this.lblnum.TabIndex = 0;
            this.lblnum.Text = "0";
            // 
            // Pantalla4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1054, 1893);
            this.Controls.Add(this.lblnum);
            this.Name = "Pantalla4";
            this.Text = "Pantalla4";
            this.Load += new System.EventHandler(this.Pantalla4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblnum;
    }
}