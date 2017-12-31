namespace ICYART_BEISBOL
{
    partial class Muestra
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
            this.lblocal = new System.Windows.Forms.Label();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lblbis = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblocal
            // 
            this.lblocal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblocal.AutoSize = true;
            this.lblocal.BackColor = System.Drawing.Color.Black;
            this.lblocal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 650.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblocal.ForeColor = System.Drawing.Color.Yellow;
            this.lblocal.Location = new System.Drawing.Point(620, -157);
            this.lblocal.Name = "lblocal";
            this.lblocal.Size = new System.Drawing.Size(934, 1003);
            this.lblocal.TabIndex = 0;
            this.lblocal.Text = "0";
            this.lblocal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblocal.Click += new System.EventHandler(this.lblocal_Click);
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT   * \r\nFROM            Query1";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\LMB_v2003.mdb";
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Query1", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("nombre", "nombre"),
                        new System.Data.Common.DataColumnMapping("id_equipo", "id_equipo"),
                        new System.Data.Common.DataColumnMapping("nombres", "nombres"),
                        new System.Data.Common.DataColumnMapping("id_nacionalidad", "id_nacionalidad"),
                        new System.Data.Common.DataColumnMapping("nacionalidad", "nacionalidad"),
                        new System.Data.Common.DataColumnMapping("id_posicion", "id_posicion"),
                        new System.Data.Common.DataColumnMapping("Posición", "Posición"),
                        new System.Data.Common.DataColumnMapping("foto", "foto")})});
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(855, 741);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // lblbis
            // 
            this.lblbis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblbis.AutoSize = true;
            this.lblbis.BackColor = System.Drawing.Color.Black;
            this.lblbis.Font = new System.Drawing.Font("Arial Rounded MT Bold", 650.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbis.ForeColor = System.Drawing.Color.Yellow;
            this.lblbis.Location = new System.Drawing.Point(-174, -157);
            this.lblbis.Name = "lblbis";
            this.lblbis.Size = new System.Drawing.Size(934, 1003);
            this.lblbis.TabIndex = 2;
            this.lblbis.Text = "0";
            this.lblbis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Location = new System.Drawing.Point(629, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 780);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1228, 741);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Muestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1228, 741);
            this.Controls.Add(this.lblbis);
            this.Controls.Add(this.lblocal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Muestra";
            this.Text = "Carrera 1-2 Visitante";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblocal;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Windows.Forms.Splitter splitter1;
        public System.Windows.Forms.Label lblbis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}