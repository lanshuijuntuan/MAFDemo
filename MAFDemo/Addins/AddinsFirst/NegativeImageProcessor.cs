﻿using System;
using System.AddIn;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddInFirst
{
    [AddIn("Negative Image Processor",Version="1.0.0.0",
        Publisher="Imaginomics",
        Description="Interts colors to look like a photo negative")]
    public class NegativeImageProcessor:AddInSideViews.ImageProcessorAddInView
    {
        public override byte[] ProcessImageBytes(byte[] pixels)
        {
            int iteration = pixels.Length / 100;
            for (int i = 0; i < pixels.Length - 2; i++)
            {
                pixels[i] = (byte)(255 - pixels[i]);
                pixels[i + 1] = (byte)(255 - pixels[i + 1]);
                pixels[i + 2] = (byte)(255 - pixels[i + 2]);
                
                if(i%iteration==0)
                {
                    host.ReportProgress(i / iteration);
                }
            }
            return pixels;
        }
        private AddInSideViews.HostObject host;
        public override void Initialize(AddInSideViews.HostObject hostobj)
        {
            host = hostobj;
        }
    }
}
