using CalibrationChecker.View;
using CalibrationChecker.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CalibrationChecker.Commands
{
    public class LoadCalFileBtCommand : CommandBase
    {
        private readonly MainViewModel mainViewModel;

        public LoadCalFileBtCommand(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
        }
        private void nevigate()
        {
           


        }

        public override bool CanExecute(object parameter)
        {
            return true;

        }

        public override void Execute(object parameter)
        {

            nevigate();
        }
    }
}
