using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using wpf_demo_commands.Models;
using wpf_demo_commands.ViewModels;

namespace wpf_demo_commands
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow app = new MainWindow();
            PersonViewModel personViewModel = new PersonViewModel();
            app.DataContext = personViewModel;

            app.Show();
        }
    }
}
