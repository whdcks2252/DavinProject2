using CalibrationChecker.Repository;
using CalibrationChecker.Store;
using CalibrationChecker.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationChecker.Commands
{
    public class CheckBoxCommandP2 : CommandBase
    {
        private readonly MainViewModel mainViewModel;
        private readonly S_ParameterRepository s_ParameterRepository;

        public CheckBoxCommandP2(MainViewModel mainViewModel, S_ParameterRepository s_ParameterRepository)
        {
            this.mainViewModel = mainViewModel;
            this.s_ParameterRepository = s_ParameterRepository;
        }
        private void check()
        {
            List<S_ParamDTO> s_ParamDTOP1 = s_ParameterRepository.GetDatasP1();
            List<S_ParamDTO> s_ParamDTOP2 = s_ParameterRepository.GetDatasP2();
            bool s11 = mainViewModel.IsCheckedS11;
            bool s12 = mainViewModel.IsCheckedS12;
            bool s21 = mainViewModel.IsCheckedS21;
            bool s22 = mainViewModel.IsCheckedS22;

            mainViewModel.PlotModelmp.CheckChartMethod(ref s11, ref s12, ref s21, ref s22, ref s_ParamDTOP1, ref s_ParamDTOP2);

        }

        private bool FileLoding()
        {
            if (FileCount.FileP2 == true)
            {
                return true;
            }
            else
                return false;

        }

        public override bool CanExecute(object parameter)
        {
            return FileLoding();

        }

        public override void Execute(object parameter)
        {
            check();
        }
    }
}
