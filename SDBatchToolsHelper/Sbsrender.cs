using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDBatchToolsHelper
{
    public enum SbsrenderModes
    {
        info,
        render
    }

    public class Sbsrender : IBatchTool
    {
        

        public Sbsrender()
        {
            Mode = SbsrenderModes.render;
        }

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

            return s.Trim();
        }

        public string getToolname()
        {
            return "sbsrender.exe";
        }

        public string getVersionCmd()
        {
            return getToolname() + "--version";
        }

        public string getHelpCmd()
        {
            return getToolname() + "--help";
        }

        public SbsrenderModes Mode { get; set; }
    }
}
