using CalibrationChecker.Commands;
using CalibrationChecker.Navigation;
using CalibrationChecker.Repository;
using CalibrationChecker.Util;
using CalibrationChecker.View;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CalibrationChecker.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly NavigationService _navigationService;
        private readonly S_ParameterRepository s_ParameterRepository;

        private string _fileNameTxt;
        private bool isCheckedS11;
        private bool isCheckedS12;
        private bool isCheckedS21;
        private bool isCheckedS22;
        private string pageSearchTxt;
        private string currentPage;
        private string pagingTxt;
        private UserControl loadCalFile;

        private void LoadCalFileView(object _)
        {
            _navigationService.Navigate(NaviType.LoadCalFile);
        }

        public MainViewModel(S_ParameterRepository s_ParameterRepository,NavigationService navigationService) {
            this.s_ParameterRepository= s_ParameterRepository;
            this._navigationService= navigationService;
            FindCalName =new FindCalNameCommand(this);
            LoadFile=new LoadFileCommand(this, s_ParameterRepository);
            CheckBoxP1 = new CheckBoxCommandP1(this, s_ParameterRepository);
            CheckBoxP2 = new CheckBoxCommandP2(this, s_ParameterRepository);
            LoadCalFileBt = new RelayCommand<object>(LoadCalFileView);
            PlotModelmp = PlotModelImp.GetPlotModelImp();
            PlotModelmp2 = PlotModelImp2.GetPlotModelImp();
            CalExportBT = new LoadCalExportBtCommand(this);
        }


        public ICommand FindCalName { get; set; }
        public ICommand LoadFile { get; set; }
        public ICommand CheckBoxP1 { get; set; }
        public ICommand CheckBoxP2 { get; set; }
        public ICommand LoadCalFileBt { get; set; }

        public ICommand CalExportBT { get; set; }

        public UserControl LoadCalFile {
            get { return loadCalFile; }
            set
            {
                if (loadCalFile != value)
                {
                    loadCalFile = value;

                    OpPropertyChanged("LoadCalFile");
                }
            }
        }

        ////oxyPlot
        public PlotModelImp PlotModelmp { get; set; }
        public PlotModelImp2 PlotModelmp2 { get; set; }

        //CheckBox
        public bool IsCheckedS11 {
            get { return isCheckedS11; }
            set
            {
                if (isCheckedS11 != value)
                {
                    isCheckedS11 = value;

                    OpPropertyChanged("IsCheckedS11");
                }
            }
        }
        public bool IsCheckedS12 {
            get { return isCheckedS12; }
            set
            {
                if (isCheckedS12 != value)
                {
                    isCheckedS12 = value;

                    OpPropertyChanged("IsCheckedS12");
                }
            }
        }
        public bool IsCheckedS21 {
            get { return isCheckedS21; }
            set
            {
                if (isCheckedS21 != value)
                {
                    isCheckedS21 = value;

                    OpPropertyChanged("IsCheckedS21");
                }
            }
        }
        public bool IsCheckedS22 {
            get { return isCheckedS22; }
            set
            {
                if (isCheckedS22 != value)
                {
                    isCheckedS22 = value;

                    OpPropertyChanged("IsCheckedS22");
                }
            }
        }

        public string PageSearchTxt {
            get { return pageSearchTxt; }
            set
            {
                if (pageSearchTxt != value)
                {
                    pageSearchTxt = value;

                    OpPropertyChanged("PageSearchTxt");
                }
            }
        }
        public string CurrentPage
        {
            get { return currentPage; }
            set
            {
                if (currentPage != value)
                {
                    currentPage = value;

                    OpPropertyChanged("CurrentPage");
                }
            }
        }
        public string PagingTxt {
            get { return pagingTxt; }
            set
            {
                if (pagingTxt != value)
                {
                    pagingTxt = value;

                    OpPropertyChanged("PagingTxt");
                }
            }
        }

        public string FileNameTxt
        {
            get { return _fileNameTxt; }
            set
            {
                if (_fileNameTxt != value)
                {
                    _fileNameTxt = value;

                    OpPropertyChanged("FileNameTxt");
                }
            }
        }



    }
}
