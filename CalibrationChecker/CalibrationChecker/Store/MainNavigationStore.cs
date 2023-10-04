using CalibrationChecker.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationChecker.Store
{
   public class MainNavigationStore : ViewModelBase
    {
        private INotifyPropertyChanged currentViewModel;

        public INotifyPropertyChanged CurrentViewModel
        {
            get { return currentViewModel; }
            set
            {
                if (currentViewModel != value)
                {
                    currentViewModel = value;
                    CurrentViewModelChanged.Invoke();
                    currentViewModel = null;
                }
            }

        }
        public Action CurrentViewModelChanged { get; set; }
    }
}
