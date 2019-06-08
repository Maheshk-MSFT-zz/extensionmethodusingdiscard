using System;
using System.Collections.Generic;
using System.Text;

//using Discards to ignore the out variable - https://blogs.msdn.microsoft.com/mazhou/2017/06/27/c-7-series-part-4-discards/

namespace extensionmethodVs2017
{
    public static class ExtensionMethods
    {
        public static bool ToInteg(this string value)
        {
            return int.TryParse(value, out var _);
        }
    }
}
