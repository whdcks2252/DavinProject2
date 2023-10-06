using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using OxyPlot.Legends;
using CalibrationChecker.Enum;
using CalibrationChecker.ViewModel;
using CalibrationChecker.Repository;
using System.Data;

namespace CalibrationChecker.Util
{
     public class PlotModelImp : PlotModel
    {
        private static PlotModelImp plotModelImp;

        //객체 인스턴스
        public static PlotModelImp GetPlotModelImp()
        {
            if (plotModelImp == null)
            {
                plotModelImp = new PlotModelImp();
                plotModelImp.SetPlotModel();
            }
            return plotModelImp;

        }

        public void SetPlotModel()
        {
            //PlotModel 생성

            //x축 생성
            plotModelImp.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                IsZoomEnabled = false,
            });
            //y축 생성
            plotModelImp.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                IsZoomEnabled = false,
            });
        }

        public void ChageCharMethod(ref List<S_ParamDTO> datas,ref string fileName)
        {
            if (fileName.Contains(FileEnum.P1.ToString()))
            {
                var lineSeries11 = new LineSeries
                {
                    Color = OxyColors.Red,

                };

                foreach (var data in datas)
                {
                    lineSeries11.Points.Add(new DataPoint(data.freq, Math.Sqrt(data.S11Real * data.S11Real + data.S11Imag * data.S11Imag)));
                }

                var lineSeries21 = new LineSeries
                {
                    Color = OxyColors.Green,

                };
                foreach (var data in datas)
                {
                    lineSeries21.Points.Add(new DataPoint(data.freq, Math.Sqrt(data.S21Real * data.S21Real + data.S21Imag * data.S21Imag)));
                }

                plotModelImp.Series.Add(lineSeries11);
                plotModelImp.Series.Add(lineSeries21);


            }
            else if (fileName.Contains(FileEnum.P2.ToString()))
                {
                var lineSeries12 = new LineSeries
                {
                    Color = OxyColors.Blue,

                };
                foreach (var data in datas)
                {
                    lineSeries12.Points.Add(new DataPoint(data.freq, Math.Sqrt(data.S12Real * data.S12Real + data.S12Imag * data.S12Imag)));
                }

                var lineSeries22 = new LineSeries
                {
                    Color = OxyColors.Violet,

                };
                foreach (var data in datas)
                {
                    lineSeries22.Points.Add(new DataPoint(data.freq, Math.Sqrt(data.S22Real * data.S22Real + data.S22Imag * data.S22Imag)));
                }

                plotModelImp.Series.Add(lineSeries12);
                plotModelImp.Series.Add(lineSeries22);


            }
                plotModelImp.InvalidatePlot(true);// 바인딩 즉시업데이트 트리거

        }


        public void  CheckChartMethod(ref bool s11,ref bool s12, ref bool s21, ref bool s22, ref List<S_ParamDTO> s_ParamDTOP1 , ref List<S_ParamDTO> s_ParamDTOP2)
        {
            plotModelImp.Series.Clear();
            var groupedDataP1 = s_ParamDTOP1.GroupBy(data => data.timestamp);
            var groupedDataP2 = s_ParamDTOP2.GroupBy(data => data.timestamp);
         
            if (s11 == true)
            {
                foreach (var group in groupedDataP1)
                {
                    List<S_ParamDTO> datas = group.ToList();
                    var lineSeries11 = new LineSeries
                    {
                        Color = OxyColors.Red,

                    };

                    foreach (var data in datas)
                    {
                        lineSeries11.Points.Add(new DataPoint(data.freq, Math.Sqrt(data.S11Real * data.S11Real + data.S11Imag * data.S11Imag)));
                    }

                    plotModelImp.Series.Add(lineSeries11);
                  
                }
            }

            if(s12 == true)
            {
                foreach (var group in groupedDataP2)
                {
                    List<S_ParamDTO> datas = group.ToList();

                    var lineSeries12 = new LineSeries
                    {
                        Color = OxyColors.Blue,

                    };
                    foreach (var data in datas)
                    {
                        lineSeries12.Points.Add(new DataPoint(data.freq, Math.Sqrt(data.S12Real * data.S12Real + data.S12Imag * data.S12Imag)));
                    }
                    plotModelImp.Series.Add(lineSeries12);

                }
            }

            if (s21 == true) 
            {
                foreach (var group in groupedDataP1)
                {
                    List<S_ParamDTO> datas = group.ToList();

                    var lineSeries21 = new LineSeries
                    {
                        Color = OxyColors.Green,

                    };
                    foreach (var data in datas)
                    {
                        lineSeries21.Points.Add(new DataPoint(data.freq, Math.Sqrt(data.S21Real * data.S21Real + data.S21Imag * data.S21Imag)));
                    }
                    plotModelImp.Series.Add(lineSeries21);

                }
            }

            if (s22 == true) 
            {
                foreach (var group in groupedDataP2)
                {
                    List<S_ParamDTO> datas = group.ToList();

                    var lineSeries22 = new LineSeries
                    {
                        Color = OxyColors.Violet,

                    };
                    foreach (var data in datas)
                    {
                        lineSeries22.Points.Add(new DataPoint(data.freq, Math.Sqrt(data.S22Real * data.S22Real + data.S22Imag * data.S22Imag)));
                    }
                    plotModelImp.Series.Add(lineSeries22);

                }
            }

                plotModelImp.InvalidatePlot(true);// 바인딩 즉시업데이트 트리거

        }


    }
}
