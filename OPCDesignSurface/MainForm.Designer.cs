namespace OPCDemo
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
            this.modulesNavBar = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.navigationBarItem3 = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.navigationBarItem4 = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.navigationBarItem5 = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.navigationBarItem6 = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.navigationBarItem7 = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.navigationBarItem8 = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.rpHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpView = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.modulesNavBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // modulesNavBar
            // 
            this.modulesNavBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.modulesNavBar.Items.AddRange(new DevExpress.XtraBars.Navigation.NavigationBarItem[] {
            this.navigationBarItem3,
            this.navigationBarItem4,
            this.navigationBarItem5,
            this.navigationBarItem6,
            this.navigationBarItem7,
            this.navigationBarItem8});
            this.modulesNavBar.Location = new System.Drawing.Point(0, 521);
            this.modulesNavBar.Name = "modulesNavBar";
            this.modulesNavBar.Size = new System.Drawing.Size(784, 45);
            this.modulesNavBar.TabIndex = 2;
            this.modulesNavBar.Text = "officeNavigationBar1";
            this.modulesNavBar.SelectedItemChanged += new DevExpress.XtraBars.Navigation.NavigationBarItemClickEventHandler(this.modulesNavBar_SelectedItemChanged);
            // 
            // navigationBarItem3
            // 
            this.navigationBarItem3.Name = "navigationBarItem3";
            this.navigationBarItem3.Text = "Projects";
            // 
            // navigationBarItem4
            // 
            this.navigationBarItem4.Name = "navigationBarItem4";
            this.navigationBarItem4.Text = "Mail";
            // 
            // navigationBarItem5
            // 
            this.navigationBarItem5.Name = "navigationBarItem5";
            this.navigationBarItem5.Text = "Calendar";
            // 
            // navigationBarItem6
            // 
            this.navigationBarItem6.Name = "navigationBarItem6";
            this.navigationBarItem6.Text = "People";
            // 
            // navigationBarItem7
            // 
            this.navigationBarItem7.Name = "navigationBarItem7";
            this.navigationBarItem7.Text = "Tasks";
            // 
            // navigationBarItem8
            // 
            this.navigationBarItem8.Name = "navigationBarItem8";
            this.navigationBarItem8.Text = "Notes";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 2;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpHome,
            this.rpView});
            this.ribbonControl1.Size = new System.Drawing.Size(784, 142);
            // 
            // rpHome
            // 
            this.rpHome.Name = "rpHome";
            this.rpHome.Text = "Home";
            // 
            // rpView
            // 
            this.rpView.Name = "rpView";
            this.rpView.Text = "View";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 379);
            this.panel1.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.modulesNavBar);
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Name = "MainForm";
            this.Text = "OPC Design Surface";
            ((System.ComponentModel.ISupportInitialize)(this.modulesNavBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.OfficeNavigationBar modulesNavBar;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItem3;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItem4;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItem5;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItem6;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItem7;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItem8;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpHome;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpView;
        private System.Windows.Forms.Panel panel1;
    }
}

