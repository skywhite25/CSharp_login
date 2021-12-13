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
using MySql.Data.MySqlClient;

namespace ReservProgram
{
    public partial class EventForm : MetroForm
    {

        /*String connString = "server=localhost;user id = root; reservprogram;sslmode=none";*/


        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            txDate.Text = Setting.static_year +  "/" + Setting.static_month + "/" + UserControlDays.static_day;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
/*            MySqlConnection conn = new MySqlConnection(connString);
            String sql = "insert into "*/
        }
    }
}
