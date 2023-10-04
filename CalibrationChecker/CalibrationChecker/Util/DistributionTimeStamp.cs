using CalibrationChecker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationChecker.Util
{
    public class DistributionTimeStamp
    {
        public static List<int> SelectTS(ref List<S_ParamDTO> s_ParamDTOs)
        {
            var uniqueTimestamps = s_ParamDTOs.Select(data => data.timestamp).Distinct();
            return uniqueTimestamps.ToList();

        }
    }
}
