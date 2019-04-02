using Prism.Commands;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using TravelApp.Event;

namespace TravelApp.ViewModels
{
	public class HotelViewModel : IPageViewModel
    {
        private IEventAggregator _eventAggregator;
        public ICommand SearchCommand { get; set; }
		public HotelViewModel()
		{
			SearchCommand = new DelegateCommand(OnSearchExecute, OnSearchCanExecute);

		}
		public delegate void SearchSuccessfullyHandler();
		public event SearchSuccessfullyHandler SearchSuccessfullyEvent;

		private void OnSearchExecute()
        {
           
            SearchSuccessfullyEvent();
           
        }

		private bool OnSearchCanExecute()
		{
			return true;		}
	}
}
