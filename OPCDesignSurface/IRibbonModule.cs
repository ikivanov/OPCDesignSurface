using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPCDemo
{
    public interface IRibbonModule
    {
        RibbonControl Ribbon { get; }
    }
}
