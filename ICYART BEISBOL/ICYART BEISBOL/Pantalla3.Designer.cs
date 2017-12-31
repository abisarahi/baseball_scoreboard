namespace ICYART_BEISBOL
{
    partial class Pantalla3
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
            this.lblnumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnumber
            // 
            this.lblnumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblnumber.AutoSize = true;
            this.lblnumber.BackColor = System.Drawing.Color.Black;
            this.lblnumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 1100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumber.ForeColor = System.Drawing.Color.Yellow;
            this.lblnumber.Location = new System.Drawing.Point(129, 123);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(1580, 1697);
            this.lblnumber.TabIndex = 0;
            this.lblnumber.Text = "0";
            this.lblnumber.Click += new System.EventHandler(this.lblnumber_Click);
            // 
            // Pantalla3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(904, 741);
            this.Controls.Add(this.lblnumber);
            this.Name = "Pantalla3";
            this.Text = "Pantalla3";
            this.Load += new System.EventHandler(this.Pantalla3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblnumber;
    }
}