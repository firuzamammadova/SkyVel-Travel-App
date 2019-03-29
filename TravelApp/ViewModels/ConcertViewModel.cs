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
using TravelApp.Views;

namespace TravelApp.ViewModels
{
    public class ConcertViewModel : IPageViewModel
    {
        public ObservableCollection<Concertstuff> stuff { get; set; }
        public ConcertViewModel()
        {
            stuff = new ObservableCollection<Concertstuff>();

            bool g = false;
            string files = @"C:\Users\Aydan\Downloads\SkyVel-master\SkyVel-master\TravelApp\txt.txt";
            string[] li = new string[4];
            int i = 0;
            string line;

            var file = new System.IO.StreamReader(files);

            var lineCount = (File.ReadLines(files).Count()) / 4;
            while (lineCount != 0)
            {
                g = true;

                while (i != 4 && (line = file.ReadLine()) != null)
                {

                    if (i == 2)
                        li[i] = "    " + line;
                    else
                    {
                        li[i] = "                                                                                                 " + line;
                    }
                    i++;

                }
                stuff.Add(new Concertstuff { photo = li[0], name = li[1], time = li[2], place = li[3] });
                i = 0;
                lineCount--;
            }

        }
        

    }
}
