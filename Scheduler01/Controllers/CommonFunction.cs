using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages;
using Scheduler01.Models;
using Scheduler01.Controllers;

namespace Scheduler01.ExtensionMethods {
    public static class StringExtensions
    {
    
        public static string DisplayDateTime(this string s, bool hasTime = false) {
            string output = "";
            if (!s.IsEmpty())
            {
                string year, month, day, hour, minute;

                year = s.Substring(0, 4);
                month = s.Substring(4, 2);
                day = s.Substring(6, 2);

                output = day + "/" + month + "/" + year;

                if (hasTime)
                {
                    hour = s.Substring(8, 2);
                    minute = s.Substring(10, 2);
                    output += " " + hour + ":" + minute;
                }
            }

            return output;
        }

        public static string DisplayAge(this string s, string ageUnit = "", bool showUnit = true)
        {
            string output = "";
            if (s != null && !s.IsEmpty())
            {
                output = s.Substring(0, s.Length - 3);
                if (showUnit)
                {
                    output += ageUnit;
                }

                return output;
            }
            return "";
        }

    }
}

namespace Scheduler01.Controllers
{
    public  class CommonFunction
    {
       
    }
}