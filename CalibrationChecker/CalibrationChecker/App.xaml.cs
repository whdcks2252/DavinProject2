using CalibrationChecker.Navigation;
using CalibrationChecker.Repository;
using CalibrationChecker.Store;
using CalibrationChecker.View;
using CalibrationChecker.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

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
            services.AddSingleton<CalFileRepository>();
            //Store
            services.AddSingleton<MainNavigationStore>();
            //Nevigation
            services.AddSingleton<NavigationService>();

            //ViewModels
            services.AddSingleton<MainWindowViewModel>();
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<LoadCalFileViewModel>();

            //Views
            services.AddSingleton(s => new Main()
            {
                DataContext = s.GetRequiredService<MainWindowViewModel>()
            });
           
            return services.BuildServiceProvider();
            
        }
    }
}
