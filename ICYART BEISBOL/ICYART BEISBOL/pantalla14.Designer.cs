namespace ICYART_BEISBOL
{
    partial class pantalla14
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
            this.lblcarrerav = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblcarrerav
            // 
            this.lblcarrerav.AutoSize = true;
            this.lblcarrerav.BackColor = System.Drawing.Color.Black;
            this.lblcarrerav.Font = new System.Drawing.Font("Arial Rounded MT Bold", 750F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcarrerav.ForeColor = System.Drawing.Color.Yellow;
            this.lblcarrerav.Location = new System.Drawing.Point(190, -200);
            this.lblcarrerav.Name = "lblcarrerav";
            this.lblcarrerav.Size = new System.Drawing.Size(1077, 1157);
            this.lblcarrerav.TabIndex = 2;
            this.lblcarrerav.Text = "0";
            this.lblcarrerav.Click += new System.EventHandler(this.lblcarrerav_Click);
            // 
            // pantalla14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1219, 559);
            this.Controls.Add(this.lblcarrerav);
            this.Name = "pantalla14";
            this.Text = "pantalla14";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblcarrerav;
    }
}