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

namespace CalibrationChecker.Commands.LoadCalFileCommands
{
    public class LoadAutoCommand : CommandBase
    {

        private readonly LoadCalFileViewModel loadCalFileViewModel;
        private readonly CalFileRepository calFileRepository;
        public LoadAutoCommand(LoadCalFileViewModel loadCalFileViewModel, CalFileRepository calFileRepository)
        {
            this.loadCalFileViewModel = loadCalFileViewModel;
            this.calFileRepository = calFileRepository;
        }

        private void AutoLoad()
        {
            string binFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "cal");
            try
            {
                // 'bin' 폴더 내의 모든 '.txt' 파일 가져오기
                string[] txtFiles = Directory.GetFiles(binFolderPath, "*.txt", SearchOption.AllDirectories);
                if (txtFiles.Length==0)
                {
                    throw new Exception();
                }

                // 가져온 파일 경로를 애플리케이션에서 사용하거나 필요한 작업 수행
                foreach (string txtFilePath in txtFiles)
                {
                    FileRoot.FileRootVale = txtFilePath;
                    string path = Path.GetFileName(FileRoot.FileRootVale);
                    var fileNameVaild = FileNameVaild(path);
                    if (!fileNameVaild.Item1)
                    {
                        continue;
                    }

                    //반복문이 많을시 StreamReader로 파일 입출력을 하는게 File 클래스 보다 좋음
                    using (StreamReader rd = new StreamReader(txtFilePath))
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
                                splitData = textVale[i].Split(' ');
                                CalData data = new CalData()
                                {
                                    Category = fileNameVaild.Item2,
                                    Fre = (Double.Parse(splitData[0])),
                                    Real = (Double.Parse(splitData[1])),
                                    Imag = (Double.Parse(splitData[2]))

                                };
                                calFileRepository.save(ref data);
                            }

                        }
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show("파일이 없습니다");
            }
        }

        public (bool, CalFileVaild) FileNameVaild(string fileName)
        {
            if (fileName.Contains(CalFileVaild.Open_0.ToString()))
            {
                if (CalFileStatic.Open_0File == 1)
                {
                    List<CalData> data = calFileRepository.get();
                    data.RemoveAll(item => item.Category == CalFileVaild.Open_0);
                }
                else
                {
                    CalFileStatic.Open_0File = 1;
                }

                loadCalFileViewModel.Open_0Txt = fileName;
                return (true, CalFileVaild.Open_0);
            }

            if (fileName.Contains(CalFileVaild.Open_1.ToString()))
            {
                if (CalFileStatic.Open_1File == 1)
                {
                    List<CalData> data = calFileRepository.get();
                    data.RemoveAll(item => item.Category == CalFileVaild.Open_1);
                }
                else
                {
                    CalFileStatic.Open_1File = 1;
                }

                loadCalFileViewModel.Open_1Txt = fileName;
                return (true, CalFileVaild.Open_1);
            }

            if (fileName.Contains(CalFileVaild.Short_0.ToString()))
            {
                if (CalFileStatic.Short_0File == 1)
                {
                    List<CalData> data = calFileRepository.get();
                    data.RemoveAll(item => item.Category == CalFileVaild.Short_0);
                }
                else
                {
                    CalFileStatic.Short_0File = 1;
                }

                loadCalFileViewModel.Short_0Txt = fileName;
                return (true, CalFileVaild.Short_0);
            }

            if (fileName.Contains(CalFileVaild.Short_1.ToString()))
            {
                if (CalFileStatic.Short_1File == 1)
                {
                    List<CalData> data = calFileRepository.get();
                    data.RemoveAll(item => item.Category == CalFileVaild.Short_1);
                }
                else
                {
                    CalFileStatic.Short_1File = 1;
                }

                loadCalFileViewModel.Short_1Txt = fileName;
                return (true, CalFileVaild.Short_1);
            }

            if (fileName.Contains(CalFileVaild.Load_0.ToString()))
            {
                if (CalFileStatic.Load_0File == 1)
                {
                    List<CalData> data = calFileRepository.get();
                    data.RemoveAll(item => item.Category == CalFileVaild.Load_0);
                }
                else
                {
                    CalFileStatic.Load_0File = 1;
                }
                loadCalFileViewModel.Load_0Txt = fileName;
                return (true, CalFileVaild.Load_0);
            }

            if (fileName.Contains(CalFileVaild.Load_1.ToString()))
            {
                if (CalFileStatic.Load_1File == 1)
                {
                    List<CalData> data = calFileRepository.get();
                    data.RemoveAll(item => item.Category == CalFileVaild.Load_1);
                }
                else
                {
                    CalFileStatic.Load_1File = 1;
                }
                loadCalFileViewModel.Load_1Txt = fileName;
                return (true, CalFileVaild.Load_1);
            }

            if (fileName.Contains(CalFileVaild.Thru.ToString()))
            {
                if (CalFileStatic.ThruFile == 1)
                {
                    List<CalData> data = calFileRepository.get();
                    data.RemoveAll(item => item.Category == CalFileVaild.Thru);
                }
                else
                {
                    CalFileStatic.ThruFile = 1;
                }
                loadCalFileViewModel.ThruTxt = fileName;
                return (true, CalFileVaild.Thru);
            }

            if (fileName.Contains(CalFileVaild.LoadBoth.ToString()))
            {
                if (CalFileStatic.LoadBothFile == 1)
                {
                    List<CalData> data = calFileRepository.get();
                    data.RemoveAll(item => item.Category == CalFileVaild.LoadBoth);
                }
                else
                {
                    CalFileStatic.LoadBothFile = 1;
                }
                loadCalFileViewModel.LoadBoth = fileName;
                return (true, CalFileVaild.LoadBoth);
            }

            return (false, CalFileVaild.LoadBoth);
        }

    

    public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            AutoLoad();     
        }
    }
}
