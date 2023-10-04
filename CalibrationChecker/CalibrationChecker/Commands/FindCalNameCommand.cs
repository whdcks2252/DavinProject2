using CalibrationChecker.Store;
using CalibrationChecker.ViewModel;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CalibrationChecker.Commands
{
    public class FindCalNameCommand : CommandBase
    {
        private readonly MainViewModel mainViewModel;

        public FindCalNameCommand(MainViewModel mainViewModel) {
            this.mainViewModel = mainViewModel;
        }

        private void FindFileName()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TEXT,CSV(*.txt,*.csv)|*.txt;*.csv";
            try
            {
                if (openFileDialog.ShowDialog() == true)
                {

                    FileRoot.FileRootVale= openFileDialog.FileName;
                    mainViewModel.FileNameTxt= Path.GetFileName(FileRoot.FileRootVale);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("파일을 읽는 중 오류 발생");
                Console.WriteLine("파일 로딩중 오류발생 :", ex.Message);
            }


        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            FindFileName();
        }
    }
}
