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
    public partial class MainForm : MetroForm
    {



        /*        String _Server = "localhost";
                int _port = 3306;
                string _db = "qrid_test";
                string _id = "root";
                string _pw = "aa135719";
                string _connectionAddress = "";*/

        public MainForm()
        {

        }

        
/*
            _connectionAddress = string.Format("Server={0},port={1},db={2},id={3},pw={4}", _Server, _port, _db, _id, _pw);*/
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


        

        private void showToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // 보이는 거 this.Show(); 로만 설정해놓으면 hide/show가 역할이 같아지는거 같다.
            this.Visible = true;
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;

            Console.WriteLine("트레이 show버튼");
        }

        private void hideToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            /*                this.Hide();
                            this.ShowInTaskbar = false;
                            Console.WriteLine("this.ShowInTaskbar == false : 트레이 hide버튼");*/
            this.Hide();
            /*windowTray("hide");*/
            /*Console.WriteLine("this.ShowInTaskbar : " + this.ShowInTaskbar + " this.Visible : " + this.Visible + " this.WindowState : " + this.WindowState);*/
            Console.WriteLine("트레이 hide 버튼");

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("시스템이 종료됩니다.");
            Application.Exit();
        }

        private void Icon_MouseDoubleClick_1(object sender, MouseEventArgs e)
        // 보이는 거 this.Show(); 로만 설정해놓으면 hide/show가 역할이 같아지는거 같다.
        // 잘됨 -> 왜 잘되는지는 모름
        {

            /*this.Show();*/
            this.Visible = true;
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;


            /*Console.WriteLine("this.ShowInTaskbar : " + this.ShowInTaskbar + " this.Visible : " + this.Visible + " this.WindowState : " + this.WindowState);*/
            Console.WriteLine("트레이 더블클릭");
        }

        private void Menu_Opening_1(object sender, CancelEventArgs e)
        {
            Console.WriteLine("트레이 메뉴 오픈");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            Console.WriteLine("메인폼 로드");            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 트레이에서 종료를 누르면 프로그램 종료
            // FormClosing = 폼을 닫기 전에 수행할 것을 명령 ex) 종료 전에 저장하는 것을 물어본다.
            // FormClosed = 폼을 닫은 후에 수행할 것을 명령 ex) 이용해주셔서 감사합니다.
            if (e.CloseReason == CloseReason.UserClosing)
            /*  if (false)*/
            {
                e.Cancel = true;
                Hide();

                /*windowTray();*/
                /*this.WindowState = FormWindowState.Minimized;*/
                Console.WriteLine("컨트롤박스 닫기버튼");
                Console.WriteLine("this.ShowInTaskbar : " + this.ShowInTaskbar + " this.Visible : " + this.Visible + " this.WindowState : " + this.WindowState);

            }
            /*windowTray("hide");
            Console.WriteLine("컨트롤박스 닫기버튼");
            Console.WriteLine("this.ShowInTaskbar : " + this.ShowInTaskbar + " this.Visible : " + this.Visible + " this.WindowState : " + this.WindowState);*/
        }

        /*        private void MainForm_Resize(object sender, EventArgs e)
                {

                    if (FormWindowState.Normal == this.WindowState)
                    {
                        this.Hide();
                        this.ShowInTaskbar = true;
                        Console.WriteLine("컨트롤박스 최소화 버튼");
                    }
                    else if (FormWindowState.Minimized == this.WindowState)
                    {
                        this.ShowInTaskbar = true;
                        Console.WriteLine("MainForm_Resize.FormWindowState.Normal");
                    }
                }*/
        private void BtnReserve_Click(object sender, EventArgs e)
        {
            Reserve reserve = new Reserve();
            reserve.ShowDialog();
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            Reserve_Calender setting = new Reserve_Calender();
            setting.Show();
        }

        private void radCalendar2_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void tabNavigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void schedulerControl1_Click(object sender, EventArgs e)
        {

        }

        private void schedulerControl1_EditAppointmentFormShowing(object sender, DevExpress.XtraScheduler.AppointmentFormEventArgs e)
        {
            DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            ReservProgram.CustomAppointmentForm form = new ReservProgram.CustomAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
            try
            {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            finally
            {
                form.Dispose();
            }

        }

        // 컨트롤 창에서 최소화 버튼 클릭 -> 작업표시줄에는 아이콘이 남아있고 트레이 아이콘 유지
        // -> 트레이 아이콘 show 버튼 클릭 -> 컨트롤 버튼 미작동        

        /*this.Hide();
        e.Cancel = true;*/

        /*Console.WriteLine("before xbutton : " + trayIcon.Visible);
        *//*windowTray();*//*
        Console.WriteLine("xbutton : " + trayIcon.Visible);*/
        /*}*/

        /* private void windowTray(string action)
         {
             *//*if (this.ShowInTaskbar != true)*//*
             if(action == "show")
             // 창이 꺼져있을 떄
             {
                 if (this.Visible != true)
                 {
                     this.Show();
                     *//*this.Activate();
                     this.Show();*/
        /*this.WindowState = FormWindowState.Normal;*/

        /*                }else if(this.ShowInTaskbar == true){
                            this.Visible = true;
                            this.Show();
                            *//*
    }
    else
    {
        this.Hide();
        *//*this.Show();
        this.Activate();*/
        /*this.WindowState = FormWindowState.Normal;*//*

    }
    Console.WriteLine(this.Visible);
    Console.WriteLine("this.ShowInTaskbar : " + this.ShowInTaskbar + " this.Visible : " + this.Visible + " this.WindowState : " + this.WindowState);

}
else if (action == "hide")
// 창이 켜져있을 때
{             
    if (this.Visible == true)
    {
        *//*                    this.Visible = false;
                            *//*this.Hide()*//*;
                            this.ShowInTaskbar = false;*//*
        this.Hide();
        *//*this.WindowState = FormWindowState.Minimized;*//*
    }
    Console.WriteLine(this.Visible);
    Console.WriteLine("this.ShowInTaskbar : " + this.ShowInTaskbar + " this.Visible : " + this.Visible + " this.WindowState : " + this.WindowState);

}*/

        /*            if(FormWindowState.Minimized == this.WindowState)
                    {

                    }*/
        // 최소화 버튼 건드리기

        // if문 조건을 FormWindowState로 잡고 Normal & mini 어쩌구로 설정하고 실행해보기 if(FormWindowState.Minimized == this.WindowState)
    }


    /*
            private void MainForm_Resize(object sender, EventArgs e)
            {
                Console.WriteLine("???");
                Console.WriteLine(this.WindowState);
            }*/

    /*        private void MaximizeBox_Click(object sender, EventArgs e)
            {
                MainForm.ma
            }*/

    
}