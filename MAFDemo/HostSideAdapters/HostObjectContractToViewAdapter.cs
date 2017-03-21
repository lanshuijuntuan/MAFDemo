using System;
using System.AddIn.Pipeline;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostSideAdapters
{
    [HostAdapter]
    public class HostObjectContractToViewAdapter:HostSideViews.HostObject
    {

        private Contracts.IHostObjectContract contract;

        private ContractHandle contractHandle;
        public HostObjectContractToViewAdapter(Contracts.IHostObjectContract mHostObjectContract)
        {
            contract = mHostObjectContract;
            contractHandle = new ContractHandle(contract);
        }


        public override void ReportProgress(float percent)
        {
            contract.ReportProgress(percent);
        }
    }
}
