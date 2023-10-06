using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationChecker.Util
{
    public class CalFileStatic
    {
        public static int Open_0File = 0;
        public static int Open_1File = 0;
        public static int Short_0File = 0;
        public static int Short_1File = 0;
        public static int Load_0File = 0;
        public static int Load_1File = 0;
        public static int ThruFile = 0;
        public static int LoadBothFile = 0;

        public static void Reset()
        {
             Open_0File = 0;
             Open_1File = 0;
             Short_0File = 0;
             Short_1File = 0;
             Load_0File = 0;
             Load_1File = 0;
             ThruFile = 0;
             LoadBothFile = 0;
         }

    }
}
