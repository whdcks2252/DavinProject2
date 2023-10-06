using CalibrationChecker.Enum;
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
        private static List<S_ParameterData> S_PArameterDatasP1 = new List<S_ParameterData>();
        private static List<S_ParameterData> S_PArameterDatasP2 = new List<S_ParameterData>();
        public void SaveData(ref S_ParameterData datas,ref string fileName)
        {
            if (fileName.Contains(FileEnum.P1.ToString())) 
            {
                S_PArameterDatasP1.Add(datas);
            }
            else if(fileName.Contains(FileEnum.P2.ToString()))
            {
                S_PArameterDatasP2.Add(datas);
            }

        }

        public void ClearP1() { S_PArameterDatasP1.Clear(); }
        public void ClearP2() { S_PArameterDatasP2.Clear(); }


        public List<S_ParamDTO> GetDatasP1()
        {
            List<S_ParamDTO> s_ParamDTOs = new List<S_ParamDTO>();
            foreach (S_ParameterData data in S_PArameterDatasP1)
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
        public List<S_ParamDTO> GetDatasP2()
        {
            List<S_ParamDTO> s_ParamDTOs = new List<S_ParamDTO>();
            foreach (S_ParameterData data in S_PArameterDatasP2)
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


