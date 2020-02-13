using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anketa
{
    public partial class MainForm : Form
    {
        public static string auth,idauth;
        public MainForm()
        {
            InitializeComponent();
            Interviewer();
            Connect();
            Text = "Анкетирование - "+auth;
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.Show(); // отображаем Form1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1lvl.Form1app frm1app = new Form1lvl.Form1app();
            frm1app.Show();
        }

        private void Connect()
        {
            string cs = Properties.Settings.Default.ConnectionString;
            SqlConnection conn = new SqlConnection(cs);

        }

        private void Interviewer()
        {
            if (cbEnableEditInterview.Checked == false)
            {
                cbInterviewer.Enabled = false;
                tbRespondent.Enabled = false;
                tbPhone.Enabled = false;
                cbCity.Enabled = false;
                cbMo.Enabled = false;
                dtpDateSoc.Enabled = false;
                lInterviewer.Enabled = false;
                lRespondent.Enabled = false;
                lPhone.Enabled = false;
                lCity.Enabled = false;
                lMo.Enabled = false;
                lDate.Enabled = false;
                button1.Enabled = true;
            }
            else
            {
                cbInterviewer.Enabled = true;
                tbRespondent.Enabled = true;
                tbPhone.Enabled = true;
                cbCity.Enabled = true;
                cbMo.Enabled = true;
                dtpDateSoc.Enabled = true;
                lInterviewer.Enabled = true;
                lRespondent.Enabled = true;
                lPhone.Enabled = true;
                lCity.Enabled = true;
                lMo.Enabled = true;
                lDate.Enabled = true;
                button1.Enabled = false;
            }
        }

        private void cbEnableEditInterview_Click(object sender, EventArgs e)
        {
            Interviewer();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBFORMDataSet.T_MO". При необходимости она может быть перемещена или удалена.
            this.t_MOTableAdapter.Fill(this.dBFORMDataSet.T_MO);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBFORMDataSet.T_AREA". При необходимости она может быть перемещена или удалена.
            this.t_AREATableAdapter.Fill(this.dBFORMDataSet.T_AREA);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBFORMDataSet.T_AUTH". При необходимости она может быть перемещена или удалена.
            this.t_AUTHTableAdapter.Fill(this.dBFORMDataSet.T_AUTH);
            cbInterviewer.SelectedIndex= cbInterviewer.FindString(auth);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.t_AUTHTableAdapter.FillBy(this.dBFORMDataSet.T_AUTH);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
