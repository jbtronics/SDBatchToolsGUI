// Copyright 2016 Jan Boehmer
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDBatchToolsHelper
{   

    public class Sbsrender : IBatchTool
    {
        public enum SbsrenderModes
        {
            info,
            render
        }

        public enum RenderOutputFormat
        {
            unset, dds, bmp, ico, jpg, jif, jpeg, jpe, png, tga, targa, tif, tiff, wap, wbmp, wbm, hdr, exr, jp2, webp, jxr, wdp, hdp
        }

        public enum DDSCompression
        {
            unset,
            raw,
            dxt1,
            dxt3,
            dxt5
        }

        //Fields
        private string _inputfile = "";
        private string _outputpath = "";

        public Sbsrender()
        {
            Mode = SbsrenderModes.render;
            Compression = DDSCompression.unset;
            OutputFormat = RenderOutputFormat.unset;
        }


        #region Properties
        public string InputFile {
            get
            {
                return _inputfile;
            }
            set
            {
                //Ensure "" on Paths with whitespaces
                _inputfile = Tools.formatPath(value);
            }
        }

        public string OutputPath
        {
            get
            {
                return _outputpath;
            }
            set
            {
                _outputpath = Tools.formatPath(value);
            }
        }

        public DDSCompression Compression { get; set; }

        public RenderOutputFormat OutputFormat { get; set; }

        public int MemoryBudget { get; set; } = 1000;

        public string InputGraph { get; set; } = "";
        public string InputGraphOutput { get; set; } = "";
        public string OutputName { get; set; } = "";
        public string Engine { get; set; } = "";
        public string SetValue { get; set; } = "";
        public string SetEntry { get; set; } = "";
        public string SetResolution { get; set; } = "";
        public string SetPixelSize { get; set; } = "";
        public string SetSeed { get; set; } = "";

        public SbsrenderModes Mode { get; set; }
        #endregion

        public string getCmdLine()
        {
            String s = getToolname();

            switch(Mode)
            {
                case SbsrenderModes.info:
                    s += " info";
                    break;
                case SbsrenderModes.render:
                    s += " render";
                    break;
            }

            if (Mode == SbsrenderModes.info)
            {
                if(InputFile!="")
                {
                    s += " --input " + InputFile;
                }
            }
            else
            {
                if (InputGraph != "")
                    s += " --input-graph " + InputGraph;           

                if(InputGraphOutput!="")
                    s += " --input-graph-output " + InputGraphOutput;              

                if(OutputName!="")
                    s += " --output-name " + OutputName;

                if (OutputPath != "")
                    s += "--output-path " + OutputPath;

                if (OutputFormat != RenderOutputFormat.unset)
                    s += " --output-format " + OutputFormat.ToString();

                if (Compression != DDSCompression.unset)
                    s += " --output-format-compression " + Compression.ToString();

                if (SetValue != "")
                    s += " --set-value " + SetValue;

                if (SetEntry != "" && SetEntry != "@")
                    s += " --set-entry " + SetEntry;

                if (Engine != "")
                    s += " --engine " + Engine;

                if (MemoryBudget != 0 && MemoryBudget != 1000)
                    s += " --memory-budget " + MemoryBudget;

                if(SetPixelSize!="")
                    s += " --set-value pixelsize@" + SetPixelSize;

                if(SetResolution!="")              
                    s += " --set-value outputsize@" + SetResolution;               

                if (InputFile!="")
                    s += " --inputs " + InputFile;   

            }

            return s.Trim();
        }

        public string getToolname()
        {
            if (Environment.OSVersion.Platform == PlatformID.Unix
               || Environment.OSVersion.Platform == PlatformID.MacOSX)
            {
                return "sbsrender";
            }
            else
            {
                return "sbsrender.exe";
            }
        }

        public string getVersionCmd()
        {
            return getToolname() + "--version";
        }

        public string getHelpCmd()
        {
            var s = getToolname() + "--help";
            switch (Mode)
            {
                case SbsrenderModes.info:
                    s += " info";
                    break;
                case SbsrenderModes.render:
                    s += " render";
                    break;
            }

            return s;
        }

       

        
    }
}
