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
    public class Sbscooker : IBatchTool
    {

        private string _outputpath ="";
        private string _inputfile = "";
        private string _includesdir = "";

        public Sbscooker()
        {

        }

        public bool NoOptimation { get; set; }
        public bool ExposeOutputSize { get; set; } = true;
        public bool ExposeRandomSeed { get; set; } = true;
        public bool ExposePixelSize { get; set; }
        public bool Merge { get; set; }
        public bool NoArchive { get; set; }

        
        public string Alias { get; set; } = "";
        public string OutputName { get; set; } = "";
        public string SizeLimit { get; set; } = "";

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

        public string InputFile
        {
            get
            {
                return _inputfile;
            }
            set
            {
                _inputfile = Tools.formatPath(value);
            }
        }

        public string IncludesDir {
            get
            {
                return _includesdir;
            }
            set
            {
                _includesdir = Tools.formatPath(value);
            }
        }


        public string getCmdLine()
        {
            String s = getToolname();

            if (Merge)
                s += " --merge";

            if (NoArchive)
                s += " --no-archive";

            if (NoOptimation)
                s += " --no-optimization";

            //Expose Output Size is default activated
            if (!ExposeOutputSize)
                s += "  --expose-output-size 0";

            if (!ExposeRandomSeed)
                s += " --expose-random-seed 0";

            if (ExposePixelSize)
                s += " --expose-pixel-size 1";

            if (IncludesDir != "")
                s += " --includes " + IncludesDir;

            if (Alias != "")
                s += " --alias " + Alias;

            if (OutputName != "")
                s += " --output-name " + OutputName;

            if (OutputPath != "")
                s += " --output-path " + OutputPath;

            if (SizeLimit != "")
                s += " --size-limit " + SizeLimit;

            if (InputFile!="")
                s += " --inputs " + InputFile;
            

            return s.Trim();
        }

        public string getToolname()
        {
            if (Environment.OSVersion.Platform == PlatformID.Unix
                || Environment.OSVersion.Platform == PlatformID.MacOSX)
                return "sbscooker";
            else
                return "sbscooker.exe";
        }

        public string getVersionCmd()
        {
            return getToolname() + "--version";
        }

        public string getHelpCmd()
        {
            return getToolname() + "--help";
        }

    }
}
