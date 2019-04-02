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
            string files = @"C:\Users\Aydan\Downloads\slide menu\Sky-master\Sky-master\TravelApp\txtm.txt";
            string[] li = new string[5];
            int i = 0;
            string line;

            var file = new System.IO.StreamReader(files);

       
            
                stuff.Add(new musstuff {
                    photo = @"C:\Users\Aydan\Downloads\SkyVel-master\SkyVel-master\TravelApp\Images\image (1).jpg",
                    price = "€28.00",
                    adress = "Piazzale degli Uffizi, 50122, Florence",
                    time = "08:15 - 18:50",
                    name = "Uffizi Gallery"  });
              
            

        stuff.Add(new musstuff {
                    photo = @"C:\Users\Aydan\Downloads\SkyVel-master\SkyVel-master\TravelApp\Images\DSC_0128.JPG",
                    price = "€40",
                    adress = "Via Ricasoli, 58/60, 50122 Firenze FI, Italy",
                    time = "08:15 - 19:50",
                    name = "Galleria dell'Accademia"
        });

            stuff.Add(new musstuff
            {
                photo = @"C:\Users\Aydan\Downloads\SkyVel-master\SkyVel-master\TravelApp\Images\DSC_1742_DxO.jpg",
                price = "€22",
                adress = "Via del Proconsolo, 4, 50122 Firenze FI, Italy",
                time = "08:00 - 16:20",
                name = "Bargello National Museum"
            });

            stuff.Add(new musstuff
            {
                photo = @"C:\Users\Aydan\Downloads\SkyVel-master\SkyVel-master\TravelApp\Images\405px-Palais_des_Doges_2.jpg",
                price = "€25.52",
                adress = "Piazza San Marco, 1, 30124 Venezia VE, Italy",
                time = "08:30 - 17:30",
                name = "Doge's Palace"
            });


            stuff.Add(new musstuff
            {
                photo = @"C:\Users\Aydan\Downloads\SkyVel-master\SkyVel-master\TravelApp\Images\20180903_113955_HDR.jpg",
                price = "€22.85",
                adress = "Piazza San Marco, 52, 30124 Venezia VE, Italy",
                time = "10:00 - 17:00",
                name = "Museo Correr"
            });

            stuff.Add(new musstuff
            {
                photo = @"C:\Users\Aydan\Downloads\SkyVel-master\SkyVel-master\TravelApp\Images\DSC04361.JPG",
                price = "€18",
                adress = "Lungotevere Castello, 50, 00193 Roma RM, Italy",
                time = "09:00 - 17:30",
                name = "Castel Sant'Angelo"
            });

            stuff.Add(new musstuff
            {
                photo = @"C:\Users\Aydan\Downloads\SkyVel-master\SkyVel-master\TravelApp\Images\2019-02-02.jpg",
                price = "€18",
                adress = "Lungotevere Castello, 50, 00193 Roma RM, Italy",
                time = "09:00 - 17:30",
                name = "Ambrosian Library"
            });

            stuff.Add(new musstuff
            {
                photo = @"C:\Users\Aydan\Downloads\SkyVel-master\SkyVel-master\TravelApp\Images\DSC_1648.JPG",
                price = "€15.50",
                adress = "Piazza della Rotonda, 00186 Roma RM, Italy",
                time = "08:30 - 17:50",
                name = "Pantheon"
            });






        }


    }

       
}
