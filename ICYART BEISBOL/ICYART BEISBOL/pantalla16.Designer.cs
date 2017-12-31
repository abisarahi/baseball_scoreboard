namespace ICYART_BEISBOL
{
    partial class pantalla16
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
            this.lblerrorv = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblerrorv
            // 
            this.lblerrorv.AutoSize = true;
            this.lblerrorv.BackColor = System.Drawing.Color.Black;
            this.lblerrorv.Font = new System.Drawing.Font("Arial Rounded MT Bold", 1100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerrorv.ForeColor = System.Drawing.Color.Yellow;
            this.lblerrorv.Location = new System.Drawing.Point(-239, 49);
            this.lblerrorv.Name = "lblerrorv";
            this.lblerrorv.Size = new System.Drawing.Size(1580, 1697);
            this.lblerrorv.TabIndex = 2;
            this.lblerrorv.Text = "0";
            this.lblerrorv.Click += new System.EventHandler(this.lblerrorv_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.lblerrorv);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1054, 741);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pantalla16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1054, 741);
            this.Controls.Add(this.groupBox1);
            this.Name = "pantalla16";
            this.Text = "pantalla16";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblerrorv;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}