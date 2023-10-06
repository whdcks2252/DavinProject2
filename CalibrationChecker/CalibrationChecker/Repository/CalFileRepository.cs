using CalibrationChecker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationChecker.Repository
{
    public class CalFileRepository
    {
       private readonly List<CalData> data=new List<CalData>();

        public void save(ref CalData calData)
        {
            data.Add(calData);
        }

        public List<CalData> get()
        {
           return data;
        }
    }
}
