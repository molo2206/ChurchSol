namespace ChurchSolution.FormulairePrincipale.FormulaireSecondaire
{
    partial class FrmMinistere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMinistere));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.rech = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsuite = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtidenti = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtministere = new iTalk.iTalk_RichTextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(118, 24);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 17);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // rech
            // 
            this.rech.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rech.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.rech.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.rech.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rech.ForeColor = System.Drawing.Color.DimGray;
            this.rech.Location = new System.Drawing.Point(116, 21);
            this.rech.Name = "rech";
            this.rech.Size = new System.Drawing.Size(270, 22);
            this.rech.TabIndex = 47;
            this.rech.Text = "Rechercher";
            this.rech.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rech.TextChanged += new System.EventHandler(this.rech_TextChanged);
            this.rech.Enter += new System.EventHandler(this.rech_Enter);
            this.rech.Leave += new System.EventHandler(this.rech_Leave);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(45, 14);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(65, 17);
            this.bunifuCustomLabel9.TabIndex = 23;
            this.bunifuCustomLabel9.Text = "Numéro :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnsuite
            // 
            this.btnsuite.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.btnsuite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.btnsuite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsuite.BorderRadius = 1;
            this.btnsuite.ButtonText = "Enregistrer";
            this.btnsuite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsuite.DisabledColor = System.Drawing.Color.Gray;
            this.btnsuite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnsuite.Location = new System.Drawing.Point(99, 145);
            this.btnsuite.Margin = new System.Windows.Forms.Padding(4);
            this.btnsuite.Name = "btnsuite";
            this.btnsuite.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.btnsuite.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.btnsuite.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsuite.selected = false;
            this.btnsuite.Size = new System.Drawing.Size(287, 34);
            this.btnsuite.TabIndex = 762;
            this.btnsuite.Text = "Enregistrer";
            this.btnsuite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsuite.Textcolor = System.Drawing.Color.White;
            this.btnsuite.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuite.Click += new System.EventHandler(this.btnsuite_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.txtidenti);
            this.panel1.Controls.Add(this.rech);
            this.panel1.Controls.Add(this.bunifuCustomLabel9);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 54);
            this.panel1.TabIndex = 759;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtidenti
            // 
            this.txtidenti.AutoSize = true;
            this.txtidenti.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidenti.ForeColor = System.Drawing.Color.White;
            this.txtidenti.Location = new System.Drawing.Point(45, 31);
            this.txtidenti.Name = "txtidenti";
            this.txtidenti.Size = new System.Drawing.Size(0, 20);
            this.txtidenti.TabIndex = 757;
            // 
            // txtministere
            // 
            this.txtministere.AutoWordSelection = false;
            this.txtministere.BackColor = System.Drawing.Color.Transparent;
            this.txtministere.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtministere.ForeColor = System.Drawing.Color.DimGray;
            this.txtministere.Location = new System.Drawing.Point(99, 108);
            this.txtministere.Name = "txtministere";
            this.txtministere.ReadOnly = false;
            this.txtministere.Size = new System.Drawing.Size(287, 30);
            this.txtministere.TabIndex = 761;
            this.txtministere.WordWrap = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(37, 115);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(56, 15);
            this.bunifuCustomLabel1.TabIndex = 760;
            this.bunifuCustomLabel1.Text = "Ministere";
            // 
            // FrmMinistere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 226);
            this.Controls.Add(this.btnsuite);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtministere);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMinistere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMinistere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox rech;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnsuite;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel txtidenti;
        private iTalk.iTalk_RichTextBox txtministere;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}