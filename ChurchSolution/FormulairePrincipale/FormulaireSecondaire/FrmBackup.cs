using ChurchSolution.ClasseFonction;
using ChurchSolution.ClassePrincipale;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChurchSolution.FormulairePrincipale.FormulaireSecondaire
{
    public partial class FrmBackup : Form
    {

        Clsfonctions fx = new Clsfonctions();
        ClsDAO dao = new ClsDAO();
        private SqlConnection conn;
        private SqlCommand commd;
        private SqlDataReader reader;

        string sql = "";
        string connectionString = "";
        public FrmBackup()
        {
            InitializeComponent();
            if (txtBackupFileloc.Text.Equals(txtBackupFileloc.Text))
            {
                txtBackupFileloc.Text = txtBackupFileloc.Text;
            }
            txtRestoreFileLoc.Text = (@"C:\Users\Public\Documents");
        }

        String ASS;
        private void FrmBackup_Load(object sender, EventArgs e)
        {
            ASS = (string.Format(@"{0}", Environment.MachineName) + "" + "");
            txtDataSource.Text = ASS;

            listBox1.Items.Add(Directory.Exists(@"D:\Back"));

            start.Checked.Equals(false);
            stop.Checked.Equals(false);

            

            if (!Directory.Exists(@"D:\Back"))
            {
                Directory.CreateDirectory("D:\\Back");
            }
            if (txtBackupFileloc.Text == "")
            {
                txtBackupFileloc.Text = "D:\\Back";
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDiscon_Click(object sender, EventArgs e)
        {
           
        }

        private void btnbackup_Click(object sender, EventArgs e)
        {
            
        }

        private void iTalk_Button_14_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            
        }

        private void iTalk_Button_12_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtDataSource.Text.Equals("") || txtUser.Text.Equals("") || txtpassword.Equals(""))
                {
                    MessageBox.Show("Veillé compléter tout les champs!");
                }
                else
                {
                    connectionString = "Data Source=" + txtDataSource.Text + ";User Id=" + txtUser.Text + ";Password=" + txtpassword.Text + "";
                    conn = new SqlConnection(connectionString);
                    conn.Open();
                    // sql = "EXEC sp_databases";
                    sql = "SELECT * FROM sys.databases d WHERE d.database_id>4";
                    commd = new SqlCommand(sql, conn);
                    reader = commd.ExecuteReader();
                    cmbDatabases.Items.Clear();
                    while (reader.Read())
                    {
                        cmbDatabases.Items.Add(reader[0].ToString());
                    }
                    reader.Dispose();
                    conn.Close();
                    conn.Dispose();

                    txtDataSource.Enabled = false;
                    txtUser.Enabled = false;
                    txtpassword.Enabled = false;
                    btnConnect.Enabled = false;
                    btnDiscon.Enabled = true;
                    btnbackup.Enabled = true;
                    btnRestore.Enabled = true;
                    cmbDatabases.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veillée vérifier tous les champs si ce correcte!");
            }
        }

        private void btnDiscon_Click_1(object sender, EventArgs e)
        {
            txtDataSource.Enabled = true;
            txtpassword.Enabled = true;
            txtUser.Enabled = true;
            cmbDatabases.Enabled = false;
            btnConnect.Enabled = true;
            btnbackup.Enabled = false;
            btnRestore.Enabled = false;
            btnDiscon.Enabled = false;
        }

        private void btnRestore_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbDatabases.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Sélectionne la base de donnée!");
                    return;
                }
                conn = new SqlConnection(connectionString);
                conn.Open();
                sql = "Alter Database " + cmbDatabases.Text + " Set SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                sql += "Restore Database " + cmbDatabases.Text + " FROM Disk ='" + txtRestoreFileLoc.Text + "' WITH REPLACE;";
                commd = new SqlCommand(sql, conn);
                commd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                MessageBox.Show("Restauration réussie!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void iTalk_Button_14_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtBackupFileloc.Text = dlg.SelectedPath;
            }
        }

        private void iTalk_Button_12_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup Files(*.bak)|*.bak|All FIles(*.*)| *.* ";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtRestoreFileLoc.Text = dlg.FileName;
            }
        }

        private void btnbackup_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbDatabases.Text.CompareTo("") == 0 || cmbDatabases.Text.Equals(""))
                {
                    MessageBox.Show("Sélectionne la base de donnée!");
                    return;
                }
                conn = new SqlConnection(connectionString);
                conn.Open();
                sql = "BACKUP DATABASE [" + cmbDatabases.Text + "] TO DISK='" + txtBackupFileloc.Text + "\\" + (cmbDatabases.Text.ToUpper()) + "--" + "--" + "" + DateTime.Now.Ticks.ToString().ToUpper() + ".bak'";
                commd = new SqlCommand(sql, conn);
                commd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                MessageBox.Show("Backup reussi! ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {

            }
        }
        string heure;
        string Minute;
        string second;
        private void timer1_Tick(object sender, EventArgs e)
        {
            heure = DateTime.Now.Hour.ToString();
            Minute = DateTime.Now.Minute.ToString();
            second = DateTime.Now.Second.ToString();
            txttime.Text = heure +":"+ Minute +":"+second;
            if (txttime.Text=="5:58:1")
            {
                try
                {
                    if (cmbDatabases.Text.CompareTo("") == 0 || cmbDatabases.Text.Equals(""))
                    {
                        MessageBox.Show("Sélectionne la base de donnée!");
                    }
                    conn = new SqlConnection(connectionString);
                    conn.Open();
                    sql = "BACKUP DATABASE [" + cmbDatabases.Text + "] TO DISK='" + txtBackupFileloc.Text + "\\" + (cmbDatabases.Text.ToUpper()) + "--" + "--" + "" + DateTime.Now.Ticks.ToString().ToUpper() + ".bak'";
                    commd = new SqlCommand(sql, conn);
                    commd.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();
                    MessageBox.Show("Backup reussi! ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {

                }
            }

        }

        private void iTalk_Toggle1_ToggledChanged()
        {
           
        }

        private void start_CheckedChanged(object sender, EventArgs e)
        {
            if (txtDataSource.Text.Equals("") || txtUser.Text.Equals("") || txtpassword.Equals("") || cmbDatabases.Text.Equals(""))
            {
                fx.Messages(3);
                start.Checked.Equals(false);
            }
            else
            {
                if (start.Checked.Equals(true))
                {
                    timer1.Start();
                    stop.Checked.Equals(false);
                    
                }
            }
  
           
        }

        private void stop_CheckedChanged(object sender, EventArgs e)
        {
            if (stop.Checked.Equals(true))
            {
                timer1.Stop();
                start.Checked.Equals(false);
            }
        }
    }
}
