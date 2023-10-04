using CalibrationChecker.ViewModel;
using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalibrationChecker.Store;
using CalibrationChecker.Models;
using CalibrationChecker.Repository;

namespace CalibrationChecker.Commands
{
    class LoadFileCommand : CommandBase
    {
        private readonly MainViewModel mainViewModel;
        private readonly S_ParameterRepository s_ParameterRepository;

        public LoadFileCommand(MainViewModel mainViewModel,S_ParameterRepository s_ParameterRepository) 
        { 
          this.mainViewModel = mainViewModel;
          this.s_ParameterRepository = s_ParameterRepository; 
        }
        private void LoadFile()
        {
            string filePath = FileRoot.FileRootVale; // 실제 파일 경로로 바꿔주세요.

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                var records = csv.GetRecords<S_ParameterData>(); // MyClass는 CSV의 각 열을 나타내는 클래스여야 합니다.

                foreach (var record in records)
                {
                  S_ParameterData parameterData = record;
                  s_ParameterRepository.SaveData(ref parameterData);
                }
                
            }

        }


        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            LoadFile();
        }
    }
}
