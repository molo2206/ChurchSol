namespace ChurchSolution.FormulairePrincipale
{
    partial class ListePresence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListePresence));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.date = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.absent = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.present = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.total = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtdate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Listemembre = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.reche = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Listemembre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.Color.White;
            this.date.BorderRadius = 0;
            this.date.ForeColor = System.Drawing.Color.DimGray;
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.FormatCustom = null;
            this.date.Location = new System.Drawing.Point(772, 21);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(40, 36);
            this.date.TabIndex = 16;
            this.date.Value = new System.DateTime(2020, 5, 18, 13, 21, 19, 389);
            this.date.onValueChanged += new System.EventHandler(this.bunifuDatepicker1_onValueChanged);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(193)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(193)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 1;
            this.bunifuFlatButton2.ButtonText = "Imprimer liste de présence";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(579, 20);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(193)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(186, 37);
            this.bunifuFlatButton2.TabIndex = 769;
            this.bunifuFlatButton2.Text = "Imprimer liste de présence";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // absent
            // 
            this.absent.AutoSize = true;
            this.absent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(89)))), ((int)(((byte)(132)))));
            this.absent.Location = new System.Drawing.Point(546, 33);
            this.absent.Name = "absent";
            this.absent.Size = new System.Drawing.Size(18, 20);
            this.absent.TabIndex = 778;
            this.absent.Text = "0";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(89)))), ((int)(((byte)(132)))));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(492, 13);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(59, 15);
            this.bunifuCustomLabel12.TabIndex = 776;
            this.bunifuCustomLabel12.Text = "Absent(s)";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(505, 26);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 777;
            this.pictureBox4.TabStop = false;
            // 
            // present
            // 
            this.present.AutoSize = true;
            this.present.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.present.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(89)))), ((int)(((byte)(132)))));
            this.present.Location = new System.Drawing.Point(456, 33);
            this.present.Name = "present";
            this.present.Size = new System.Drawing.Size(18, 20);
            this.present.TabIndex = 775;
            this.present.Text = "0";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(89)))), ((int)(((byte)(132)))));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(395, 13);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(63, 15);
            this.bunifuCustomLabel11.TabIndex = 773;
            this.bunifuCustomLabel11.Text = "Présent(s)";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(410, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 774;
            this.pictureBox3.TabStop = false;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(89)))), ((int)(((byte)(132)))));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(292, 14);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(76, 15);
            this.bunifuCustomLabel10.TabIndex = 770;
            this.bunifuCustomLabel10.Text = "Total Agents";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(89)))), ((int)(((byte)(132)))));
            this.total.Location = new System.Drawing.Point(350, 34);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(18, 20);
            this.total.TabIndex = 772;
            this.total.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(310, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 771;
            this.pictureBox1.TabStop = false;
            // 
            // txtdate
            // 
            this.txtdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtdate.HintForeColor = System.Drawing.Color.Empty;
            this.txtdate.HintText = "";
            this.txtdate.isPassword = false;
            this.txtdate.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtdate.LineIdleColor = System.Drawing.Color.Gray;
            this.txtdate.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtdate.LineThickness = 3;
            this.txtdate.Location = new System.Drawing.Point(819, 22);
            this.txtdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(83, 33);
            this.txtdate.TabIndex = 779;
            this.txtdate.Text = "Date";
            this.txtdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtdate.OnValueChanged += new System.EventHandler(this.txtdate_OnValueChanged);
            // 
            // Listemembre
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            this.Listemembre.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Listemembre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Listemembre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Listemembre.BackgroundColor = System.Drawing.Color.White;
            this.Listemembre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Listemembre.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.Listemembre.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Listemembre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Listemembre.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Listemembre.DefaultCellStyle = dataGridViewCellStyle3;
            this.Listemembre.DoubleBuffered = true;
            this.Listemembre.EnableHeadersVisualStyles = false;
            this.Listemembre.GridColor = System.Drawing.Color.White;
            this.Listemembre.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.Listemembre.HeaderForeColor = System.Drawing.Color.White;
            this.Listemembre.Location = new System.Drawing.Point(12, 74);
            this.Listemembre.Name = "Listemembre";
            this.Listemembre.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Listemembre.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Listemembre.RowHeadersVisible = false;
            this.Listemembre.RowHeadersWidth = 40;
            this.Listemembre.RowTemplate.Height = 40;
            this.Listemembre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Listemembre.Size = new System.Drawing.Size(1116, 401);
            this.Listemembre.StandardTab = true;
            this.Listemembre.TabIndex = 783;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(12, 33);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 17);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 785;
            this.pictureBox5.TabStop = false;
            // 
            // reche
            // 
            this.reche.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.reche.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.reche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reche.ForeColor = System.Drawing.Color.DimGray;
            this.reche.Location = new System.Drawing.Point(9, 31);
            this.reche.Name = "reche";
            this.reche.Size = new System.Drawing.Size(260, 22);
            this.reche.TabIndex = 786;
            this.reche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reche.TextChanged += new System.EventHandler(this.reche_TextChanged);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Location = new System.Drawing.Point(9, 64);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1119, 3);
            this.panel5.TabIndex = 787;
            // 
            // ListePresence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1133, 487);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.reche);
            this.Controls.Add(this.Listemembre);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.absent);
            this.Controls.Add(this.bunifuCustomLabel12);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.present);
            this.Controls.Add(this.bunifuCustomLabel11);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.total);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.date);
            this.Name = "ListePresence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListePresence";
            this.Load += new System.EventHandler(this.ListePresence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Listemembre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDatepicker date;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuCustomLabel absent;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuCustomLabel present;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel total;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtdate;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Listemembre;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox reche;
        private System.Windows.Forms.Panel panel5;
    }
}