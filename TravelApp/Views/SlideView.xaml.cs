using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace TravelApp.Views
{
	/// <summary>
	/// Interaction logic for SlideView.xaml
	/// </summary>
	public partial class SlideView : UserControl
	{
		public SlideView()
		{
			InitializeComponent();
			
		}
        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
       
            // button start
            ButtonStart.Visibility = Visibility.Collapsed;
            ButtonStart.Visibility = Visibility.Visible;
            // button flight
            Buttonflight.Visibility = Visibility.Collapsed;
            Buttonflight.Visibility = Visibility.Visible;
            // button entetin
            buttonentetein.Visibility = Visibility.Collapsed;
            buttonentetein.Visibility = Visibility.Visible;
            // button hotel
            buttonhotel.Visibility = Visibility.Collapsed;
            buttonhotel.Visibility = Visibility.Visible;
            // button planing
            buttonplan.Visibility = Visibility.Collapsed;
            buttonplan.Visibility = Visibility.Visible;
            // button setting
            buttonsetting.Visibility = Visibility.Collapsed;
            buttonsetting.Visibility = Visibility.Visible;
       
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
            // button start
            ButtonStart.Visibility = Visibility.Visible;
            ButtonStart.Visibility = Visibility.Collapsed;
            // button flight
            Buttonflight.Visibility = Visibility.Visible;
            Buttonflight.Visibility = Visibility.Collapsed;
            // button entetin
            buttonentetein.Visibility = Visibility.Visible;
            buttonentetein.Visibility = Visibility.Collapsed;
            // button hotel
            buttonhotel.Visibility = Visibility.Visible;
            buttonhotel.Visibility = Visibility.Collapsed;
            // button planing
            buttonplan.Visibility = Visibility.Visible;
            buttonplan.Visibility = Visibility.Collapsed;
            // button setting
            buttonsetting.Visibility = Visibility.Visible;
            buttonsetting.Visibility = Visibility.Collapsed;
            
        }

    }
}
