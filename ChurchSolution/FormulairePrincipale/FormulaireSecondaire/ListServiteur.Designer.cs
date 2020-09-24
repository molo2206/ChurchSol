namespace ChurchSolution.FormulairePrincipale.FormulaireSecondaire
{
    partial class ListServiteur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListServiteur));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.reche = new Bunifu.Framework.UI.BunifuTextbox();
            this.Listeserviteur = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.date = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtdate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.Listeserviteur)).BeginInit();
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
            this.reche.Location = new System.Drawing.Point(12, 33);
            this.reche.Name = "reche";
            this.reche.Size = new System.Drawing.Size(273, 23);
            this.reche.TabIndex = 14;
            this.reche.text = "";
            this.reche.OnTextChange += new System.EventHandler(this.reche_OnTextChange);
            // 
            // Listeserviteur
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.DimGray;
            this.Listeserviteur.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.Listeserviteur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Listeserviteur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Listeserviteur.BackgroundColor = System.Drawing.Color.White;
            this.Listeserviteur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Listeserviteur.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.Listeserviteur.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Listeserviteur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.Listeserviteur.ColumnHeadersHeight = 30;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Listeserviteur.DefaultCellStyle = dataGridViewCellStyle11;
            this.Listeserviteur.DoubleBuffered = true;
            this.Listeserviteur.EnableHeadersVisualStyles = false;
            this.Listeserviteur.GridColor = System.Drawing.Color.White;
            this.Listeserviteur.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.Listeserviteur.HeaderForeColor = System.Drawing.Color.White;
            this.Listeserviteur.Location = new System.Drawing.Point(12, 62);
            this.Listeserviteur.Name = "Listeserviteur";
            this.Listeserviteur.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Listeserviteur.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.Listeserviteur.RowHeadersVisible = false;
            this.Listeserviteur.RowHeadersWidth = 40;
            this.Listeserviteur.RowTemplate.Height = 40;
            this.Listeserviteur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Listeserviteur.Size = new System.Drawing.Size(1029, 409);
            this.Listeserviteur.StandardTab = true;
            this.Listeserviteur.TabIndex = 784;
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date.BackColor = System.Drawing.SystemColors.Control;
            this.date.BorderRadius = 0;
            this.date.ForeColor = System.Drawing.Color.DimGray;
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.date.FormatCustom = null;
            this.date.Location = new System.Drawing.Point(792, 19);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(35, 36);
            this.date.TabIndex = 16;
            this.date.Value = new System.DateTime(2020, 5, 30, 13, 21, 0, 0);
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
            this.txtdate.Location = new System.Drawing.Point(834, 19);
            this.txtdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(88, 33);
            this.txtdate.TabIndex = 783;
            this.txtdate.Text = "Date";
            this.txtdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ListServiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1053, 483);
            this.Controls.Add(this.Listeserviteur);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.date);
            this.Controls.Add(this.reche);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListServiteur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ListServiteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Listeserviteur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTextbox reche;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Listeserviteur;
        private Bunifu.Framework.UI.BunifuDatepicker date;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtdate;
    }
}