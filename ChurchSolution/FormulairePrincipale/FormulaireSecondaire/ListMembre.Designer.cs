namespace ChurchSolution.FormulaireSecondaire
{
    partial class ListMembre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListMembre));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.reche = new Bunifu.Framework.UI.BunifuTextbox();
            this.date = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtdate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Listemembre = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.Listemembre)).BeginInit();
            this.SuspendLayout();
            // 
            // reche
            // 
            this.reche.BackColor = System.Drawing.Color.White;
            this.reche.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reche.BackgroundImage")));
            this.reche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reche.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reche.ForeColor = System.Drawing.Color.Silver;
            this.reche.Icon = ((System.Drawing.Image)(resources.GetObject("reche.Icon")));
            this.reche.Location = new System.Drawing.Point(12, 49);
            this.reche.Name = "reche";
            this.reche.Size = new System.Drawing.Size(273, 23);
            this.reche.TabIndex = 4;
            this.reche.text = "";
            this.reche.OnTextChange += new System.EventHandler(this.reche_OnTextChange);
            this.reche.Enter += new System.EventHandler(this.reche_Enter);
            this.reche.Leave += new System.EventHandler(this.reche_Leave);
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date.BackColor = System.Drawing.SystemColors.Control;
            this.date.BorderRadius = 0;
            this.date.ForeColor = System.Drawing.Color.DimGray;
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date.FormatCustom = null;
            this.date.Location = new System.Drawing.Point(608, 35);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(36, 36);
            this.date.TabIndex = 12;
            this.date.Value = new System.DateTime(2020, 5, 18, 13, 21, 19, 389);
            this.date.onValueChanged += new System.EventHandler(this.date_onValueChanged);
            // 
            // txtdate
            // 
            this.txtdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.txtdate.Location = new System.Drawing.Point(651, 38);
            this.txtdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(107, 33);
            this.txtdate.TabIndex = 782;
            this.txtdate.Text = "Date";
            this.txtdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Listemembre
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            this.Listemembre.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Listemembre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Listemembre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Listemembre.BackgroundColor = System.Drawing.Color.White;
            this.Listemembre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Listemembre.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.Listemembre.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Listemembre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Listemembre.ColumnHeadersHeight = 30;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Listemembre.DefaultCellStyle = dataGridViewCellStyle7;
            this.Listemembre.DoubleBuffered = true;
            this.Listemembre.EnableHeadersVisualStyles = false;
            this.Listemembre.GridColor = System.Drawing.Color.White;
            this.Listemembre.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.Listemembre.HeaderForeColor = System.Drawing.Color.White;
            this.Listemembre.Location = new System.Drawing.Point(12, 75);
            this.Listemembre.Name = "Listemembre";
            this.Listemembre.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Listemembre.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Listemembre.RowHeadersVisible = false;
            this.Listemembre.RowHeadersWidth = 40;
            this.Listemembre.RowTemplate.Height = 40;
            this.Listemembre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Listemembre.Size = new System.Drawing.Size(1029, 404);
            this.Listemembre.StandardTab = true;
            this.Listemembre.TabIndex = 783;
            // 
            // ListMembre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1053, 483);
            this.Controls.Add(this.Listemembre);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.date);
            this.Controls.Add(this.reche);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListMembre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ListMembre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Listemembre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTextbox reche;
        private Bunifu.Framework.UI.BunifuDatepicker date;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtdate;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Listemembre;
    }
}