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
    public partial class Logon : Form
    {
        public Logon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbLogin.Text != "" && tbPassword.Text != "")
                {
                    string cs = Properties.Settings.Default.ConnectionString;
                    SqlConnection conn = new SqlConnection(cs);

                    string logon = "Select * from DB.T_AUTH where username='" + tbLogin.Text + "' and password='" + tbPassword.Text + "'";

                    SqlDataAdapter sda = new SqlDataAdapter(logon, conn);
                    
                    DataTable dt = new DataTable(); //this is creating a virtual table  
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() != "")
                    {
                        /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                        this.Hide();
                        conn.Close();
                        MainForm.auth = dt.Rows[0][4].ToString();
                        MainForm.idauth = dt.Rows[0][0].ToString();
                        
                        new MainForm().Show();
                    }
                    else
                        MessageBox.Show("Invalid username or password");
                }
                else
                    MessageBox.Show("Empty username and/or password");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
