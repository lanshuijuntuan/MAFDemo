using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostSideViews
{
    public abstract class HostObject
    {
        public abstract void ReportProgress(float percent);
    }
}
