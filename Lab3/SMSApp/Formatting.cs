using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApp
{
    public static  class Formatting
    {
         public delegate string FormatterDelegate(string text);
         public static string FormatWithTime(string text)
        {
            return $"[{DateTime.Now}] {text}";
        }

         public static string NoFormat(string text)
        {
            return text;
        }
         public static string UpperCaseFormat(string text)
        {
            return text.ToUpper();
        }
         public static string LowerCaseFormat(string text)
        {
            return text.ToLower();
        }
    }
}
