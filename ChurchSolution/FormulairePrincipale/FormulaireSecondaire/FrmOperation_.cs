using ChurchSolution.ClasseFonction;
using ChurchSolution.ClassePrincipale;
using ChurchSolution.FormulairePrincipale.FormulaireSecondaire.FormulaireNotification;
using ChurchSolution.Rapport_Etat_de_sortie_;
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

namespace ChurchSolution.FormulairePrincipale.FormulaireSecondaire
{
    public partial class FrmOperation_ : Form
    {
        public FrmOperation_()
        {
            InitializeComponent();
        }
        ClsDAO dao = new ClsDAO();
        Clsfonctions fx = new Clsfonctions();
        
        private void btnsuite_Click(object sender, EventArgs e)
        {
            FrmEntree fre = new FrmEntree();
            fre.txttype.Text = btnsuite.Text;         
            fre.ShowDialog();
        }
        string chemin;
        private void FrmOperation__Load(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select * from [V_Operation_fINISH]", tableencours);
            dao.chargementGridOptimise("select * from [V_Operation]", Listebapteme);
            terminer.Text=dao.chargerNombre("[V_Operation]", "count(code)");
            countope.Text = dao.chargerNombre("[operation]", "count(code)");
            encours.Text = dao.chargerNombre("V_Operation_fINISH", "count(code)");
            chemin = File.ReadAllText(@"C:\church\user.txt");
        }

        private void tableencours_CellClick(object sender, DataGridViewCellEventArgs e)
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
                        my_menu.Items.Add("Valider").Name = "Valider";

                    }
                    my_menu.Show(tableencours, new Point(e.X, e.Y));

                    my_menu.ItemClicked += new ToolStripItemClickedEventHandler(my_menuItemclicked);
                }
            }
            catch (Exception ex) { MessageBox.Show("Erreur"); }
        }
        public void my_menuItemclicked(object sender, ToolStripItemClickedEventArgs e)
        {
            FrmValidation fr = new FrmValidation();

            try
            {
                fr.code.Text = tableencours.SelectedRows[0].Cells[0].Value.ToString();
                fr.txtbene.Text = tableencours.SelectedRows[0].Cells[4].Value.ToString();
                fr.txttype.Text = tableencours.SelectedRows[0].Cells[1].Value.ToString();
                fr.txtmontant.Text = tableencours.SelectedRows[0].Cells[2].Value.ToString();
                fr.txtdevise.Text = tableencours.SelectedRows[0].Cells[3].Value.ToString();
                fr.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show("Erreur"); }

        }

        private void Listebapteme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void my_menuItemclicked1(object sender, ToolStripItemClickedEventArgs e)
        {
            FrmValidation fr = new FrmValidation();
            try
            {
                fr.code.Text = Listebapteme.SelectedRows[0].Cells[0].Value.ToString();
                fr.txtbene.Text = Listebapteme.SelectedRows[0].Cells[4].Value.ToString();
                fr.txttype.Text = Listebapteme.SelectedRows[0].Cells[1].Value.ToString();
                fr.txtmontant.Text = Listebapteme.SelectedRows[0].Cells[2].Value.ToString();
                fr.txtdevise.Text = Listebapteme.SelectedRows[0].Cells[3].Value.ToString();
                fr.btnsuite.Enabled = false;
                fr.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show("Erreur"); }
        }
        private void Listebapteme_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                if (e.Button == MouseButtons.Left)
                {

                }
                else
                {
                    ContextMenuStrip my_menu = new System.Windows.Forms.ContextMenuStrip();
                    int position_row = Listebapteme.HitTest(e.X, e.Y).RowIndex;
                    if (position_row >= 0)
                    {
                        my_menu.Items.Add("Visualiser").Name = "Visualiser";
                    }
                    my_menu.Show(Listebapteme, new Point(e.X, e.Y));

                    my_menu.ItemClicked += new ToolStripItemClickedEventHandler(my_menuItemclicked1);
                }
            }
            catch (Exception ex) { MessageBox.Show("Erreur"); }
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FrmEntree fre = new FrmEntree();
            fre.txttype.Text = btnsortie.Text;
            fre.ShowDialog();
        }
        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
          
        }

        private void date_onValueChanged(object sender, EventArgs e)
        {
        }

        private void reche_TextChanged(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select  * from [V_Operation_vrai] where Beneficiaire like '%" + reche.Text + "%' or Montant like '%" + reche.Text + "%' or Code like '%" + reche.Text + "%'", Listebapteme);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select * from [V_Operation_fINISH]", tableencours);
            dao.chargementGridOptimise("select * from [V_Operation]", Listebapteme);
            terminer.Text = dao.chargerNombre("[V_Operation]", "count(code)");
            encours.Text = dao.chargerNombre("V_Operation_fINISH", "count(code)");

        }

        private void date_onValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                txtdate.Text = date.Value.ToString();
                string dates = date.Value.ToString("dd/MM/yyy");
                dao.chargementGridOptimise("select * from [V_Operation_vrai] where convert(varchar(10), AddDate, 103) like convert(varchar(10), '" + dates + "', 103)", Listebapteme);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
 
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmListeOperation li = new FrmListeOperation();
            li.ShowDialog();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            if (chemin!= "UT001")
            {
                fx.Messages(6);
            }
            else
            {
                Frmcaisse li = new Frmcaisse();
                li.ShowDialog();
            }
        }
    }
}
