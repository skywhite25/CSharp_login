using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ReservProgram
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
/*            string connStr = string.Format(@"server=localhost;
                                        id=test;
                                        pw=zbflem2021@@;
                                        db=qrid");
            MySqlConnection con = new MySqlConnection(connStr);
            try
            {
                con.Open();
                MessageBox.Show("연결 성공");
            }
            catch
            {
                con.Close();
                MessageBox.Show("연결 실패");
                Application.OpenForms["MainForm"].Close();
            }*/
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void strLoginPW_TextChanged(object sender, EventArgs e)
        {

        }

        private void strLoginID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (strLoginID.Text == "test" && strLoginPW.Text == "1234") {
                MessageBox.Show("로그인 성공");
                this.Visible = false;
                MainForm showForm = new MainForm();        
                showForm.Show();
        } else {
                MessageBox.Show("로그인 실패");
                this.Visible = true;
                strLoginID.Clear();
                strLoginPW.Clear();
            }

        }


    }
}