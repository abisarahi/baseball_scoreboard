namespace ICYART_BEISBOL
{
    partial class pantalla17
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
            this.lblcarrerao = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lblcarrerao
            // 
            this.lblcarrerao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblcarrerao.AutoSize = true;
            this.lblcarrerao.BackColor = System.Drawing.Color.Black;
            this.lblcarrerao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 750F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcarrerao.ForeColor = System.Drawing.Color.Yellow;
            this.lblcarrerao.Location = new System.Drawing.Point(148, -166);
            this.lblcarrerao.Name = "lblcarrerao";
            this.lblcarrerao.Size = new System.Drawing.Size(1077, 1157);
            this.lblcarrerao.TabIndex = 3;
            this.lblcarrerao.Text = "0";
            this.lblcarrerao.Click += new System.EventHandler(this.lblcarrerao_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1219, 559);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pantalla17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1219, 559);
            this.Controls.Add(this.lblcarrerao);
            this.Controls.Add(this.groupBox1);
            this.Name = "pantalla17";
            this.Text = "pantalla17";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblcarrerao;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}