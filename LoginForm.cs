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

namespace ReservProgram
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
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