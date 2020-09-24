namespace ChurchSolution.FormulairePrincipale.FormulaireSecondaire
{
    partial class FrmBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackup));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.stop = new System.Windows.Forms.RadioButton();
            this.start = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txttime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRestore = new iTalk.iTalk_Button_1();
            this.iTalk_Separator2 = new iTalk.iTalk_Separator();
            this.iTalk_Button_12 = new iTalk.iTalk_Button_1();
            this.txtRestoreFileLoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnbackup = new iTalk.iTalk_Button_1();
            this.iTalk_Separator1 = new iTalk.iTalk_Separator();
            this.iTalk_Button_14 = new iTalk.iTalk_Button_1();
            this.txtBackupFileloc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbDatabases = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnDiscon = new iTalk.iTalk_Button_1();
            this.btnConnect = new iTalk.iTalk_Button_1();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtDataSource = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bunifuSeparator1);
            this.groupBox1.Controls.Add(this.stop);
            this.groupBox1.Controls.Add(this.start);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(412, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 614);
            this.groupBox1.TabIndex = 559;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "B  A  C  K  U  P  B  D   A  U  T  O  M  A  T  I  Q  U  E";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(5, 75);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(397, 10);
            this.bunifuSeparator1.TabIndex = 538;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // stop
            // 
            this.stop.AutoSize = true;
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.Location = new System.Drawing.Point(251, 47);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(48, 19);
            this.stop.TabIndex = 537;
            this.stop.TabStop = true;
            this.stop.Text = "stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.CheckedChanged += new System.EventHandler(this.stop_CheckedChanged);
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(198, 47);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(48, 19);
            this.start.TabIndex = 536;
            this.start.TabStop = true;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.CheckedChanged += new System.EventHandler(this.start_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.txttime);
            this.groupBox7.Location = new System.Drawing.Point(303, 37);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(96, 34);
            this.groupBox7.TabIndex = 535;
            this.groupBox7.TabStop = false;
            // 
            // txttime
            // 
            this.txttime.AutoSize = true;
            this.txttime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttime.ForeColor = System.Drawing.Color.Black;
            this.txttime.Location = new System.Drawing.Point(15, 11);
            this.txttime.Name = "txttime";
            this.txttime.Size = new System.Drawing.Size(0, 17);
            this.txttime.TabIndex = 536;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(5, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 534;
            this.label8.Text = "Listes de backups";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 105);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(393, 498);
            this.listBox1.TabIndex = 533;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(2, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 16);
            this.label7.TabIndex = 532;
            this.label7.Text = "Demarrer le backup automatique :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Location = new System.Drawing.Point(2, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 614);
            this.groupBox2.TabIndex = 560;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "B  A  C  K  U  P  B  D  M  A  N  U  E  L";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.btnRestore);
            this.groupBox3.Controls.Add(this.iTalk_Separator2);
            this.groupBox3.Controls.Add(this.iTalk_Button_12);
            this.groupBox3.Controls.Add(this.txtRestoreFileLoc);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(15, 424);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 179);
            this.groupBox3.TabIndex = 518;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Database Restore";
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.Transparent;
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.Image = null;
            this.btnRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestore.Location = new System.Drawing.Point(68, 71);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(89, 21);
            this.btnRestore.TabIndex = 535;
            this.btnRestore.Text = "Restauré";
            this.btnRestore.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click_1);
            // 
            // iTalk_Separator2
            // 
            this.iTalk_Separator2.ForeColor = System.Drawing.Color.Black;
            this.iTalk_Separator2.Location = new System.Drawing.Point(72, 58);
            this.iTalk_Separator2.Name = "iTalk_Separator2";
            this.iTalk_Separator2.Size = new System.Drawing.Size(247, 8);
            this.iTalk_Separator2.TabIndex = 531;
            this.iTalk_Separator2.Text = "iTalk_Separator2";
            // 
            // iTalk_Button_12
            // 
            this.iTalk_Button_12.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Button_12.Image = null;
            this.iTalk_Button_12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_12.Location = new System.Drawing.Point(230, 71);
            this.iTalk_Button_12.Name = "iTalk_Button_12";
            this.iTalk_Button_12.Size = new System.Drawing.Size(89, 21);
            this.iTalk_Button_12.TabIndex = 534;
            this.iTalk_Button_12.Text = "Choisir";
            this.iTalk_Button_12.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_12.Click += new System.EventHandler(this.iTalk_Button_12_Click_1);
            // 
            // txtRestoreFileLoc
            // 
            this.txtRestoreFileLoc.BackColor = System.Drawing.SystemColors.Window;
            this.txtRestoreFileLoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRestoreFileLoc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRestoreFileLoc.ForeColor = System.Drawing.Color.Black;
            this.txtRestoreFileLoc.Location = new System.Drawing.Point(72, 43);
            this.txtRestoreFileLoc.Name = "txtRestoreFileLoc";
            this.txtRestoreFileLoc.Size = new System.Drawing.Size(247, 16);
            this.txtRestoreFileLoc.TabIndex = 530;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(69, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 523;
            this.label6.Text = "Backup Path :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnbackup);
            this.groupBox4.Controls.Add(this.iTalk_Separator1);
            this.groupBox4.Controls.Add(this.iTalk_Button_14);
            this.groupBox4.Controls.Add(this.txtBackupFileloc);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(15, 320);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(377, 100);
            this.groupBox4.TabIndex = 517;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data Base Backup";
            // 
            // btnbackup
            // 
            this.btnbackup.BackColor = System.Drawing.Color.Transparent;
            this.btnbackup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackup.Image = null;
            this.btnbackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbackup.Location = new System.Drawing.Point(72, 73);
            this.btnbackup.Name = "btnbackup";
            this.btnbackup.Size = new System.Drawing.Size(89, 21);
            this.btnbackup.TabIndex = 533;
            this.btnbackup.Text = "Backup";
            this.btnbackup.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnbackup.Click += new System.EventHandler(this.btnbackup_Click_1);
            // 
            // iTalk_Separator1
            // 
            this.iTalk_Separator1.Location = new System.Drawing.Point(72, 63);
            this.iTalk_Separator1.Name = "iTalk_Separator1";
            this.iTalk_Separator1.Size = new System.Drawing.Size(247, 8);
            this.iTalk_Separator1.TabIndex = 529;
            this.iTalk_Separator1.Text = "iTalk_Separator1";
            // 
            // iTalk_Button_14
            // 
            this.iTalk_Button_14.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Button_14.Image = null;
            this.iTalk_Button_14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_14.Location = new System.Drawing.Point(230, 73);
            this.iTalk_Button_14.Name = "iTalk_Button_14";
            this.iTalk_Button_14.Size = new System.Drawing.Size(89, 21);
            this.iTalk_Button_14.TabIndex = 532;
            this.iTalk_Button_14.Text = "Choisir";
            this.iTalk_Button_14.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_14.Click += new System.EventHandler(this.iTalk_Button_14_Click_1);
            // 
            // txtBackupFileloc
            // 
            this.txtBackupFileloc.BackColor = System.Drawing.SystemColors.Window;
            this.txtBackupFileloc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBackupFileloc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackupFileloc.ForeColor = System.Drawing.Color.Black;
            this.txtBackupFileloc.Location = new System.Drawing.Point(72, 48);
            this.txtBackupFileloc.Name = "txtBackupFileloc";
            this.txtBackupFileloc.Size = new System.Drawing.Size(247, 16);
            this.txtBackupFileloc.TabIndex = 528;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(69, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 517;
            this.label9.Text = "Localisation :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbDatabases);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(15, 236);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(377, 81);
            this.groupBox5.TabIndex = 516;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DataBase Section";
            // 
            // cmbDatabases
            // 
            this.cmbDatabases.BackColor = System.Drawing.Color.White;
            this.cmbDatabases.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDatabases.ForeColor = System.Drawing.Color.Black;
            this.cmbDatabases.FormattingEnabled = true;
            this.cmbDatabases.Location = new System.Drawing.Point(72, 47);
            this.cmbDatabases.Name = "cmbDatabases";
            this.cmbDatabases.Size = new System.Drawing.Size(247, 25);
            this.cmbDatabases.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(69, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "DataBase :";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.btnDiscon);
            this.groupBox6.Controls.Add(this.btnConnect);
            this.groupBox6.Controls.Add(this.txtUser);
            this.groupBox6.Controls.Add(this.txtDataSource);
            this.groupBox6.Controls.Add(this.txtpassword);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(15, 41);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(377, 196);
            this.groupBox6.TabIndex = 515;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Sql Autenthification";
            // 
            // btnDiscon
            // 
            this.btnDiscon.BackColor = System.Drawing.Color.Transparent;
            this.btnDiscon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscon.Image = null;
            this.btnDiscon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscon.Location = new System.Drawing.Point(230, 169);
            this.btnDiscon.Name = "btnDiscon";
            this.btnDiscon.Size = new System.Drawing.Size(89, 21);
            this.btnDiscon.TabIndex = 531;
            this.btnDiscon.Text = "Déconnecté";
            this.btnDiscon.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDiscon.Click += new System.EventHandler(this.btnDiscon_Click_1);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Transparent;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Image = null;
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnect.Location = new System.Drawing.Point(72, 169);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(89, 21);
            this.btnConnect.TabIndex = 530;
            this.btnConnect.Text = "Connecté";
            this.btnConnect.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click_1);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.Location = new System.Drawing.Point(72, 91);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(247, 23);
            this.txtUser.TabIndex = 529;
            this.txtUser.Text = "SA";
            // 
            // txtDataSource
            // 
            this.txtDataSource.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataSource.ForeColor = System.Drawing.Color.Black;
            this.txtDataSource.Location = new System.Drawing.Point(72, 43);
            this.txtDataSource.Name = "txtDataSource";
            this.txtDataSource.Size = new System.Drawing.Size(247, 23);
            this.txtDataSource.TabIndex = 528;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.Black;
            this.txtpassword.Location = new System.Drawing.Point(72, 140);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(247, 22);
            this.txtpassword.TabIndex = 527;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(69, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mot de passe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(69, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Utilisateur :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(69, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nom du serveur :";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 638);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmBackup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private iTalk.iTalk_Button_1 btnRestore;
        private iTalk.iTalk_Separator iTalk_Separator2;
        private iTalk.iTalk_Button_1 iTalk_Button_12;
        private System.Windows.Forms.TextBox txtRestoreFileLoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private iTalk.iTalk_Button_1 btnbackup;
        private iTalk.iTalk_Separator iTalk_Separator1;
        private iTalk.iTalk_Button_1 iTalk_Button_14;
        private System.Windows.Forms.TextBox txtBackupFileloc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbDatabases;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox6;
        private iTalk.iTalk_Button_1 btnDiscon;
        private iTalk.iTalk_Button_1 btnConnect;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtDataSource;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label txttime;
        private System.Windows.Forms.RadioButton start;
        private System.Windows.Forms.RadioButton stop;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}