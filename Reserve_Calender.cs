using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservProgram
{
    public partial class Reserve_Calender : MetroForm
    {
        int month;                                               
        int year;

        public static int static_month, static_year;

        public Reserve_Calender()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            displayDays();
        }


        // btnPrevious
        private void metroButton1_Click(object sender, EventArgs e)
        {


            // clear container
            dayContainer.Controls.Clear();

            if (month != 1)
            {
                month--;
            }
            else
            {
                month = 12;
                year--;
            }
            static_month = month;
            static_year = year;

            /*month--;*/
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = year + "년" + " " + monthName;


            // 달의 첫째 날
            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }

        // btnNext
        private void metroButton2_Click(object sender, EventArgs e)
        {


            // clear container
            dayContainer.Controls.Clear();

            if (month != 12)
            {
                month++;
            }
            else
            {
                month = 1;
                year++;
            }

            static_month = month;
            static_year = year;
            // 달 증가

            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = year + "년" + " " + monthName;

            // 달의 첫째 날
            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = year + "년" + " " + monthName;

            static_month = month;
            static_year = year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);
            
            int days = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            for(int i=1; i<dayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i); 
                dayContainer.Controls.Add(ucdays);
            }

        }
        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
