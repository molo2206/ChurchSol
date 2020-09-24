using ChurchSolution.ClasseFonction;
using ChurchSolution.ClassePrincipale;
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

namespace ChurchSolution.FormulairePrincipale.FormulaireSecondaire.FormulaireNotification
{
    public partial class FrmValidation : Form
    {
        public FrmValidation()
        {
            InitializeComponent();
        }
        ClsDAO dao = new ClsDAO();
        Clsfonctions fx = new Clsfonctions();
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmValidation_Load(object sender, EventArgs e)
        {
            date.Text = dao.Adddate(code.Text);
            txtlettre.Text = dao.Lettre(code.Text);
            txtuser.Text= File.ReadAllText(@"C:\church\user.txt");
            dao.chargerlist("select * from [V_UserValide] where Code_Op='"+code.Text+"'", "NOM_UTILISATEUR", listvalidation);

            txtbene.Text = label6.Text;

            txttype.Text = dao.Type(code.Text);

            txtmontant.Text = dao.Montant(code.Text);

            txtdevise.Text = dao.Devise(code.Text);

            txtlettre.Text = dao.Lettres(code.Text);

            txtbene.Text = dao.Ben(code.Text);
            txtmontant.Text = dao.Mont(code.Text);
            txtdevise.Text = dao.Devis(code.Text);
            txttype.Text = dao.Typ(code.Text);
            date.Text = dao.Date_Operation(code.Text);

        }
        private void code_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsuite_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtuser.Text==""|| code.Text=="")
                {
                    fx.Messages(3);
                }
                else
                {
                    int Oper = int.Parse(code.Text);
                    string rqt = "exec [ValiderBon] '" + txtuser.Text + "','" + Oper + "'";
                    dao.Executer(rqt);
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}

