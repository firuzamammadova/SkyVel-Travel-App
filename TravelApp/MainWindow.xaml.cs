using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TravelApp.ViewModels;

namespace TravelApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowModel _viewmodel;
        public MainWindow(MainWindowModel mainWindowModel)
        {
            InitializeComponent();
            _viewmodel = mainWindowModel;
            DataContext = mainWindowModel;
            Loaded += MainWindow_Loaded;
            //Enable-Migrations -ProjectName Toombu.DataAccess -StartUpProjectName Toombu.Web -Verbose
            //add-migration initial -ProjectName MyStat.DataAccess -StartUpProjectName MyStat.UI 

        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _viewmodel.Load();
        }
    }
}
