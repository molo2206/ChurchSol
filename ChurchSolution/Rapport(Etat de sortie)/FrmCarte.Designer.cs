namespace ChurchSolution.Rapport_Etat_de_sortie_
{
    partial class FrmCarte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarte));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.rech = new System.Windows.Forms.TextBox();
            this.btnsuite = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(290, 5);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(685, 522);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.rech);
            this.panel1.Controls.Add(this.btnsuite);
            this.panel1.Location = new System.Drawing.Point(1, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 522);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(10, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(42, 17);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 754;
            this.pictureBox5.TabStop = false;
            // 
            // rech
            // 
            this.rech.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rech.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.rech.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.rech.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rech.ForeColor = System.Drawing.Color.DimGray;
            this.rech.Location = new System.Drawing.Point(7, 3);
            this.rech.Name = "rech";
            this.rech.Size = new System.Drawing.Size(272, 22);
            this.rech.TabIndex = 755;
            this.rech.Text = "Rechercher le nom";
            this.rech.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rech.Enter += new System.EventHandler(this.rech_Enter);
            this.rech.Leave += new System.EventHandler(this.rech_Leave);
            // 
            // btnsuite
            // 
            this.btnsuite.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(193)))));
            this.btnsuite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(193)))));
            this.btnsuite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsuite.BorderRadius = 1;
            this.btnsuite.ButtonText = "Imprimer une carte";
            this.btnsuite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsuite.DisabledColor = System.Drawing.Color.Gray;
            this.btnsuite.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuite.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsuite.Iconimage = null;
            this.btnsuite.Iconimage_right = null;
            this.btnsuite.Iconimage_right_Selected = null;
            this.btnsuite.Iconimage_Selected = null;
            this.btnsuite.IconMarginLeft = 0;
            this.btnsuite.IconMarginRight = 0;
            this.btnsuite.IconRightVisible = true;
            this.btnsuite.IconRightZoom = 0D;
            this.btnsuite.IconVisible = true;
            this.btnsuite.IconZoom = 90D;
            this.btnsuite.IsTab = false;
            this.btnsuite.Location = new System.Drawing.Point(7, 49);
            this.btnsuite.Margin = new System.Windows.Forms.Padding(4);
            this.btnsuite.Name = "btnsuite";
            this.btnsuite.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(193)))));
            this.btnsuite.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.btnsuite.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsuite.selected = false;
            this.btnsuite.Size = new System.Drawing.Size(272, 34);
            this.btnsuite.TabIndex = 753;
            this.btnsuite.Text = "Imprimer une carte";
            this.btnsuite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsuite.Textcolor = System.Drawing.Color.White;
            this.btnsuite.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuite.Click += new System.EventHandler(this.btnsuite_Click);
            // 
            // FrmCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCarte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCarte_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ViewRepport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnsuite;
        private System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.TextBox rech;
    }
}