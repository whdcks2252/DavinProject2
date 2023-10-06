using OxyPlot.Axes;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationChecker.Util
{
   
        public class PlotModelImp2 : PlotModel
        {
            private static PlotModelImp2 plotModelImp2;

            //객체 인스턴스
            public static PlotModelImp2 GetPlotModelImp()
            {
                if (plotModelImp2 == null)
                {
                    plotModelImp2 = new PlotModelImp2();
                    plotModelImp2.SetPlotModel();
                }
                return plotModelImp2;

            }

            public void SetPlotModel()
            {
                //PlotModel 생성

                //x축 생성
                plotModelImp2.Axes.Add(new LinearAxis
                {
                    Position = AxisPosition.Bottom,
                    IsZoomEnabled = false,
                });
                //y축 생성
                plotModelImp2.Axes.Add(new LinearAxis
                {
                    Position = AxisPosition.Left,
                    IsZoomEnabled = false,
                });
            }

        }
}
