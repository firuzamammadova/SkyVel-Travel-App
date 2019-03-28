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
    public class GoodJobViewModel : IPageViewModel
    {
        private IEventAggregator _eventAggregator;
        public ICommand ConCommand { get; set; }
        public GoodJobViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            ConCommand = new DelegateCommand(OnConExecute, OnConCanExecute);
        }

        private void OnConExecute()
        {
            _eventAggregator.GetEvent<LoadEvent>().Publish(1);
            ConSuccessfullyEvent();
        }

        private bool OnConCanExecute()
        {
            return true;
        }

        public delegate void ConSuccessfullyHandler();
        public event ConSuccessfullyHandler ConSuccessfullyEvent;
    }
}
