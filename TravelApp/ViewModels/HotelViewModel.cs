using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TravelApp.ViewModels
{
	public class HotelViewModel : IPageViewModel
	{
		public ICommand SearchCommand { get; set; }
		public HotelViewModel()
		{
			SearchCommand = new DelegateCommand(OnSearchExecute, OnSearchCanExecute);

		}
		public delegate void SearchSuccessfullyHandler();
		public event SearchSuccessfullyHandler SearchSuccessfullyEvent;

		private void OnSearchExecute()
		{
			SearchSuccessfullyEvent();		}

		private bool OnSearchCanExecute()
		{
			return true;		}
	}
}
