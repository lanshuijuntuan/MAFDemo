using System;
using System.AddIn.Pipeline;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostSideAdapters
{
    [HostAdapter]
    public class ImageProcessorContractToViewHostAdapter:HostSideViews.ImageProcessorHostView
    {
        private Contracts.IImageProcessorContract contract;

        private ContractHandle contractHandle;

        public ImageProcessorContractToViewHostAdapter(Contracts.IImageProcessorContract contract)
        {
            this.contract = contract;
            contractHandle = new ContractHandle(contract);
        }

        public override byte[] ProcessImageBytes(byte[] pixels)
        {
            return contract.ProcessImageBytes(pixels);
        }

        public override void Initialize(HostSideViews.HostObject host)
        {
            HostObjectContractToViewAdapter hostAdapter = new HostObjectContractToViewAdapter(host);
            contract.Initalize(hostAdapter);
        }
    }
}
