using ChurchSolution.ClasseFonction;
using ChurchSolution.ClassePrincipale;
using ChurchSolution.FormulairePrincipale.FormulaireSecondaire.FormulaireNotification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChurchSolution.FormulairePrincipale
{
    public partial class DashBord : Form
    {
        public DashBord()
        {
            InitializeComponent();
        }

        Clsfonctions fx = new Clsfonctions();
        ClsDAO dao = new ClsDAO();
        float entre;
        float sortie;
        float solde;
        public void Calcule()
        {
            try
            {
                entre = float.Parse(txtentre.Text);
                sortie = float.Parse(txtsorti.Text);
                solde = (entre - sortie);
                txtsolde.Text = solde.ToString();
                if (solde < 0)
                {
                    txtsolde.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {

            }

        }
        private void DashBord_Load(object sender, EventArgs e)
        {
            try
            {
                nomuser = File.ReadAllText(@"C:\church\user.txt");
                timer1.Start();

                dao.chargementGridOptimise("select * from [V_Operation_fINISH]", tableencours);       
                txtentre.Text = dao.nombre("select Montant_entre from [V_entre_journaliere] ", "Montant_entre");
                txtsorti.Text = dao.nombre("select Montant_sortie from V_sortie_journaliere ", "Montant_sortie");
                if (txtsorti.Text == "")
                {
                    txtsorti.Text = "0";
                }
                Calcule();

                membre.Text = dao.chargerNombre("membre", "count(Code)").ToString();
                concencre.Text = dao.chargerNombre("concencration", "count(code)").ToString();
                serviteur.Text = dao.chargerNombre("serviteur", "count(code)").ToString();
                agent.Text = dao.chargerNombre("agent", "count(code)").ToString();
                string operation = dao.chargerNombre("operation", "count(code)");
                string predi = dao.chargerNombre("PREDUCATEUR", "count(code)");
                string modera = dao.chargerNombre("MODERATUER", "count(code)");
                string utilisateur = dao.chargerNombre("UTILISATEUR", "count(code)");
                if (membre.Text=="" || concencre.Text=="" || serviteur.Text=="" || predi=="" || modera=="" || operation=="" || utilisateur=="")
                {

                }
                else
                {
                    chart2.Series["s1"].IsValueShownAsLabel = true;
                    chart2.Series["s1"].Points.AddXY("M", int.Parse(membre.Text));
                    chart2.Series["s1"].Points.AddXY("SC", int.Parse(concencre.Text));
                    chart2.Series["s1"].Points.AddXY("S", int.Parse(serviteur.Text));
                    chart2.Series["s1"].Points.AddXY("P", int.Parse(predi));
                    chart2.Series["s1"].Points.AddXY("MO", int.Parse(modera));
                    chart2.Series["s1"].Points.AddXY("OP", int.Parse(operation));
                    chart2.Series["s1"].Points.AddXY("UT", int.Parse(utilisateur));
                }
                if (txtentre.Text=="" && txtsorti.Text=="" && txtsolde.Text=="")
                {

                }
                else
                {
                    chart1.Series["s2"].IsValueShownAsLabel = true;
                    chart1.Series["s2"].Points.AddXY("", int.Parse(membre.Text));
                    chart1.Series["s2"].Points.AddXY("", int.Parse(concencre.Text));
                    chart1.Series["s2"].Points.AddXY("", int.Parse(serviteur.Text));
                    chart1.Series["s2"].Points.AddXY("", int.Parse(predi));
                    chart1.Series["s2"].Points.AddXY("", int.Parse(modera));
                   // chart1.Series["s2"].Points.AddXY("", int.Parse(operation));
                    chart1.Series["s2"].Points.AddXY("", int.Parse(utilisateur));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text= DateTime.Now.Hour.ToString()+(":")+ DateTime.Now.Minute.ToString()+(":")+ DateTime.Now.Second.ToString();
            string dates= DateTime.Now.DayOfWeek.ToString();
            string mois = DateTime.Now.DayOfYear.ToString();
            string day = DateTime.Now.Day.ToString();
            date(dates);
        }
        public void date(string date)
        {
            string day = DateTime.Now.Day.ToString();
            switch (date)
            {
                case "Sunday":
                    label11.Text = "Dimanche"+",";
                    label1.Text =" le " + day + ("/") + DateTime.Now.Month + ("/") + DateTime.Now.Year.ToString();
                    break;
                case "Monday":
                    label11.Text = "Lundi"+",";
                    label1.Text =" le " + day + ("/") + DateTime.Now.Month + ("/") + DateTime.Now.Year.ToString();
                    break;
                case "Tuesday":
                    label11.Text = "Mardi"+",";
                    label1.Text =" le " + day + ("/") + DateTime.Now.Month + ("/") + DateTime.Now.Year.ToString();
                    break;
                case "Wednesday":
                    label11.Text = "Mercredi";
                    label1.Text = " le " + day + ("/") + DateTime.Now.Month + ("/") + DateTime.Now.Year.ToString();
                    break;
                case "Thursday":
                    label11.Text = "Jeudi";
                    label1.Text =" le " + day + ("/") + DateTime.Now.Month + ("/") + DateTime.Now.Year.ToString();
                    break;
                case "Friday":
                    label11.Text = "Vendredi";
                    label1.Text =" le "+day + ("/") + DateTime.Now.Month + ("/") + DateTime.Now.Year.ToString();
                    break;
                case "Saturday":
                    label11.Text = "Samedi";
                    label1.Text =" le " + day + ("/") + DateTime.Now.Month + ("/") + DateTime.Now.Year.ToString();
                    break;
            }
        }
        private void panel0_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void concencre_Click(object ender, EventArgs e)
        {

        }

        private void tableencours_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {

                }
                else
                {
                    ContextMenuStrip my_menu = new System.Windows.Forms.ContextMenuStrip();
                    int position_row = tableencours.HitTest(e.X, e.Y).RowIndex;
                    if (position_row >= 0)
                    {
                        my_menu.Items.Add("Validation bon disponible").Name = "Validation bon disponible";

                    }
                    my_menu.Show(tableencours, new Point(e.X, e.Y));

                    my_menu.ItemClicked += new ToolStripItemClickedEventHandler(my_menuItemclicked1);
                }
            }
            catch (Exception ex) { MessageBox.Show("Erreur"); }
        }
        string nomuser;

        string Oper;
        public void my_menuItemclicked1(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                FrmAfficher f = new FrmAfficher();
                f.txttype.Text= tableencours.SelectedRows[0].Cells[0].Value.ToString();
                f.label1.Text = tableencours.SelectedRows[0].Cells[4].Value.ToString();
                f.ShowDialog();
            }
            catch (Exception ex)
            {

            }

        }

        private void bunifuGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsortie_Click(object sender, EventArgs e)
        {
            
        }
    }
}
