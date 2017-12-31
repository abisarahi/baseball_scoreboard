namespace ICYART_BEISBOL
{
    partial class pantalla15
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
            this.lblhitv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblhitv
            // 
            this.lblhitv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblhitv.AutoSize = true;
            this.lblhitv.BackColor = System.Drawing.Color.Black;
            this.lblhitv.Font = new System.Drawing.Font("Arial Rounded MT Bold", 750F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhitv.ForeColor = System.Drawing.Color.Yellow;
            this.lblhitv.Location = new System.Drawing.Point(200, -168);
            this.lblhitv.Name = "lblhitv";
            this.lblhitv.Size = new System.Drawing.Size(1077, 1157);
            this.lblhitv.TabIndex = 1;
            this.lblhitv.Text = "0";
            this.lblhitv.Click += new System.EventHandler(this.lblhitv_Click);
            // 
            // pantalla15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1219, 559);
            this.Controls.Add(this.lblhitv);
            this.Name = "pantalla15";
            this.Text = "pantalla15";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblhitv;
    }
}