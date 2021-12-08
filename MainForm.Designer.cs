
namespace ReservProgram
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReserve = new MetroFramework.Controls.MetroButton();
            this.btnSetting = new MetroFramework.Controls.MetroButton();
            this.trayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Icon_MouseDoubleClick_1);
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem1,
            this.hideToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.trayMenu.Name = "Menu";
            this.trayMenu.Size = new System.Drawing.Size(105, 70);
            this.trayMenu.Opening += new System.ComponentModel.CancelEventHandler(this.Menu_Opening_1);
            // 
            // showToolStripMenuItem1
            // 
            this.showToolStripMenuItem1.Name = "showToolStripMenuItem1";
            this.showToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.showToolStripMenuItem1.Text = "Show";
            this.showToolStripMenuItem1.Click += new System.EventHandler(this.showToolStripMenuItem1_Click);
            // 
            // hideToolStripMenuItem1
            // 
            this.hideToolStripMenuItem1.Name = "hideToolStripMenuItem1";
            this.hideToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.hideToolStripMenuItem1.Text = "Hide";
            this.hideToolStripMenuItem1.Click += new System.EventHandler(this.hideToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(896, 490);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(75, 23);
            this.btnReserve.TabIndex = 1;
            this.btnReserve.Text = "예약";
            this.btnReserve.Click += new System.EventHandler(this.BtnReserve_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(896, 519);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(75, 23);
            this.btnSetting.TabIndex = 2;
            this.btnSetting.Text = "설정";
            this.btnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1343, 823);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnReserve);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.trayMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private MetroFramework.Controls.MetroButton btnReserve;
        private MetroFramework.Controls.MetroButton btnSetting;
    }
}