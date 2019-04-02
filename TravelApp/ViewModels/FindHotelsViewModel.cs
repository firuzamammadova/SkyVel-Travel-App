using Prism.Commands;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TravelApp.Event;
using TravelApp.Model;

namespace TravelApp.ViewModels
{
    //Hotel : Pensione Guerrato
    //Address : San Polo 240/A, San Polo, 30125 Venice, Italy
    //Price : 190 $
    public class FindHotelsViewModel : ViewModelBase, IPageViewModel
    {
        public ObservableCollection<HotelInfo> Hotels { get; set; }
        private IEventAggregator _eventAggregator;

        public ICommand ChoCommand { get; set; }
        public FindHotelsViewModel(IEventAggregator eventAggregator)
        {

            _eventAggregator = eventAggregator;
            //  _eventAggregator.GetEvent<SendHotelToPlan>().Subscribe(OnHotelSelectedEvent);

            Hotels = new ObservableCollection<HotelInfo>();
            ChoCommand = new DelegateCommand(OnChoExecute, OnChoCanExecute);
            hei = 40;
            //  ho();

        }
        private HotelInfo _selectedHot;
        public HotelInfo SelectedHot
        {
            get { return _selectedHot; }
            set
            {
                _selectedHot = value;

                OnPropertyChanged();
                if (_selectedHot != null)
                {
                    _eventAggregator.GetEvent<SendHotelToPlan>().Publish(new HotelInfo
                    {
                        Name = _selectedHot.Name,
                        Address = _selectedHot.Address,
                        photo = _selectedHot.photo,
                        Price = _selectedHot.Price
                    });

                    ChoSuccessfullyEvent();
                }
            }
        }
      

        public int Hei = 0;

        public int hei
        {
            get { return Hei; }
            set
            {
                Hei = value;
                OnPropertyChanged();
            }
        }
        public void load()
        {

            Thread.Sleep(3000);
          
            Application.Current.Dispatcher.Invoke(new Action(() =>
            {
                Hotels.Add(new HotelInfo
                {
                    photo = @"Images\170575461.jpg",
                    Name = "Hotel : Pensione Guerrato",
                    Address = "Address : San Polo 240/A, San Polo, 30125 Venice, Italy",
                    Price = "190 $"
                });

               
 Hotels.Add(new HotelInfo
 {
     photo = @"Images\170575461.jpg",
     Name = "Hotel : Pensione Guerrato",
     Address = "Address : San Polo 240/A, San Polo, 30125 Venice, Italy",
     Price = "190 $"
 });

                Hotels.Add(new HotelInfo
                {
                    photo = @"Images\11129086.jpg",
                    Name = "Hotel : Tivoli",
                    Address = "Address : Crosera San Pantalon-Dorsoduro, 30123 Venice, Italy",
                    Price = "202 $"
                });

                Hotels.Add(new HotelInfo
                {
                    photo = @"Images\115470246.jpg",
                    Name = "Hotel : Locanda Silva",
                    Address = "Address : Castello 4423, Castello, 30122 Venice, Italy",
                    Price = "250 $"
                });


                Hotels.Add(new HotelInfo
                {
                    photo = @"Images\81893385.jpg",
                    Name = "Hotel : Antico Mercato",
                    Address = "Address : Calle prima de la donzella 290, San Polo",
                    Price = "290 $"
                });

                Hotels.Add(new HotelInfo
                {
                    photo = @"Images\139875486.jpg",
                    Name = "Hotel :  Il Moro di Venezia",
                    Address = "Address : Lista di Spagna 152, Cannaregio",
                    Price = "132 $"
                });

                Hotels.Add(new HotelInfo
                {
                    photo = @"Images\97919768.jpg",
                    Name = "Hotel : Preference Hualing Tbilisi",
                    Address = "Address : Jozef Pilsudski Avenue, Tbilisi Sea New City, 0152",
                    Price = "246 $"
                });

                Hotels.Add(new HotelInfo
                {
                    photo = @"Images\11278896.jpg",
                    Name = "Hotel : Anantara Riverside Bangkok",
                    Address = "Address : 257 Charoennakorn Road, Samrae, Thonburi",
                    Price = "332 $"
                });

                Hotels.Add(new HotelInfo
                {
                    photo = @"Images\116338281.jpg",
                    Name = "Hotel : Riad El Walida",
                    Address = "Address : 12 Touareg Berrima, 40040 Marrakech, Morocco",
                    Price = "198 $"
                });
            }));

        }
        public void ho()
        {
            Task.Factory.StartNew(load).ContinueWith(task =>
            {
                hei=0;
            });
       
            //Thread t = new Thread(new ThreadStart(load));
            //t.Start();


        }
        public string ms { get; set; }
        public delegate void ChoSuccessfullyHandler();
        public event ChoSuccessfullyHandler ChoSuccessfullyEvent;
        private bool OnChoCanExecute()
        {
            return true;
        }

        private void OnChoExecute()
        {

            ChoSuccessfullyEvent();
        }
    }
}
