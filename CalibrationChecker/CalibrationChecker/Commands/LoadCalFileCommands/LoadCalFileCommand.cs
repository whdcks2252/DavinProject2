using CalibrationChecker.Enum;
using CalibrationChecker.Models;
using CalibrationChecker.Repository;
using CalibrationChecker.Store;
using CalibrationChecker.Util;
using CalibrationChecker.ViewModel;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace CalibrationChecker.Commands.LoadCalFileCommands
{
    public class LoadCalFileCommand : CommandBase
    {
        private readonly LoadCalFileViewModel loadCalFileViewModel;
        private readonly CalFileRepository calFileRepository;
        public LoadCalFileCommand(LoadCalFileViewModel loadCalFileViewModel, CalFileRepository calFileRepository)
        {
            this.loadCalFileViewModel = loadCalFileViewModel;
            this.calFileRepository = calFileRepository;
        }

        private void LoadFile(string parameter)
        {
            CalFileVaild result = (CalFileVaild)CalFileVaild.Parse(typeof(CalFileVaild), parameter);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TEXT(*.txt)|*.txt;*";
            try
            {
                if (openFileDialog.ShowDialog() == true)
                {

                    FileRoot.FileRootVale = openFileDialog.FileName;
                    string path= Path.GetFileName(FileRoot.FileRootVale);
                    
                    //파일 검증
                    FileNameVaild(parameter, path, result);

                    //반복문이 많을시 StreamReader로 파일 입출력을 하는게 File 클래스 보다 좋음 
                    using (StreamReader rd = new StreamReader(openFileDialog.FileName))
                    {
                        List<string> textVale = new List<string>();
                        string[] splitData = new string[3];

                        while (!rd.EndOfStream)
                        {
                            textVale.Add(rd.ReadLine());
                        }

                        if (textVale.Count > 0)
                        {
                            //데이터파일생성
                            for (int i = 0; i < textVale.Count; i++)
                            {
                                splitData=textVale[i].Split(' ');
                                CalData data = new CalData()
                                {   Category = result,
                                    Fre = (Double.Parse(splitData[0])),
                                    Real = (Double.Parse(splitData[1])),
                                    Imag = (Double.Parse(splitData[2]))

                                };
                                calFileRepository.save(ref data);
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("파일을 읽는 중 오류 발생");
                Console.WriteLine("파일 로딩중 오류발생 :", ex.Message);
            }

        }

        private void FileNameVaild(string parameter, string fileName, CalFileVaild calFileVaild)
        {

            if (parameter== CalFileVaild.Open_0.ToString())
            {
                if (!fileName.Contains(parameter))
                {
                    throw new Exception();
                }
                if (CalFileStatic.Open_0File == 1) 
                {
                    List<CalData>data= calFileRepository.get();
                    data.RemoveAll(item => item.Category == calFileVaild);
                }
                else
                {
                    CalFileStatic.Open_0File = 1;
                }

                loadCalFileViewModel.Open_0Txt=fileName;
                return;
            }

            if (parameter == CalFileVaild.Open_1.ToString())
            {
                if (!fileName.Contains(parameter))
                {
                    throw new Exception();
                }
                if (CalFileStatic.Open_1File == 1)
                {
                    List<CalData> data = calFileRepository.get();
                    data.RemoveAll(item => item.Category == calFileVaild);
                }
                else
                {
                    CalFileStatic.Open_1File = 1;
                }

                loadCalFileViewModel.Open_1Txt = fileName;
                return;
            }

            if (parameter == CalFileVaild.Short_0.ToString())
            {
                if (!fileName.Contains(parameter))
                {
                    throw new Exception();
                }
                if (CalFileStatic.Short_0File == 1)
                {
                    List<CalData> data = calFileRepository.get();
                    data.RemoveAll(item => item.Category == calFileVaild);
                }
                else
                {
                    CalFileStatic.Short_0File = 1;
                }

                loadCalFileViewModel.Short_0Txt = fileName;
                return;
            }

            if (parameter == CalFileVaild.Short_1.ToString())
            {
                if (!fileName.Contains(parameter))
                {
                    throw new Exception();
                }
                if (CalFileStatic.Short_1File == 1)
                {
                    List<CalData> data = calFileRepository.get();
                    data.RemoveAll(item => item.Category == calFileVaild);
                }
                else
                {
                    CalFileStatic.Short_1File = 1;
                }

                loadCalFileViewModel.Short_1Txt = fileName;
                return;
            }

            if (parameter == CalFileVaild.Load_0.ToString())
            {
                if (!fileName.Contains(parameter))
                {
                    throw new Exception();
                }
                if (CalFileStatic.Open_0File == 1)
                {
                    List<CalData> data = calFileRepository.get();
                    data.RemoveAll(item => item.Category == calFileVaild);
                }
                else
                {
                    CalFileStatic.Open_0File = 1;
                }

                loadCalFileViewModel.Load_0Txt = fileName;
                return;
            }

            if (parameter == CalFileVaild.Load_1.ToString())
            {
                if (!fileName.Contains(parameter))
                {
                    throw new Exception();
                }
                if (CalFileStatic.Load_1File == 1)
                {
                    List<CalData> data = calFileRepository.get();
                    data.RemoveAll(item => item.Category == calFileVaild);
                }
                else
                {
                    CalFileStatic.Load_1File = 1;
                }

                loadCalFileViewModel.Load_1Txt = fileName;
                return;
            }

            if (parameter == CalFileVaild.Thru.ToString())
            {
                if (!fileName.Contains(parameter))
                {
                    throw new Exception();
                }
                if (CalFileStatic.ThruFile == 1)
                {
                    List<CalData> data = calFileRepository.get();
                    data.RemoveAll(item => item.Category == calFileVaild);
                }
                else
                {
                    CalFileStatic.ThruFile = 1;
                }

                loadCalFileViewModel.ThruTxt = fileName;
                return;
            }

            if (parameter == CalFileVaild.LoadBoth.ToString())
            {
                if (!fileName.Contains(parameter))
                {
                    throw new Exception();
                }
                if (CalFileStatic.LoadBothFile == 1)
                {
                    List<CalData> data = calFileRepository.get();
                    data.RemoveAll(item => item.Category == calFileVaild);
                }
                else
                {
                    CalFileStatic.LoadBothFile = 1;
                }

                loadCalFileViewModel.LoadBoth = fileName;
                return;
            }

            throw new Exception();

        }


        public override bool CanExecute(object parameter)
        {
              
            return true;
            
        }

        public override void Execute(object parameter)
        {
            string str = (string)parameter;
            LoadFile(str);
        }
    }
}
