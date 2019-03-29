using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TravelApp.Model;

namespace TravelApp.ViewModels
{
    public class ParkViewModel : IPageViewModel
    {
        public ObservableCollection<parkstuff> stuff { get; set; }
        public ICommand SelectCommand { get; set; }
        public ParkViewModel()
        {

            stuff = new ObservableCollection<parkstuff>();

            bool g = false;
            string files = @"C:\Users\Aydan\Downloads\SkyVel-master\SkyVel-master\TravelApp\txtp.txt";
            string[] li = new string[4];
            int i = 0;
            string line;
            SelectCommand = new DelegateCommand(OnSelectExecute, OnSelectCanExecute);
            var file = new System.IO.StreamReader(files);

            var lineCount = (File.ReadLines(files).Count()) / 4;
            while (lineCount != 0)
            {
                g = true;

                while (i != 4 && (line = file.ReadLine()) != null)
                {

                    li[i] = "    " + line;

                    i++;

                }
                stuff.Add(new parkstuff { photo = li[0], time = li[1], adress = li[2], name = li[3] });
                i = 0; g = false;
                lineCount--;
            }
        }

        private bool OnSelectCanExecute()
        {
            return true;
        }

        private void OnSelectExecute()
        {
          //  throw new NotImplementedException();
        }
    }
}
