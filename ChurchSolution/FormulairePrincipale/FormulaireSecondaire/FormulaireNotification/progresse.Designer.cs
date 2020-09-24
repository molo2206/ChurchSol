namespace ChurchSolution.FormulairePrincipale.FormulaireSecondaire.FormulaireNotification
{
    partial class progresse
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ProgressBar1__ = new Bunifu.Framework.UI.BunifuProgressBar();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProgressBar1__
            // 
            this.ProgressBar1__.BackColor = System.Drawing.Color.Silver;
            this.ProgressBar1__.BorderRadius = 5;
            this.ProgressBar1__.Location = new System.Drawing.Point(30, 28);
            this.ProgressBar1__.Margin = new System.Windows.Forms.Padding(4);
            this.ProgressBar1__.MaximumValue = 100;
            this.ProgressBar1__.Name = "ProgressBar1__";
            this.ProgressBar1__.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(87)))));
            this.ProgressBar1__.Size = new System.Drawing.Size(414, 10);
            this.ProgressBar1__.TabIndex = 759;
            this.ProgressBar1__.Value = 0;
            // 
            // progresse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(469, 63);
            this.Controls.Add(this.ProgressBar1__);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "progresse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "progresse";
            this.Load += new System.EventHandler(this.progresse_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuProgressBar ProgressBar1__;
    }
}