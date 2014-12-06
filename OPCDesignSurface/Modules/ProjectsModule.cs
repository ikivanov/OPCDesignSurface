using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPCDemo
{
    public partial class ProjectsModule : UserControl
    {
        const string DASHBOARD = "Dashboard";
        const string TODAY = "Today";
        const string PROJECTS = "Projects";
        const string TASKS = "Tasks";
        const string EMAILS = "Emails";
        const string CALENDAR = "Calendar";
        const string PEOPLE = "People";
        const string REPORTS = "Reports";
        const string HISTORY = "History";
        const string OPTIONS = "Options";
        const string CHAT = "Chat";

        const int PROJECTS_NODE_ID = 3;

        public ProjectsModule()
        {
            InitializeComponent();
        }

        private void ProjectsModule_Load(object sender, EventArgs e)
        {
            treeList.ExpandAll();
            //treeList.ExportToXml(@"c:\treelist.xml");

            var node = treeList.FindNodeByID(PROJECTS_NODE_ID); //this is the id of the Projects Module
            if (node != null)
            {
                treeList.FocusedNode = node;
            }
        }

        private void treeList_AfterFocusNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            var nodeText = e.Node.GetDisplayText(this.treeListColumn2);

            if (nodeText == "OPC") return;

            if (nodeText.IndexOf(DASHBOARD) == 0 || 
                e.Node.ParentNode.GetDisplayText(this.treeListColumn2).IndexOf(DASHBOARD) == 0)
            {
                this.AddSubModule(new DashboardSubModule());
            }
            else if (nodeText.IndexOf(TODAY) == 0 ||
                e.Node.ParentNode.GetDisplayText(this.treeListColumn2).IndexOf(TODAY) == 0)
            {
                this.AddSubModule(new TodaySubModule());
            }
            else if (nodeText.IndexOf(PROJECTS) == 0 ||
                  e.Node.ParentNode.GetDisplayText(this.treeListColumn2).IndexOf(PROJECTS) == 0)
            {
                this.AddSubModule(new ProjectsSubModule());
            }
            else if (nodeText.IndexOf(TASKS) == 0 ||
                  e.Node.ParentNode.GetDisplayText(this.treeListColumn2).IndexOf(TASKS) == 0)
            {
                this.AddSubModule(new TasksSubModule());
            }
            else if (nodeText.IndexOf(EMAILS) == 0 ||
                  e.Node.ParentNode.GetDisplayText(this.treeListColumn2).IndexOf(EMAILS) == 0)
            {
                this.AddSubModule(new EmailsSubModule());
            }
            else if (nodeText.IndexOf(CALENDAR) == 0 ||
                  e.Node.ParentNode.GetDisplayText(this.treeListColumn2).IndexOf(CALENDAR) == 0)
            {
                this.AddSubModule(new CalendarSubModule());
            }
            else if (nodeText.IndexOf(PEOPLE) == 0 ||
                  e.Node.ParentNode.GetDisplayText(this.treeListColumn2).IndexOf(PEOPLE) == 0)
            {
                this.AddSubModule(new PeopleSubModule());
            }
            else if (nodeText.IndexOf(REPORTS) == 0 ||
                  e.Node.ParentNode.GetDisplayText(this.treeListColumn2).IndexOf(REPORTS) == 0)
            {
                this.AddSubModule(new ReportsSubModule());
            }
            else if (nodeText.IndexOf(HISTORY) == 0 ||
                  e.Node.ParentNode.GetDisplayText(this.treeListColumn2).IndexOf(HISTORY) == 0)
            {
                this.AddSubModule(new HistorySubModule());
            }
            else if (nodeText.IndexOf(OPTIONS) == 0 ||
                  e.Node.ParentNode.GetDisplayText(this.treeListColumn2).IndexOf(OPTIONS) == 0)
            {
                this.AddSubModule(new OptionsSubModule());
            }
        }

        private void AddSubModule(UserControl subModule)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(subModule);
            subModule.Dock = DockStyle.Fill;
            var r = subModule as IRibbonModule;
            if (r != null)
            {
                (this.ParentForm as MainForm).ribbonControl1.MergeRibbon(r.Ribbon);
            }
        }
    }
}
