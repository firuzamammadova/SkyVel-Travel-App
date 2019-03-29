using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelApp.Model;

namespace TravelApp.ViewModels
{

    public class MuseumViewModel : IPageViewModel
    {


        public ObservableCollection<musstuff> stuff { get; set; }
        public MuseumViewModel()
        {
            stuff = new ObservableCollection<musstuff>();

            bool g = false;
            string files = @"C:\Users\Aydan\Downloads\SkyVel-master\SkyVel-master\TravelApp\txtm.txt";
            string[] li = new string[5];
            int i = 0;
            string line;

            var file = new System.IO.StreamReader(files);

            var lineCount = (File.ReadLines(files).Count()) / 4;
            while (lineCount != 0)
            {
                g = true;

                while (i != 5 && (line = file.ReadLine()) != null)
                {
                    li[i] = line;
                    i++;

                }
                stuff.Add(new musstuff { photo = li[0], price = li[1], adress = li[2], time = li[3],name=li[4]});
                i = 0;
                lineCount--;
            }

        }

    }
}
