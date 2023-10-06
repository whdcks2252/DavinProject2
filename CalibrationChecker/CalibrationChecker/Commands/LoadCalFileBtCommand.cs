using CalibrationChecker.View;
using CalibrationChecker.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using VNA_Calibration;

namespace CalibrationChecker.Commands
{
    public class LoadCalExportBtCommand : CommandBase
    {
        private readonly MainViewModel mainViewModel;
        public LoadCalExportBtCommand(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
        }
        private void nevigate()
        {

            //CalLoader loader = new CalLoader(new CalLoadTextFile(20_000_000, 10_000, 4_000_000_000, 6_000_000_000, true));
             CalType.Load.ToString();
        }

        public override bool CanExecute(object parameter)
        {
            return true;

        }

        public override void Execute(object parameter)
        {

            CalLoader loader = new CalLoader(new CalLoadTextFile(20_000_000, 10_000, 4_000_000_000, 6_000_000_000, true));
            nevigate();
        }
    }
}
