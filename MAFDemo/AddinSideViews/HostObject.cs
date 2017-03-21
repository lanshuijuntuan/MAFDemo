using System;
using System.AddIn.Pipeline;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddInSideViews
{
   
    public abstract class HostObject
    {
        public abstract void ReportProgress(float progresspercent);
    }
}
