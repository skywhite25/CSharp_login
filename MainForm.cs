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
        }

        private void showToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void hideToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Icon.Visible = true;
            this.Hide();
            this.ShowInTaskbar = false;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("시스템이 종료됩니다.");
            Console.WriteLine(this + " = this");
            this.Close();
        }


        private void Icon_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void Menu_Opening_1(object sender, CancelEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
