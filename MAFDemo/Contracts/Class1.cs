using System;
using System.AddIn.Contract;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    [AddinContract]
    public interface IImageProcessorContract:IContract
    {
        byte[] ProcessImageBytes(byte[] pixels);
    }
}
