﻿using System;
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
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            EventForm eventForm = new EventForm();
            eventForm.Show();

        }

        private void UserControlDays_MouseHover(object sender, EventArgs e)
        {
            UserControlDays userControlDays = new UserControlDays();
            userControlDays.BackColor = Color.Silver;
        }

        private void UserControlDays_MouseLeave(object sender, EventArgs e)
        {
            UserControlDays userControlDays = new UserControlDays();
            userControlDays.BackColor = Color.White;
        }
    }
}
