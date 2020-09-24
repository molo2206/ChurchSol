namespace ChurchSolution.FormulairePrincipale
{
    partial class AjouterCompte
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterCompte));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsuite = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txtnume = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtcompte = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtclasse = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Designation du compte";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(12, 44);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(411, 56);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(43, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nouveau Compte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numéro du compte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "La classe du compte";
            // 
            // btnsuite
            // 
            this.btnsuite.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.btnsuite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.btnsuite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsuite.BorderRadius = 4;
            this.btnsuite.ButtonText = "Enregistrer";
            this.btnsuite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsuite.DisabledColor = System.Drawing.Color.Gray;
            this.btnsuite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnsuite.Location = new System.Drawing.Point(36, 360);
            this.btnsuite.Margin = new System.Windows.Forms.Padding(4);
            this.btnsuite.Name = "btnsuite";
            this.btnsuite.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.btnsuite.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.btnsuite.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsuite.selected = false;
            this.btnsuite.Size = new System.Drawing.Size(149, 25);
            this.btnsuite.TabIndex = 755;
            this.btnsuite.Text = "Enregistrer";
            this.btnsuite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsuite.Textcolor = System.Drawing.Color.White;
            this.btnsuite.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuite.Click += new System.EventHandler(this.btnsuite_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 4;
            this.bunifuFlatButton1.ButtonText = "Annuler";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(255, 360);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(149, 25);
            this.bunifuFlatButton1.TabIndex = 756;
            this.bunifuFlatButton1.Text = "Annuler";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(403, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // txtnume
            // 
            this.txtnume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txtnume.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnume.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnume.HintForeColor = System.Drawing.Color.Empty;
            this.txtnume.HintText = "";
            this.txtnume.isPassword = false;
            this.txtnume.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnume.LineIdleColor = System.Drawing.Color.Gray;
            this.txtnume.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnume.LineThickness = 4;
            this.txtnume.Location = new System.Drawing.Point(36, 226);
            this.txtnume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnume.Name = "txtnume";
            this.txtnume.Size = new System.Drawing.Size(369, 30);
            this.txtnume.TabIndex = 766;
            this.txtnume.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtcompte
            // 
            this.txtcompte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txtcompte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcompte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcompte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcompte.HintForeColor = System.Drawing.Color.Empty;
            this.txtcompte.HintText = "";
            this.txtcompte.isPassword = false;
            this.txtcompte.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcompte.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcompte.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcompte.LineThickness = 4;
            this.txtcompte.Location = new System.Drawing.Point(36, 161);
            this.txtcompte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcompte.Name = "txtcompte";
            this.txtcompte.Size = new System.Drawing.Size(369, 30);
            this.txtcompte.TabIndex = 767;
            this.txtcompte.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtclasse
            // 
            this.txtclasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txtclasse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtclasse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtclasse.HintForeColor = System.Drawing.Color.Empty;
            this.txtclasse.HintText = "";
            this.txtclasse.isPassword = false;
            this.txtclasse.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtclasse.LineIdleColor = System.Drawing.Color.Gray;
            this.txtclasse.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtclasse.LineThickness = 4;
            this.txtclasse.Location = new System.Drawing.Point(35, 283);
            this.txtclasse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtclasse.Name = "txtclasse";
            this.txtclasse.Size = new System.Drawing.Size(369, 30);
            this.txtclasse.TabIndex = 768;
            this.txtclasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AjouterCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 631);
            this.Controls.Add(this.txtclasse);
            this.Controls.Add(this.txtcompte);
            this.Controls.Add(this.txtnume);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.btnsuite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjouterCompte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjouterCompte";
            this.Load += new System.EventHandler(this.AjouterCompte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton btnsuite;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtclasse;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtcompte;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtnume;
    }
}