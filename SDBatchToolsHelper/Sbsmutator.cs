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
    public class Sbsmutator : IBatchTool
    {
        private string _inputpath = "";
        private string _outputpath = "";
        private string _presets_path = ""; 

        public enum Modes
        {
            graph_parameters_editor,
            info,
            specialization,
            update
        }

        public Sbsmutator()
        {

        }

        public Modes Mode { get; set; } = Modes.info;

        public bool NoDependency { get; set; } = false;
        public bool OutputMerge { get; set; } = false;
        public bool HideParameters { get; set; } = false;

        public string InputGraph { get; set; } = "";
        public string OutputName { get; set; } = "";
        public string Alias { get; set; } = "";
        public string OutputGraphName { get; set; } = "";
        public string ConnectImage { get; set; } = "";
        public string ConnectInput { get; set; } = "";
        public string AdditionalParams { get; set; } = "";
        public string SwitchToConstant { get; set; } = "";
        public string SetDefaultValue { get; set; } = "";
   
        public string InputFile
        {
            get
            {
                return _inputpath;
            }
            set
            {
                _inputpath = Tools.formatPath(value);
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

        public string PresetsPath
        {
            get
            {
                return _presets_path;
            }
            set
            {
                _presets_path = Tools.formatPath(value);
            }
        }
        public string getCmdLine()
        {
            String s = getToolname();

            if(Mode == Modes.graph_parameters_editor)
            {
                s += " graph-parameters-editor";

                if (InputFile != "")
                    s += " --input " + InputFile;

                if (InputGraph != "")
                    s += " --input-graph " + InputGraph;

                if (OutputName != "")
                    s += " --output-name " + OutputName;

                if (OutputPath != "")
                    s += " --output-path " + OutputPath;

                if (PresetsPath != "")
                    s += " --presets-path " + PresetsPath;

                if (SwitchToConstant != "")
                    s += " --switch-to-constant " + SwitchToConstant;

                if (SetDefaultValue != "")
                    s += " --set-default-value " + SetDefaultValue;

                if (AdditionalParams != "")
                    s += " " + AdditionalParams;
            }

            else if (Mode == Modes.info)
            {
                s += " info";

                if (InputFile != "")
                    s += " --input " + InputFile;
            }

            else if (Mode==Modes.specialization)
            {
                s += " specialization";

                if (InputFile != "")
                    s += " --input " + InputFile;

                if (InputGraph != "")
                    s += " --input-graph " + InputGraph;

                if (OutputMerge)
                    s += " --output-merge";

                if (PresetsPath != "")
                    s += " --presets-path " + PresetsPath;

                if (Alias != "")
                    s += " --alias " + Alias;

                if (OutputPath != "")
                    s += " --output-path " + OutputPath;

                if (OutputName != "")
                    s += " --output-name " + OutputName;

                if (OutputGraphName != "")
                    s += " --output-graph-name " + OutputGraphName;

                if (ConnectImage != "")
                    s += " --connect-image " + ConnectImage;

                if (ConnectInput != "")
                    s += " --connect-input " + ConnectInput;

                if (HideParameters)
                    s += " --hide-parameters";
            }

            else if(Mode == Modes.update)
            {
                s += " update";

                if (InputFile != "")
                    s += " --inputs " + InputFile;

                if (OutputPath != "")
                    s += " --output-path " + OutputPath;

                if (OutputName != "")
                    s += " --output-name " + OutputName;

                if (PresetsPath != "")
                    s += " --presets-path " + PresetsPath;

                if (Alias != "")
                    s += " --alias " + Alias;

                if (NoDependency)
                    s += " --no-dependency";
            }

            return s.Trim();
        }

        public string getToolname()
        {
            if (Environment.OSVersion.Platform == PlatformID.Unix
                || Environment.OSVersion.Platform == PlatformID.MacOSX)
                return "sbsmutator";
            else
                return "sbsmutator.exe";
        }

        public string getVersionCmd()
        {
            return getToolname() + "--version";
        }

        public string getHelpCmd()
        {
            var s =  getToolname() + "--help";

            switch(Mode)
            {
                case Modes.graph_parameters_editor:
                    s += " graph-parameters-editor";
                    break;
                case Modes.info:
                    s += " info";
                    break;
                case Modes.specialization:
                    s += " specialization";
                    break;
                case Modes.update:
                    s += " update";
                    break;
            }

            return s;
        }

    }
}
