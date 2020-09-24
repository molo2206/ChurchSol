namespace ChurchSolution.FormulairePrincipale.FormulaireSecondaire.FormulaireNotification
{
    partial class FrmConf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConf));
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsuite = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Gray;
            this.panel10.Location = new System.Drawing.Point(48, 84);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(329, 5);
            this.panel10.TabIndex = 769;
            // 
            // txtpwd
            // 
            this.txtpwd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtpwd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtpwd.BackColor = System.Drawing.Color.White;
            this.txtpwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpwd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpwd.ForeColor = System.Drawing.Color.Silver;
            this.txtpwd.Location = new System.Drawing.Point(48, 57);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(329, 26);
            this.txtpwd.TabIndex = 770;
            this.txtpwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpwd.UseSystemPasswordChar = true;
            this.txtpwd.TextChanged += new System.EventHandler(this.txtpwd_TextChanged);
            this.txtpwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpwd_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(406, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 771;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(163, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 773;
            this.label1.Text = "Mot de passe";
            // 
            // btnsuite
            // 
            this.btnsuite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.btnsuite.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(193)))));
            this.btnsuite.FlatAppearance.BorderSize = 0;
            this.btnsuite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.btnsuite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.btnsuite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuite.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuite.ForeColor = System.Drawing.Color.White;
            this.btnsuite.Location = new System.Drawing.Point(163, 96);
            this.btnsuite.Name = "btnsuite";
            this.btnsuite.Size = new System.Drawing.Size(98, 32);
            this.btnsuite.TabIndex = 774;
            this.btnsuite.Text = "Connecter";
            this.btnsuite.UseVisualStyleBackColor = false;
            this.btnsuite.Click += new System.EventHandler(this.btnsuite_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FrmConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(441, 130);
            this.Controls.Add(this.btnsuite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.txtpwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConf";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel10;
        public System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsuite;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}