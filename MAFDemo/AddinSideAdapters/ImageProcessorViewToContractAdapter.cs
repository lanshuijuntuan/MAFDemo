using AddInSideViews;
using System;
using System.AddIn.Pipeline;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddInSideAdapters
{
    [AddInAdapter]
    public class ImageProcessorViewToContractAdapter : ContractBase, Contracts.IImageProcessorContract
    {
        private AddInSideViews.ImageProcessorAddInView view;

        public ImageProcessorViewToContractAdapter(ImageProcessorAddInView view)
        {
            this.view = view;
        }



        public byte[] ProcessImageBytes(byte[] pixels)
        {
            return view.ProcessImageBytes(pixels);
        }


       


        public void Initalize(Contracts.IHostObjectContract contract)
        {
            view.Initialize(new HostObjectToContractAdapter(contract));
        }
    }
}
