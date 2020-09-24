namespace ChurchSolution.FormulairePrincipale.FormulaireSecondaire
{
    partial class FrmCompte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompte));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.reche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsuite = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Listebapteme = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Listebapteme)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.panel1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(89, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 47);
            this.panel1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(444, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 13);
            this.label9.TabIndex = 786;
            this.label9.Text = "Rechercher une Opération";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.reche);
            this.panel2.Location = new System.Drawing.Point(444, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 25);
            this.panel2.TabIndex = 755;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(2, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(18, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 786;
            this.pictureBox5.TabStop = false;
            // 
            // reche
            // 
            this.reche.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.reche.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.reche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reche.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reche.ForeColor = System.Drawing.Color.DimGray;
            this.reche.Location = new System.Drawing.Point(23, 2);
            this.reche.Name = "reche";
            this.reche.Size = new System.Drawing.Size(246, 20);
            this.reche.TabIndex = 785;
            this.reche.TextChanged += new System.EventHandler(this.reche_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 784;
            this.label1.Text = "En cours :";
            // 
            // btnsuite
            // 
            this.btnsuite.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.btnsuite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.btnsuite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsuite.BorderRadius = 4;
            this.btnsuite.ButtonText = "Ajouter";
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
            this.btnsuite.Location = new System.Drawing.Point(7, 17);
            this.btnsuite.Margin = new System.Windows.Forms.Padding(4);
            this.btnsuite.Name = "btnsuite";
            this.btnsuite.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.btnsuite.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.btnsuite.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsuite.selected = false;
            this.btnsuite.Size = new System.Drawing.Size(58, 28);
            this.btnsuite.TabIndex = 754;
            this.btnsuite.Text = "Ajouter";
            this.btnsuite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsuite.Textcolor = System.Drawing.Color.White;
            this.btnsuite.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuite.Click += new System.EventHandler(this.btnsuite_Click);
            // 
            // Listebapteme
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            this.Listebapteme.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Listebapteme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Listebapteme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Listebapteme.BackgroundColor = System.Drawing.Color.White;
            this.Listebapteme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Listebapteme.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.Listebapteme.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Listebapteme.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Listebapteme.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Listebapteme.DefaultCellStyle = dataGridViewCellStyle3;
            this.Listebapteme.DoubleBuffered = true;
            this.Listebapteme.EnableHeadersVisualStyles = false;
            this.Listebapteme.GridColor = System.Drawing.Color.White;
            this.Listebapteme.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.Listebapteme.HeaderForeColor = System.Drawing.Color.White;
            this.Listebapteme.Location = new System.Drawing.Point(89, 65);
            this.Listebapteme.Name = "Listebapteme";
            this.Listebapteme.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Listebapteme.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Listebapteme.RowHeadersVisible = false;
            this.Listebapteme.RowHeadersWidth = 40;
            this.Listebapteme.RowTemplate.Height = 40;
            this.Listebapteme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Listebapteme.Size = new System.Drawing.Size(721, 429);
            this.Listebapteme.StandardTab = true;
            this.Listebapteme.TabIndex = 794;
            this.Listebapteme.Click += new System.EventHandler(this.Listebapteme_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.bunifuFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 7;
            this.bunifuFlatButton1.ButtonText = "Actualiser";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(816, 17);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(58, 28);
            this.bunifuFlatButton1.TabIndex = 846;
            this.bunifuFlatButton1.Text = "Actualiser";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // FrmCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 506);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.Listebapteme);
            this.Controls.Add(this.btnsuite);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCompte";
            this.Text = "FrmCompte";
            this.Load += new System.EventHandler(this.FrmCompte_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Listebapteme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox reche;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuFlatButton btnsuite;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Listebapteme;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}