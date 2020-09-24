namespace ChurchSolution.Rapport_Etat_de_sortie_
{
    partial class FrmCarteServit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarteServit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.rech = new System.Windows.Forms.TextBox();
            this.btnsuite = new Bunifu.Framework.UI.BunifuFlatButton();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtcellule = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.txtcellule);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.rech);
            this.panel1.Controls.Add(this.btnsuite);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 522);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(9, 161);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 17);
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
            this.rech.Location = new System.Drawing.Point(7, 158);
            this.rech.Name = "rech";
            this.rech.Size = new System.Drawing.Size(253, 22);
            this.rech.TabIndex = 755;
            this.rech.Text = "Rechercher le nom";
            this.rech.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rech.TextChanged += new System.EventHandler(this.rech_TextChanged);
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
            this.btnsuite.Location = new System.Drawing.Point(7, 187);
            this.btnsuite.Margin = new System.Windows.Forms.Padding(4);
            this.btnsuite.Name = "btnsuite";
            this.btnsuite.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(193)))));
            this.btnsuite.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.btnsuite.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsuite.selected = false;
            this.btnsuite.Size = new System.Drawing.Size(253, 34);
            this.btnsuite.TabIndex = 753;
            this.btnsuite.Text = "Imprimer une carte";
            this.btnsuite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsuite.Textcolor = System.Drawing.Color.White;
            this.btnsuite.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuite.Click += new System.EventHandler(this.btnsuite_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(271, 3);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(704, 522);
            this.crystalReportViewer1.TabIndex = 2;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 758;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(65, 16);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(164, 52);
            this.bunifuCustomLabel2.TabIndex = 757;
            this.bunifuCustomLabel2.Text = "cette impression nécessite \r\nla sélection du cellule .Avec \r\ncomme objectif de li" +
    "er chaque \r\nserviteur à son cellule.";
            // 
            // txtcellule
            // 
            this.txtcellule.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtcellule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtcellule.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcellule.FormattingEnabled = true;
            this.txtcellule.Location = new System.Drawing.Point(7, 83);
            this.txtcellule.Name = "txtcellule";
            this.txtcellule.Size = new System.Drawing.Size(253, 25);
            this.txtcellule.TabIndex = 756;
            this.txtcellule.SelectedIndexChanged += new System.EventHandler(this.txtcellule_SelectedIndexChanged_1);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 128);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(188, 26);
            this.bunifuCustomLabel1.TabIndex = 759;
            this.bunifuCustomLabel1.Text = "Faite une recherche de la personne\r\nconcerné avant d\'imprimer la carte.";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.DimGray;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(7, 114);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(253, 10);
            this.bunifuSeparator1.TabIndex = 760;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // FrmCarteServit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCarteServit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCarteServit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.TextBox rech;
        private Bunifu.Framework.UI.BunifuFlatButton btnsuite;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox txtcellule;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}