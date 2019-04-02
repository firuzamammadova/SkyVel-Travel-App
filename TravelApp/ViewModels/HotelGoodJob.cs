using Prism.Commands;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TravelApp.Event;

namespace TravelApp.ViewModels
{
    public class HotelGoodJob : IPageViewModel
    {
        
        public ICommand ConCommand { get; set; }
        public HotelGoodJob()
        {
           
            ConCommand = new DelegateCommand(OnConExecute, OnConCanExecute);
        }

        private void OnConExecute()
        {
           
            EEESuccessfullyEvent();
        }

        private bool OnConCanExecute()
        {
            return true;
        }

        public delegate void EEESuccessfullyHandler();
        public event EEESuccessfullyHandler EEESuccessfullyEvent;
    }
}
