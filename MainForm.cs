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
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            trayIcon.Visible = true;
        }

        private void showToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            /*windowTray();*/
        }

        private void hideToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            trayIcon.Visible = true;
            this.Hide();
            this.ShowInTaskbar = false;
            /*windowTray();*/            
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("시스템이 종료됩니다.");
            Application.Exit();            
        }


        private void Icon_MouseDoubleClick_1(object sender, MouseEventArgs e)

            // 잘됨
        {
            this.Visible = true;
        }

        private void Menu_Opening_1(object sender, CancelEventArgs e)
        {
      
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 트레이에서 종료를 누르면 프로그램 종료
            if (e.CloseReason == CloseReason.UserClosing)
            {               
                e.Cancel = true;
                this.Visible = false;
                this.ShowInTaskbar = false;
            }
        }

        /*this.Hide();
        e.Cancel = true;*/

        /*Console.WriteLine("before xbutton : " + trayIcon.Visible);
        *//*windowTray();*//*
        Console.WriteLine("xbutton : " + trayIcon.Visible);*/
        /*}*/

        /*        private void windowTray()
                {
                    Console.WriteLine("in windowTray()" + trayIcon.Visible);

                    if (this.ShowInTaskbar != true)
                        // 창이 꺼져있을 떄
                    {
                        Console.WriteLine("true");
                        *//*trayIcon.Visible = false;*//*
                        this.ShowInTaskbar = true;
                        this.Visible = true;
                        this.Show();
                        this.WindowState = FormWindowState.Normal;
                        Console.WriteLine(this.Visible);
                    } else
                        // 창이 켜져있을 때
                    {
                        Console.WriteLine("false");
                        *//*trayIcon.Visible = true;*//*
                        this.Visible = false;
                        *//*this.Hide();*//*
                        this.Hide();
                        this.ShowInTaskbar = false;
                        Console.WriteLine(this.Visible);
                    }
                    // 최소화 버튼 건드리기
                }*/
    }
}