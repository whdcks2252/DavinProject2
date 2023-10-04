using CalibrationChecker.Commands;
using CalibrationChecker.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CalibrationChecker.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly S_ParameterRepository s_ParameterRepository;
        private string _fileNameTxt;
        

        public MainViewModel(S_ParameterRepository s_ParameterRepository) {
            this.s_ParameterRepository= s_ParameterRepository;
            FindCalName =new FindCalNameCommand(this);
            LoadFile=new LoadFileCommand(this, s_ParameterRepository);
        }


        public ICommand FindCalName { get; set; }
        public ICommand LoadFile { get; set; }

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
