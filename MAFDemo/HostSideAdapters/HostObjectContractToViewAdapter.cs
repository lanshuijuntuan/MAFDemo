using System;
using System.AddIn.Pipeline;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostSideAdapters
{
   
    public class HostObjectContractToViewAdapter:ContractBase,Contracts.IHostObjectContract
    {

        private HostSideViews.HostObject view;

       
        public HostObjectContractToViewAdapter(HostSideViews.HostObject mHostObject)
        {
            view = mHostObject;
        }


        public void ReportProgress(float percent)
        {
            view.ReportProgress(percent);
        }
    }
}
