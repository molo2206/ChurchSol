using ChurchSolution.ClasseFonction;
using ChurchSolution.ClassePrincipale;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChurchSolution.FormulairePrincipale.FormulaireSecondaire
{
    public partial class Presence : Form
    {
        public Presence()
        {
            InitializeComponent();
            this.ActiveControl = barcode;
            barcode.Focus();
        }

        Clsfonctions fx = new Clsfonctions();
        ClsDAO dao = new ClsDAO();
        ClsMembre cm = new ClsMembre();
        private void Presence_Load(object sender, EventArgs e)
        {
            fx.Picture_Rond(photo);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            heure.Text = dt.ToString("hh:mm:ss");

            DateTime dts = DateTime.Now;
            date.Text = dt.ToString("dd/MM/yyyy");
        }

        private void barcode_TextChanged(object sender, EventArgs e)
        {
            string heure_arrive = DateTime.Now.ToString("hh:mm:ss"); 
            if (barcode.TextLength == 8)
            {
                try
                {
                    string rqt = " exec AJOUT_PRESENCE '" + barcode.Text + "'";
                    dao.Execute(rqt);
                    txtcode.Text = (dao.BarcodeCode(barcode.Text));
                    if (txtcode.Text != "")
                    {
                        txtretour.Text = txtcode.Text;
                        txtnom.Text = dao.Barcode(txtcode.Text);
                        dao.Photo("Agent", txtcode.Text, photo);
                        fonction.Text=dao.Fonction(txtcode.Text);
                        barcode.Text = "";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur");
                }

            }
        }
    }
}
