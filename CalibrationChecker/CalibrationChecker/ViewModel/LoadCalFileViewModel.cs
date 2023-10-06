using CalibrationChecker.Commands;
using CalibrationChecker.Commands.LoadCalFileCommands;
using CalibrationChecker.Enum;
using CalibrationChecker.Models;
using CalibrationChecker.Navigation;
using CalibrationChecker.Repository;
using CalibrationChecker.Store;
using CalibrationChecker.Util;
using CalibrationChecker.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CalibrationChecker.ViewModel
{
    public class LoadCalFileViewModel : ViewModelBase
    {
        private readonly NavigationService _navigationService;
        private readonly CalFileRepository calFileRepository;
        private string open_0Txt;
        private string open_1Txt;
        private string short_0Txt;
        private string short_1Txt;
        private string load_0Txt;
        private string load_1Txt;
        private string thruTxt;
        private string loadBoth;

        private void MainControlView(object _)
        {
            _navigationService.Navigate(NaviType.MainControl);

        }
        private void ClearAllCalFile(object _)
        {
            calFileRepository.get().Clear();
            CalFileStatic.Reset();
            Open_0Txt = null;
            Short_0Txt = null;
            Load_0Txt = null;
            Open_1Txt = null;
            Short_1Txt = null;
            Load_1Txt = null;
            ThruTxt = null;
            LoadBoth = null;
        }

        public LoadCalFileViewModel(NavigationService navigationService, CalFileRepository calFileRepository)
        {
            this.calFileRepository = calFileRepository;
            this._navigationService = navigationService;
            LoadBt = new RelayCommand<object>(MainControlView);
            ClearAllBt = new RelayCommand<object>(ClearAllCalFile);
            LoadAutoBt = new LoadAutoCommand(this, calFileRepository);
            LoadCalFileBt = new LoadCalFileCommand(this, calFileRepository);
        }

        public ICommand LoadBt { get; set; }
        public ICommand LoadCalFileBt { get; set; }
        public ICommand ClearAllBt { get; set; }
        public ICommand LoadAutoBt { get; set; }

        public string Open_0Txt
        {
            get { return open_0Txt; }
            set
            {
                if (open_0Txt != value)
                {
                    open_0Txt = value;

                    OpPropertyChanged("Open_0Txt");
                }
            }
        }
        public string Open_1Txt
        {
            get { return open_1Txt; }
            set
            {
                if (open_1Txt != value)
                {
                    open_1Txt = value;

                    OpPropertyChanged("Open_1Txt");
                }
            }
        }
        public string Short_0Txt
        {
            get { return short_0Txt; }
            set
            {
                if (short_0Txt != value)
                {
                    short_0Txt = value;

                    OpPropertyChanged("Short_0Txt");
                }
            }
        }
        public string Short_1Txt
        {
            get { return short_1Txt; }
            set
            {
                if (short_1Txt != value)
                {
                    short_1Txt = value;

                    OpPropertyChanged("Short_1Txt");
                }
            }
        }
        public string Load_0Txt
        {
            get { return load_0Txt; }
            set
            {
                if (load_0Txt != value)
                {
                    load_0Txt = value;

                    OpPropertyChanged("Load_0Txt");
                }
            }
        }
        public string Load_1Txt
        {
            get { return load_1Txt; }
            set
            {
                if (load_1Txt != value)
                {
                    load_1Txt = value;

                    OpPropertyChanged("Load_1Txt");
                }
            }
        }
        public string ThruTxt
        {
            get { return thruTxt; }
            set
            {
                if (thruTxt != value)
                {
                    thruTxt = value;

                    OpPropertyChanged("ThruTxt");
                }
            }
        }
        public string LoadBoth
        {
            get { return loadBoth; }
            set
            {
                if (loadBoth != value)
                {
                    loadBoth = value;

                    OpPropertyChanged("LoadBoth");
                }
            }
        }

    }
}
