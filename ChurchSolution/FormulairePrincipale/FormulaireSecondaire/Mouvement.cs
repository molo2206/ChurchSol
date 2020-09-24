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
    public partial class Mouvement : Form
    {
        public Mouvement()
        {
            InitializeComponent();
            this.ActiveControl = barcode;
            barcode.Focus();
        }
        Clsfonctions fx = new Clsfonctions();
        ClsDAO dao = new ClsDAO();
        ClsMembre cm = new ClsMembre();
        private void Mouvement_Load(object sender, EventArgs e)
        {
            fx.Picture_Rond(photo);
            panelMessage.Visible = false;
            dao.chargementGridOptimise("select * from V_mouvement order by nom",Listemouve);
        }

        string motif;
        private void barcode_TextChanged(object sender, EventArgs e)
        {
            if (txtmotif.Text.Equals("Saisisser votre motif"))
            {
                txtmotif.Text = "non justifié";
            }
            else
            {
                if (barcode.TextLength == 8)
                {
                    try
                    {
                        string rqt = " exec AjoutMouvement '" + barcode.Text + "','" + txtmotif.Text + "'";
                        dao.Execute(rqt);
                        txtcode.Text = (dao.BarcodeCode(barcode.Text));

                        if (txtcode.Text != "")
                        {
                            txtretour.Text = txtcode.Text;
                            string nom = dao.Barcode(txtcode.Text);
                            dao.Photo("Agent", txtcode.Text, photo);
                            string chaine_motif_sortie;
                            string avec = "avec comme motif";
                            string sortimotif = dao.Motif(txtcode.Text);
                            string retour = dao.ReturnMouvement(nom);
                            if (nom == retour)
                            {
                                chaine_motif_sortie = "La sortie de";
                                motif = " " + chaine_motif_sortie + " " + nom + " " + avec + " " + sortimotif + "";
                            }
                            else
                            {
                                string chaine_motif_retour = "Le retour de";
                                motif = " " + chaine_motif_retour + " " + nom + " " + avec + " " + sortimotif + "";
                            }
                            label2.Text = motif;
                            barcode.Text = "";
                            panelMessage.Visible = true;
                            dao.chargementGridOptimise("select * from V_mouvement order by nom", Listemouve);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur");
                    }
                }
            }
           
           
        }
 
        private void rech_TextChanged(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select * from V_mouvement where nom like '%"+rech.Text+"%'", Listemouve);
        }

        private void txtmotif_Enter(object sender, EventArgs e)
        {
            if (txtmotif.Text== "Motif de sorti")
            {
                txtmotif.Text = "";
            }
        }

        private void txtmotif_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtmotif_Leave_1(object sender, EventArgs e)
        {
            if (txtmotif.Text == "")
            {
                txtmotif.Text = "Saisisser votre motif";
            }
        }

        private void txtmotif_Enter_1(object sender, EventArgs e)
        {

            if (txtmotif.Text == "Saisisser votre motif")
            {
                txtmotif.Text = "";
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
