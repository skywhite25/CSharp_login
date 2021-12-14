using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace ReservProgram
{
    public partial class Reserve : MetroForm
    {
        String url = ConfigurationManager.ConnectionStrings["qrid"].ConnectionString;

        public Reserve()
        {
            InitializeComponent();

            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            MessageBox.Show("성공");
            conn.Close();
        }

        private void radSchedulerNavigator1_Click(object sender, EventArgs e)
        {

        }

        private void radSchedulerDemo_Click(object sender, EventArgs e)
        {

        }

        private void radCalendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {

        }

        private void radPageViewPage4_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
