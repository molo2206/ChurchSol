namespace ChurchSolution.FormulairePrincipale.FormulaireSecondaire
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panellogin = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SuspendLayout();
            // 
            // panellogin
            // 
            this.panellogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panellogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.panellogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panellogin.BackgroundImage")));
            this.panellogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panellogin.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.panellogin.GradientBottomRight = System.Drawing.Color.White;
            this.panellogin.GradientTopLeft = System.Drawing.Color.White;
            this.panellogin.GradientTopRight = System.Drawing.Color.White;
            this.panellogin.Location = new System.Drawing.Point(1, 1);
            this.panellogin.Name = "panellogin";
            this.panellogin.Quality = 10;
            this.panellogin.Size = new System.Drawing.Size(713, 334);
            this.panellogin.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 338);
            this.Controls.Add(this.panellogin);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel panellogin;
    }
}