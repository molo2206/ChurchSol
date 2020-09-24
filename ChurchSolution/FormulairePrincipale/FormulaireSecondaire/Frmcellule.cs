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
    public partial class Frmcellule : Form
    {
        public Frmcellule()
        {
            InitializeComponent();
        }
        Clsfonctions fx = new Clsfonctions();
        ClsDAO dao = new ClsDAO();
        ClsMembre cm = new ClsMembre();
        private void Frmcellule_Load(object sender, EventArgs e)
        {
            dao.Autocomplete("select nom_cellule from cellule","nom_cellule",rech);
            this.MinimizeBox = false;
        
        }

        private void rech_TextChanged(object sender, EventArgs e)
        {
            txtidenti.Text = dao.codecellule(rech.Text);
            txtcellule.Text = dao.Nom_cellule(rech.Text);
            txtadress.Text = dao.AdresseCellule(rech.Text);
        }

        private void btnsuite_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcellule.Text=="" || txtadress.Text=="")
                {
                    fx.Messages(3);
                }
                else
                {
                  string rqt = "exec [Ajout_Cellule] '"+txtidenti.Text+"','"+txtcellule.Text.ToUpper()+"','"+txtadress.Text.ToUpper()+"'";
                  dao.Executer(rqt);
                }
                
            }
            catch(Exception ex)
            {

            }
        }

        private void rech_Enter(object sender, EventArgs e)
        {
            if (rech.Text=="Rechercher")
            {
                rech.Text = "";
            }
        }

        private void rech_Leave(object sender, EventArgs e)
        {
            if (rech.Text == "")
            {
                rech.Text = "Rechercher";
            }
        }
    }
}
