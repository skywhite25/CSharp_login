namespace ReservProgram
{
    partial class Reserve
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reserve));
            Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle2 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            Telerik.WinControls.UI.AppointmentMappingInfo appointmentMappingInfo2 = new Telerik.WinControls.UI.AppointmentMappingInfo();
            Telerik.WinControls.UI.ResourceMappingInfo resourceMappingInfo2 = new Telerik.WinControls.UI.ResourceMappingInfo();
            Telerik.WinControls.UI.RadCalendarDay radCalendarDay2 = new Telerik.WinControls.UI.RadCalendarDay();
            this.radCalendar1 = new Telerik.WinControls.UI.RadCalendar();
            this.object_a65e45d6_6d0c_4754_ac40_31a6d96432e9 = new Telerik.WinControls.RootRadElement();
            this.radSchedulerNavigator1 = new Telerik.WinControls.UI.RadSchedulerNavigator();
            this.radSchedulerDemo = new Telerik.WinControls.UI.RadScheduler();
            this.schedulerBindingDataSource1 = new Telerik.WinControls.UI.SchedulerBindingDataSource();
            this.schedulerDataDataSet = new ReservProgram.SchedulerDataDataSet();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radCalendar2 = new Telerik.WinControls.UI.RadCalendar();
            this.radPageViewPage3 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage4 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage5 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radDesktopAlert1 = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            this.radSchedulerReminder1 = new Telerik.WinControls.UI.RadSchedulerReminder(this.components);
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.EventProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.ResourceProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.radPageViewPage1.SuspendLayout();
            this.radPageViewPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radCalendar1
            // 
            this.radCalendar1.AllowMultipleView = true;
            resources.ApplyResources(this.radCalendar1, "radCalendar1");
            this.radCalendar1.HeaderHeight = 28;
            this.radCalendar1.HeaderWidth = 28;
            this.radCalendar1.MultiViewRows = 3;
            this.radCalendar1.Name = "radCalendar1";
            this.radCalendar1.SelectedDates.AddRange(new System.DateTime[] {
            new System.DateTime(2021, 12, 14, 0, 0, 0, 0)});
            this.radCalendar1.ThemeName = "Fluent";
            this.radCalendar1.ZoomFactor = 1.2F;
            this.radCalendar1.SelectionChanged += new System.EventHandler(this.radCalendar1_SelectionChanged);
            // 
            // object_a65e45d6_6d0c_4754_ac40_31a6d96432e9
            // 
            this.object_a65e45d6_6d0c_4754_ac40_31a6d96432e9.MinSize = new System.Drawing.Size(400, 74);
            this.object_a65e45d6_6d0c_4754_ac40_31a6d96432e9.Name = "object_a65e45d6_6d0c_4754_ac40_31a6d96432e9";
            this.object_a65e45d6_6d0c_4754_ac40_31a6d96432e9.StretchHorizontally = true;
            this.object_a65e45d6_6d0c_4754_ac40_31a6d96432e9.StretchVertically = true;
            // 
            // radSchedulerNavigator1
            // 
            this.radSchedulerNavigator1.AssociatedScheduler = this.radSchedulerDemo;
            this.radSchedulerNavigator1.DateFormat = "yyyy.MM.dd";
            resources.ApplyResources(this.radSchedulerNavigator1, "radSchedulerNavigator1");
            this.radSchedulerNavigator1.Name = "radSchedulerNavigator1";
            this.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day;
            // 
            // 
            // 
            this.radSchedulerNavigator1.RootElement.MinSize = new System.Drawing.Size(400, 74);
            this.radSchedulerNavigator1.RootElement.StretchVertically = false;
            this.radSchedulerNavigator1.ThemeName = "Fluent";
            this.radSchedulerNavigator1.Click += new System.EventHandler(this.radSchedulerNavigator1_Click);
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(0))).ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            ((Telerik.WinControls.UI.RadLabelElement)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(2))).Text = resources.GetString("resource.Text");
            // 
            // radSchedulerDemo
            // 
            this.radSchedulerDemo.AppointmentTitleFormat = null;
            this.radSchedulerDemo.Culture = new System.Globalization.CultureInfo("ko-KR");
            this.radSchedulerDemo.DataSource = this.schedulerBindingDataSource1;
            resources.ApplyResources(this.radSchedulerDemo, "radSchedulerDemo");
            this.radSchedulerDemo.HeaderFormat = "dd (ddd)";
            this.radSchedulerDemo.Name = "radSchedulerDemo";
            schedulerDailyPrintStyle2.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            schedulerDailyPrintStyle2.DateEndRange = new System.DateTime(2013, 3, 17, 0, 0, 0, 0);
            schedulerDailyPrintStyle2.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            schedulerDailyPrintStyle2.DateStartRange = new System.DateTime(2013, 3, 12, 0, 0, 0, 0);
            schedulerDailyPrintStyle2.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.radSchedulerDemo.PrintStyle = schedulerDailyPrintStyle2;
            this.radSchedulerDemo.ShowAllDayAppointmentStatus = true;
            this.radSchedulerDemo.ThemeName = "Fluent";
            this.radSchedulerDemo.Click += new System.EventHandler(this.radSchedulerDemo_Click);
            // 
            // schedulerBindingDataSource1
            // 
            // 
            // 
            // 
            this.schedulerBindingDataSource1.EventProvider.DataSource = this.schedulerDataDataSet;
            this.schedulerBindingDataSource1.EventProvider.Mapping = appointmentMappingInfo2;
            this.schedulerBindingDataSource1.EventProvider.Position = 0;
            // 
            // 
            // 
            this.schedulerBindingDataSource1.ResourceProvider.Mapping = resourceMappingInfo2;
            // 
            // schedulerDataDataSet
            // 
            this.schedulerDataDataSet.DataSetName = "SchedulerDataDataSet";
            this.schedulerDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.radPageViewPage1);
            this.radPageView1.Controls.Add(this.radPageViewPage2);
            this.radPageView1.Controls.Add(this.radPageViewPage3);
            this.radPageView1.Controls.Add(this.radPageViewPage4);
            this.radPageView1.Controls.Add(this.radPageViewPage5);
            resources.ApplyResources(this.radPageView1, "radPageView1");
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.radPageViewPage4;
            this.radPageView1.ThemeName = "Fluent";
            this.radPageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.Backstage;
            this.radPageView1.SelectedPageChanged += new System.EventHandler(this.radPageView1_SelectedPageChanged);
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Controls.Add(this.radCalendar1);
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(74F, 25F);
            resources.ApplyResources(this.radPageViewPage1, "radPageViewPage1");
            this.radPageViewPage1.Name = "radPageViewPage1";
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.Controls.Add(this.radCalendar2);
            this.radPageViewPage2.ItemSize = new System.Drawing.SizeF(74F, 25F);
            resources.ApplyResources(this.radPageViewPage2, "radPageViewPage2");
            this.radPageViewPage2.Name = "radPageViewPage2";
            // 
            // radCalendar2
            // 
            this.radCalendar2.HeaderHeight = 28;
            this.radCalendar2.HeaderWidth = 28;
            resources.ApplyResources(this.radCalendar2, "radCalendar2");
            this.radCalendar2.Name = "radCalendar2";
            radCalendarDay2.Date = new System.DateTime(2021, 12, 15, 0, 0, 0, 0);
            radCalendarDay2.Selectable = false;
            this.radCalendar2.SpecialDays.Add(radCalendarDay2);
            this.radCalendar2.ThemeName = "Fluent";
            // 
            // radPageViewPage3
            // 
            this.radPageViewPage3.ItemSize = new System.Drawing.SizeF(74F, 25F);
            resources.ApplyResources(this.radPageViewPage3, "radPageViewPage3");
            this.radPageViewPage3.Name = "radPageViewPage3";
            // 
            // radPageViewPage4
            // 
            this.radPageViewPage4.ItemSize = new System.Drawing.SizeF(74F, 25F);
            resources.ApplyResources(this.radPageViewPage4, "radPageViewPage4");
            this.radPageViewPage4.Name = "radPageViewPage4";
            this.radPageViewPage4.Paint += new System.Windows.Forms.PaintEventHandler(this.radPageViewPage4_Paint);
            // 
            // radPageViewPage5
            // 
            this.radPageViewPage5.ItemSize = new System.Drawing.SizeF(74F, 25F);
            resources.ApplyResources(this.radPageViewPage5, "radPageViewPage5");
            this.radPageViewPage5.Name = "radPageViewPage5";
            // 
            // radSchedulerReminder1
            // 
            this.radSchedulerReminder1.AssociatedScheduler = null;
            this.radSchedulerReminder1.ThemeName = null;
            this.radSchedulerReminder1.TimeInterval = 60000;
            // 
            // radDropDownList1
            // 
            resources.ApplyResources(this.radDropDownList1, "radDropDownList1");
            this.radDropDownList1.DropDownAnimationEnabled = true;
            this.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownList1.Name = "radDropDownList1";
            // 
            // radLabel1
            // 
            resources.ApplyResources(this.radLabel1, "radLabel1");
            this.radLabel1.Name = "radLabel1";
            // 
            // radCheckBox1
            // 
            resources.ApplyResources(this.radCheckBox1, "radCheckBox1");
            this.radCheckBox1.Name = "radCheckBox1";
            // 
            // Reserve
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.radPageView1);
            this.Controls.Add(this.radSchedulerNavigator1);
            this.Controls.Add(this.radSchedulerDemo);
            this.Name = "Reserve";
            this.Resizable = false;
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.EventProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.ResourceProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.radPageViewPage1.ResumeLayout(false);
            this.radPageViewPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadCalendar radCalendar1;
        private Telerik.WinControls.UI.RadSchedulerNavigator radSchedulerNavigator1;
        private Telerik.WinControls.RootRadElement object_a65e45d6_6d0c_4754_ac40_31a6d96432e9;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage3;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage4;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage5;
        private Telerik.WinControls.UI.RadDesktopAlert radDesktopAlert1;
        private Telerik.WinControls.UI.RadSchedulerReminder radSchedulerReminder1;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
        private Telerik.WinControls.UI.RadCalendar radCalendar2;
        private Telerik.WinControls.UI.SchedulerBindingDataSource schedulerBindingDataSource1;
        private SchedulerDataDataSet schedulerDataDataSet;
        public Telerik.WinControls.UI.RadScheduler radSchedulerDemo;
    }
}
