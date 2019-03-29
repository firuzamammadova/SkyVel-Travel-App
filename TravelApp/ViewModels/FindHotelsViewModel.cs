using Prism.Commands;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            load();
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
                         Address= _selectedHot.Address,
                          photo= _selectedHot.photo,
                          Price= _selectedHot.Price
                    });
                 
                 //   GoSuccessfullyEvent();
                }
            }
        }

        private void load()
        {
            Hotels.Add(new HotelInfo
            {
                photo = @"Images\170575461.jpg",
                Name = "Hotel : Pensione Guerrato",
                Address = "Address : San Polo 240/A, San Polo, 30125 Venice, Italy",
                Price = "190 $"
            });
        }
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
