using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HostWpfApplication
{
    public class AutomationHost:HostSideViews.HostObject
    {
        private ProgressBar progressBar;

        public AutomationHost(ProgressBar progressBar)
        {
            this.progressBar = progressBar;
        }

        public override void ReportProgress(float percent)
        {
            this.progressBar.Value = percent;
        }

    }
}
