using System;
using System.AddIn.Pipeline;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddInSideAdapters
{
    public  class HostObjectToContractAdapter:AddInSideViews.HostObject
    {
        private Contracts.IHostObjectContract contract;

        private ContractHandle handle;

        public HostObjectToContractAdapter(Contracts.IHostObjectContract contract)
        {
            this.contract = contract;
            this.handle = new ContractHandle(contract);
        }

        public override void ReportProgress(float progresspercent)
        {
            contract.ReportProgress(progresspercent);
        }
    }
}
