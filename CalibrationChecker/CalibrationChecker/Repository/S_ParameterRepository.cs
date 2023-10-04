using CalibrationChecker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationChecker.Repository
{
    public class S_ParameterRepository
    {
        private static List<S_ParameterData> S_PArameterDatas = new List<S_ParameterData>();

        public void SaveData(ref S_ParameterData datas)
        {
            S_PArameterDatas.Add(datas);
        }

        public List<S_ParamDTO> GetDatas()
        {
            List<S_ParamDTO> s_ParamDTOs = new List<S_ParamDTO>();
            foreach (S_ParameterData data in S_PArameterDatas)
            {
                S_ParamDTO s_ParamDTO = new S_ParamDTO()
                {
                    UTCtime = data.UTCtime,
                    timestamp = data.timestamp,
                    freq = data.freq,
                    S11Real = data.S11Real,
                    S11Imag = data.S11Imag,
                    S12Real = data.S12Real,
                    S12Imag = data.S12Imag,
                    S21Real = data.S21Real,
                    S21Imag = data.S21Imag,
                    S22Real = data.S22Real,
                    S22Imag = data.S22Imag,
                };

                s_ParamDTOs.Add(s_ParamDTO);
            }
            return s_ParamDTOs;
        }
    }
}


