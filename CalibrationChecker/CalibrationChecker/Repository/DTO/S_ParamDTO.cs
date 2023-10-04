using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationChecker
{
    public class S_ParamDTO
    {
        public string UTCtime { get; set; }
        public int timestamp { get; set; }
        public Double freq { get; set; }

        //11
        public Double S11Real { get; set; }
        public Double S11Imag { get; set; }
        //12
        public Double S12Real { get; set; }
        public Double S12Imag { get; set; }
        //21
        public Double S21Real { get; set; }
        public Double S21Imag { get; set; }
        //22
        public Double S22Real { get; set; }
        public Double S22Imag { get; set; }

    }
}
