using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDBatchToolsHelper
{
    public class Tools
    {
        public static string formatPath(String p)
        {
            if (p.Contains(" ") && !p.Contains("\""))
            {
                var s = "\"" + p + "\"";
                return s.Trim();
            }
            else
                return p.Trim();
        }

    }
}
