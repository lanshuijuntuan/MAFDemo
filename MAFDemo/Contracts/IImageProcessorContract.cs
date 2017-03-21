using System;
using System.AddIn.Contract;
using System.AddIn.Pipeline;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contracts
{
    [AddInContract]
    public interface IImageProcessorContract : IContract
    {
        byte[] ProcessImageBytes(byte[] pixels);

        void Initalize(IHostObjectContract contract);

    }
}
