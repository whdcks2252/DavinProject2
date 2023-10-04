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
using System.Windows.Controls.Primitives;
using CalibrationChecker.Util;
using CalibrationChecker.Enum;
using System.Windows;

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
            string filePath = FileRoot.FileRootVale; //파일경로.
            string fileName=mainViewModel.FileNameTxt;
            try
            {
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    var records = csv.GetRecords<S_ParameterData>(); // MyClass는 CSV의 각 열을 나타내는 클래스여야 합니다.

                    foreach (var record in records)
                    {
                        S_ParameterData parameterData = record;
                        s_ParameterRepository.SaveData(ref parameterData, ref fileName);
                    }

                }
                if (fileName.Contains(FileEnum.P1.ToString()))//p1파일 일시
                {

                    if (FileCount.FileP1 == true)
                    {
                        throw new Exception();
                    }
                    List<S_ParamDTO> s_ParamDTOs = s_ParameterRepository.GetDatasP1();

                    var groupedData = s_ParamDTOs.GroupBy(data => data.timestamp);
                    foreach (var group in groupedData)
                    {
                        List<S_ParamDTO> dto = group.ToList();
                        mainViewModel.PlotModelmp.ChageCharMethod(ref dto, ref fileName);

                    }

                    FileCount.FileP1 = true;
                    mainViewModel.IsCheckedS11 = true;
                    mainViewModel.IsCheckedS21 = true;


                }
                else if (fileName.Contains(FileEnum.P2.ToString()))//p2 파일 일시
                {
                    if (FileCount.FileP2 == true)
                    {
                        throw new Exception();
                    }
                    List<S_ParamDTO> s_ParamDTOs = s_ParameterRepository.GetDatasP2();

                    var groupedData = s_ParamDTOs.GroupBy(data => data.timestamp);
                    foreach (var group in groupedData)
                    {
                        List<S_ParamDTO> dto = group.ToList();
                        mainViewModel.PlotModelmp.ChageCharMethod(ref dto, ref fileName);

                    }
                    FileCount.FileP2 = true;
                    mainViewModel.IsCheckedS12 = true;
                    mainViewModel.IsCheckedS22 = true;
                }

            }
            catch (Exception ex) { MessageBox.Show("파일열기 실패"); }
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
