using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDBatchToolsHelper
{
    public class Sbsmutator : IBatchTool
    {
        public Sbsmutator()
        {

        }
        
        public string getCmdLine()
        {
            String s = getToolname();

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
            return getToolname() + "--help";
        }

    }
}
