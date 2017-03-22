using System;
using System.AddIn.Pipeline;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddInSideViews
{
    [AddInBase]
    public abstract class ImageProcessorAddInView
    {
        public abstract byte[] ProcessImageBytes(byte[] pixels);

        public abstract void Initialize(AddInSideViews.HostObject hostobj);
       
    }
}
