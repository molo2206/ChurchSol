using ChurchSolution.ClassePrincipale;
using ChurchSolution.FormulaireSecondaire;
using ChurchSolution.Rapport_Etat_de_sortie_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChurchSolution.FormulairePrincipale.FormulaireSecondaire.FormulaireNotification
{
    public partial class ListeAgent : Form
    {
        public ListeAgent()
        {
            InitializeComponent();
        }

        ClsDAO dao = new ClsDAO();
        private void ListeAgent_Load(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select CODE, NOM_COMPLET, sexe, Fonction, barcode from V_Agent", Listemembre);
            total.Text = dao.Countnombre("select count(code) as code from agent ", "code");
            homme.Text = dao.Countnombre("select count(code) as code from agent where SEXE='MASCULIN'", "code");
            femme.Text = dao.Countnombre("select count(code) as code from agent  where SEXE='FEMININ'", "code");
        }
        private void reche_OnTextChange(object sender, EventArgs e)
        {
        }

        private void btnsuite_Click(object sender, EventArgs e)
        {
            FrmAhent fa = new FrmAhent();
            fa.ShowDialog();
        }

        private void Listemembre_MouseClick(object sender, MouseEventArgs e)
        {
            

        }

        FrmCarte fa = new FrmCarte();

        public void my_menuItemclicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                fa.rech.Text = Listemembre.SelectedRows[0].Cells[1].Value.ToString();
                fa.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show("Erreur"); }

        }

        private void date_onValueChanged(object sender, EventArgs e)
        {
            txtdate.Text = date.Value.ToString();
            string dates = date.Value.ToString("yyy-MM-dd");
            dao.chargementGridOptimise("select  * from Agent where date_add like '%" + dates + "%'", Listemembre);
        }

        private void txtdate_OnValueChanged(object sender, EventArgs e)
        {
        }

        private void Listemembre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reche_TextChanged(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select   CODE, NOM_COMPLET, sexe, Fonction, barcode  from V_Agent where nom_complet like '%" + reche.Text + "%'", Listemembre);
        }

        private void Listemembre_MouseClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {

                }
                else
                {
                    ContextMenuStrip my_menu = new System.Windows.Forms.ContextMenuStrip();
                    int position_row = Listemembre.HitTest(e.X, e.Y).RowIndex;
                    if (position_row >= 0)
                    {
                        my_menu.Items.Add("Imprimer la carte").Name = "Imprimer la carte";

                    }
                    my_menu.Show(Listemembre, new Point(e.X, e.Y));

                    my_menu.ItemClicked += new ToolStripItemClickedEventHandler(my_menuItemclicked);
                }
            }
            catch (Exception ex) { MessageBox.Show("Erreur"); }
        }

        private void Listemembre_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
