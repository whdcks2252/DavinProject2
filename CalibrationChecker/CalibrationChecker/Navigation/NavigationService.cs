using CalibrationChecker.Store;
using CalibrationChecker.View;
using CalibrationChecker.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace CalibrationChecker.Navigation
{
   public class NavigationService 
    {
        private readonly MainNavigationStore mainNavigationStore;
        private INotifyPropertyChanged _CurrentViewModel;
        public INotifyPropertyChanged CurrentViewModel
        {
            get
            { return _CurrentViewModel; }

            set { _CurrentViewModel = value; mainNavigationStore.CurrentViewModel = value; }
        }

        public NavigationService(MainNavigationStore mainNavigationStore)
        {
            this.mainNavigationStore = mainNavigationStore;
        }

        public void Navigate(NaviType naviType)
        {
            
            switch (naviType)
            {
                case NaviType.MainControl:
                    CurrentViewModel = (ViewModelBase)App.Current.Services.GetService(typeof(MainViewModel));
                    break;
                case NaviType.LoadCalFile:
                    CurrentViewModel = (ViewModelBase)App.Current.Services.GetService(typeof(LoadCalFileViewModel));
                    break;
                default: return;
            }

        }
    }
}
