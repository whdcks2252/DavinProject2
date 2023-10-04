using CalibrationChecker.Repository;
using CalibrationChecker.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using VNA_Calibration;

namespace CalibrationChecker
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        public new static App Current => (App)Application.Current;
        public IServiceProvider Services { get; }

        public App()
        {
            Services = ConfigureService();
            var mainView = Services.GetRequiredService<Main>();
            mainView.Show();

        }

        private IServiceProvider ConfigureService()
        {
            var services = new ServiceCollection();
            //Repository
            services.AddSingleton<S_ParameterRepository>();


            //ViewModels
            services.AddSingleton<MainViewModel>();

            //Views
            services.AddSingleton(s => new Main()
            {
                DataContext = s.GetRequiredService<MainViewModel>()
            });

            return services.BuildServiceProvider();
            
        }
    }
}
