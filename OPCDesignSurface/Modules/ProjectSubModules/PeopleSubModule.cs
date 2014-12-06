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
    public partial class PeopleSubModule : UserControl, IRibbonModule
    {
        public PeopleSubModule()
        {
            InitializeComponent();
        }

        public DevExpress.XtraBars.Ribbon.RibbonControl Ribbon
        {
            get 
            {
                return this.ribbonControl1;
            }
        }
    }
}
