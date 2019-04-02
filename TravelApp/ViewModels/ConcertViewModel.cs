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
            string files = @"C:\Users\Aydan\Downloads\slide menu\Sky-master\Sky-master\TravelApp\txt.txt";
            string[] li = new string[4];
            int i = 0;
            string line;

            var file = new System.IO.StreamReader(files);
            stuff.Add(new Concertstuff { photo = @"C:\Users\Aydan\Downloads\SkyVel-master\SkyVel-master\TravelApp\Images\37 (1).jpg",
                name = "Ligabue",
                time = "14 June 2019 19:00",
                place = "Stadio San Nicola, Bari, İtalya"
            });
            stuff.Add(new Concertstuff { photo = @"C:\Users\Aydan\Downloads\SkyVel-master\SkyVel-master\TravelApp\Images\SkyVel-master.jpg",
                name = "Vasco Rossi",
                time ="27 May 21:00",
                place = "Stadio Comunale G. Teghil, Lignano Sabbiadoro, İtalya" });
            stuff.Add(new Concertstuff { photo = @"C:\Users\Aydan\Downloads\SkyVel-master\SkyVel-master\TravelApp\Images\37.jpg",
                name = "Jovanotti",
                time = "06 July 2019",
                place = "Spiaggia Bell'Italia, Lignano Sabbiadoro, İtalya"
            });

            stuff.Add(new Concertstuff
            {
                photo = @"C:\Users\Aydan\Downloads\SkyVel-master\SkyVel-master\TravelApp\Images\37 (2).jpg",
                name = "Elton John",
                time = "07 July 2019 21:30",
                place = "Mura di Lucca - Viale Carducci, Lucca, İtalya"
            });

            stuff.Add(new Concertstuff
            {
                photo = @"C:\Users\Aydan\Downloads\SkyVel-master\SkyVel-master\TravelApp\Images\37 (3).jpg",
                name = "Sting",
                time = "Salı, 30 July 2019",
                place = "Live Arena - Ex Foro Boario, Padua, İtalya"
            });

            stuff.Add(new Concertstuff
            {
                photo = @"C:\Users\Aydan\Downloads\SkyVel-master\SkyVel-master\TravelApp\Images\37 (4).jpg",
                name = "Alessandra Amoroso",
                time = "30 March 2019 21:00",
                place = "Pala Remo Magetti, Roseto degli Abruzzi,, İtalya"
            });

            stuff.Add(new Concertstuff
            {
                photo = @"C:\Users\Aydan\Downloads\SkyVel-master\SkyVel-master\TravelApp\Images\37 (5).jpg",
                name = "Ultimo",
                time = "30 March 2019 21:00",
                place = "Pala Remo Magetti, Roseto degli Abruzzi,, İtalya"
            });
            i = 0;
             
            }

        }
        

    }

