using ChurchSolution.AutresRapport;
using ChurchSolution.ClasseFonction;
using ChurchSolution.ClassePrincipale;
using ChurchSolution.ClasseTraitement;
using ChurchSolution.Rapport_Etat_de_sortie_;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChurchSolution.FormulairePrincipale.FormulaireSecondaire
{
    public partial class FrmCulte : Form
    {
        public FrmCulte()
        {
            InitializeComponent();
        }

        ClsRapports clr = new ClsRapports();
        ClsDAO dao = new ClsDAO();
        Clsfonctions fx = new Clsfonctions();
        Culte cl = new Culte();
        ClsServiteurInsertion cls = new ClsServiteurInsertion();
        ClsPredicateur cp = new ClsPredicateur();

        private void label1_Click(object sender, EventArgs e)
        {
            FrmPreducateur fr = new FrmPreducateur();
            fr.ShowDialog();
        }

        private void btnsuite_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Etes vous sûr de continuer avec ces même heures?", "Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr.Equals(DialogResult.Yes))
            {
                try
                {
                    if (txttitre.Text == "" || txtperdi.Text == "Prédicateur" || txtmodera.Text == "Modérateur " || txtdate.Text == "" || txtdate1.Text == "" || txtdebut.Text == "" || txtfin.Text == "" || txtcellule.Text=="")
                    {
                        fx.Messages(2);
                    }
                    else
                    {
                        cl.Code_culte = txtcode.Text;
                        cl.Titre = txttitre.Text.ToUpper();
                        cl.Nom_preducateur = codepredicateur;
                        cl.Nom_moderateur = codemoderateur;
                        cl.Heure_debut = txtdebut.Text;
                        cl.Heure_fin = txtfin.Text;
                        cl.Date_debut = txtdate.Text;
                        cl.Date_fin = txtdate1.Text;
                        string rqt = "exec OPERATIONCULTE '" + cl.Titre + "','" + cl.Nom_moderateur + "','" + cl.Nom_preducateur + "','" + cl.Heure_debut + "','" + cl.Heure_fin + "','" + txtdate.Text + "','" + txtdate1.Text + "','" + cl.Code_culte + "','"+cl.Cellule+"'";
                        dao.Executer(rqt);
                        if (txtcode.Text=="")
                        {
                            Message();
                        }
                        dao.chargementGridOptimise("select * from V_CULTE ", Listebapteme);
                        txtcode.Text = "";
                        txtdate.Text = "";
                        txtdate1.Text = "";
                        txtperdi.Text = "Prédicateur";
                        txtmodera.Text = "Modérateur";

                    }

                }
                catch (Exception EX)
                {

                }
            }
          
        }


        private void FrmCulte_Load(object sender, EventArgs e)
        {
            //for (int i=1;i<24;i++)
            //{
            //    comboBox1.Items.Add(i);
            //}
            //for (int i = 1; i < 60; i++)
            //{
            //    comboBox2.Items.Add(i);
            //}

            //for (int i = 1; i < 24; i++)
            //{
            //    comboBox3.Items.Add(i);
            //}
            //for (int i = 1; i < 60; i++)
            //{
            //    comboBox4.Items.Add(i);
            //}
            dao.chargementGridOptimise("select Code, Predicateur, Moderateur, Cellule, Culte, Date_debut, Date_fin, DEBUT as Heure_debut, FIN as Heure_fin,Date_culte from V_CULTE", Listebapteme);
            dao.Autocomplete("select nom_complet from preducateur", "nom_complet", txtperdi);
            dao.Autocomplete("select nom_complet from moderatuer","nom_complet",txtmodera);
            dao.chargerCombo("select nom_cellule from cellule","nom_cellule",txtcellule);
            string heure = DateTime.Now.Hour.ToString();
            string min = DateTime.Now.Minute.ToString();
            string secon = DateTime.Now.Second.ToString();
            txtdebut.Text = heure +":"+ min +":"+ secon;
            txtfin.Text = heure + ":" + min + ":" + secon;
        }
        private void txttitre_Leave(object sender, EventArgs e)
        {
            if (txttitre.Text=="")
            {
                txttitre.Text = "Titre du culte";
            }
        }

        private void txttitre_Enter(object sender, EventArgs e)
        {
            if (txttitre.Text=="Titre du culte")
            {
                txttitre.Text = "";
            }
        }
        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.verifier_Numerique(e);
        }
        private void txtport_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.verifier_Numerique(e);
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            txtdates.Text = dat.Value.ToString();
            string dates = dat.Value.ToString("yyy-MM-dd");
            dao.chargementGridOptimise("select  * from V_CULTE where CONVERT(date,DATE_CULTE,103) like '%"+dates+ "%'", Listebapteme);
        }

        private void Listebapteme_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FrmModerateur fm = new FrmModerateur();
            fm.ShowDialog();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtperdi.Text == "")
            {
                txtperdi.Text = "Prédicateur";
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtperdi.Text == "Prédicateur")
            {
                txtperdi.Text = "";
            }
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            if (txtmodera.Text == "")
            {
                txtmodera.Text = "Modérateur ";
            }
        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (txtmodera.Text == "Modérateur ")
            {
                txtmodera.Text = "";
            }
        }
        string codepredicateur;
        string codemoderateur;
        private void txtperdi_TextChanged(object sender, EventArgs e)
        {
            
           
        }
        string numerophone;

        private void rech_TextChanged(object sender, EventArgs e)
        {
        }
        private void rech_Enter(object sender, EventArgs e)
        {
            //if (rech.Text=="Rechercher le nom")
            //{
            //    rech.Text = "";
            //}
        }

        private void rech_Leave(object sender, EventArgs e)
        {
        //    if (rech.Text=="")
        //    {
        //        rech.Text = "Rechercher le nom";
        //    }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        void Message()
        {
            string message = "Bonjour bien aimé,vous êtes programmé à faire la modération du culte.Bonne journée";
            try
            {
                SerialPort sp = new SerialPort();
               // sp.PortName = txtport.Text;
                sp.Open();
                sp.WriteLine("AT" + Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine("AT+CMGF=1" + Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine("AT+CSCS=\"GSM\"" + Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine("AT+CMGS=\"" + numerophone + "\"" + Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine(message + Environment.NewLine);
                Thread.Sleep(100);
                sp.Write(new byte[] { 26 }, 0, 1);
                Thread.Sleep(100);
                var response = sp.ReadExisting();
                if (response.Contains("ERROR"))
                    MessageBox.Show("Votre SMS n'est pas envoyé !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Votre SMS est envoyé avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sp.Close();

                sp.Close();
            }
            catch (Exception EX) { MessageBox.Show(EX.Message); }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string da1 = dates1.Value.ToString("yyyy/MM/dd");
            string da2 = dates2.Value.ToString("yyyy/MM/dd");
            if (dd.Text == "" || ddd.Text=="")
            {
                MessageBox.Show("sélectionner d'abord avant d'emprimer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                RapportCulte xtp = new RapportCulte();
                xtp.DataSource = clr.GetInstance().Selection_Date(da1,da2);
                ReportPrintTool printTool = new ReportPrintTool(xtp);
                printTool.ShowRibbonPreview();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            FrmVisiteur rp = new FrmVisiteur();
            rp.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtdates_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtdates_Enter(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rech_TextChanged_1(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select  * from V_CULTE where PREDICATEUR like '%" + rech.Text + "%' or MODERATEUR like '%" + rech.Text + "%' or CELLULE like '%" + rech.Text + "%'", Listebapteme);
        }

        private void Listebapteme_Click(object sender, EventArgs e)
        {
            try
            {
                txtcode.Text = Listebapteme.SelectedRows[0].Cells[0].Value.ToString();
                txttitre.Text = Listebapteme.SelectedRows[0].Cells[4].Value.ToString();
                txtperdi.Text = Listebapteme.SelectedRows[0].Cells[1].Value.ToString();
                txtmodera.Text = Listebapteme.SelectedRows[0].Cells[2].Value.ToString();
                txtcellule.Text = Listebapteme.SelectedRows[0].Cells[3].Value.ToString();
                date1.Text = Listebapteme.SelectedRows[0].Cells[6].Value.ToString();
                txtdebut.Text = Listebapteme.SelectedRows[0].Cells[7].Value.ToString();
                txtfin.Text = Listebapteme.SelectedRows[0].Cells[8].Value.ToString();
                date.Text = Listebapteme.SelectedRows[0].Cells[5].Value.ToString();
                if (txtdate.Text=="" || txtdate1.Text=="")
                {
                    txtdate.Text= txtdate.Text = date.Value.ToString("yyyy/MM/dd");

                    txtdate1.Text= txtdate1.Text = date1.Value.ToString("yyyy/MM/dd");
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void date_onValueChanged_1(object sender, EventArgs e)
        {
            txtdate.Text = date.Value.ToString("yyyy/MM/dd");
        }

        private void txtperdi_TextChanged_1(object sender, EventArgs e)
        {
            codepredicateur = cp.Code_pre(txtperdi.Text);
            string code_serviteur = cls.Code_Serviteur(txtperdi.Text);
        }

        private void txtmodera_TextChanged_1(object sender, EventArgs e)
        {
            codemoderateur = cp.Code_moder(txtmodera.Text);
            numerophone = cp.Phone(txtmodera.Text);
            string code_serviteur1 = cls.Code_Serviteur(txtmodera.Text);

        }

        private void txtcellule_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cl.Cellule = dao.IdCombo("cellule", "code", txtcellule.Text, "nom_cellule");
        }

        private void date1_onValueChanged(object sender, EventArgs e)
        {
            txtdate1.Text = date1.Value.ToString("yyyy/MM/dd");
        }

        private void dates1_onValueChanged(object sender, EventArgs e)
        {
            dd.Text = dates1.Value.ToString();
        }

        private void dates2_onValueChanged(object sender, EventArgs e)
        {
            ddd.Text = dates2.Value.ToString();
        }
    }
}
