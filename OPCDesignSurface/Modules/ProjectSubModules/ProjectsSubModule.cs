using System.Windows.Forms;
using DevExpress.DevAV;
using DevExpress.DevAV.ViewModels;
using DevExpress.Mvvm;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;

namespace OPCDemo
{
    public partial class ProjectsSubModule : UserControl, IRibbonModule
    {
        public ProjectsSubModule()
        {
            InitializeComponent();

            //this.gridView1.data
        }

        public DevExpress.XtraBars.Ribbon.RibbonControl Ribbon
        {
            get 
            {
                return this.ribbonControl1;
            }
        }

        private void ProjectsSubModule_Load(object sender, EventArgs e)
        {
        }
    }

    public class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }

    public class ProjectsDS
    {
        List<Project> projects = new List<Project>();

        public ProjectsDS()
        {
            projects.Add(new Project { ID = 1, Name = "Project1", Start = new DateTime(2014, 12, 5), End = new DateTime(2014, 12, 6) });
            projects.Add(new Project { ID = 2, Name = "Project2", Start = new DateTime(2014, 12, 5), End = new DateTime(2014, 12, 6) });
            projects.Add(new Project { ID = 3, Name = "Project3", Start = new DateTime(2014, 12, 5), End = new DateTime(2014, 12, 7) });
        }

        public List<Project> Projects
        {
            get
            {
                return this.projects;
            }
        }
    }
}
