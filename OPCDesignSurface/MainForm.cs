using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPCDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //select Projects module
            this.modulesNavBar.SelectedItem = navigationBarItem3;
        }

        private void modulesNavBar_SelectedItemChanged(object sender, DevExpress.XtraBars.Navigation.NavigationBarItemEventArgs e)
        {
            var selectedItem = e.Item;
            if (selectedItem.Text == "Projects")
            {
                this.AddModule(new ProjectsModule());
            } 
            else if (selectedItem.Text == "Mail")
            {
                ribbonControl1.Hide();
                this.AddModule(new MailModule());
            } 
            else if (selectedItem.Text == "People")
            {
                ribbonControl1.Hide();
                this.AddModule(new ContactsModule());
            }
            else if (selectedItem.Text == "Calendar")
            {
                ribbonControl1.Hide();
                this.AddModule(new CalendarModule());
            }
            else if (selectedItem.Text == "Tasks")
            {
                ribbonControl1.Hide();
                this.AddModule(new TasksModule());
            }
            else if (selectedItem.Text == "Notes")
            {
                ribbonControl1.Hide();
                this.AddModule(new NotesModule());
            }
        }

        private void AddModule(UserControl module)
        {
            this.ribbonControl1.Visible = module.GetType() == typeof (ProjectsModule);
            this.panel1.Controls.Clear();
            module.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(module);
        }
    }
}
