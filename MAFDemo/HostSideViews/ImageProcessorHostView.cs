using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostSideViews
{
    public abstract class ImageProcessorHostView 
    {
        public abstract byte[] ProcessImageBytes(byte[] pixels);

        public abstract void Initialize(HostSideViews.HostObject host);
    }
}
