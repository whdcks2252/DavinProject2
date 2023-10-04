using CalibrationChecker.Navigation;
using CalibrationChecker.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationChecker.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly MainNavigationStore mainNavigationStore;
        private INotifyPropertyChanged currentViewModel;

        public MainWindowViewModel(MainNavigationStore mainNavigationStore, NavigationService navigationService)
        {
            this.mainNavigationStore = mainNavigationStore;
            mainNavigationStore.CurrentViewModelChanged += CurrentViewModelChange;
            navigationService.Navigate(NaviType.MainControl);

        }

        public INotifyPropertyChanged CurrentViewModel
        {
            get { return currentViewModel; }
            set
            {
                if (currentViewModel != value)
                {
                    currentViewModel = value;
                    OpPropertyChanged();
                }
            }
        }

        private void CurrentViewModelChange()
        {
            CurrentViewModel = mainNavigationStore.CurrentViewModel;
        }


    }
}
