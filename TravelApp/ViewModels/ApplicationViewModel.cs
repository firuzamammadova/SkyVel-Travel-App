using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace TravelApp.ViewModels
{
	public class ApplicationViewModel :  IPageViewModel
	{
		#region Fields

		public ICommand ParkCommand { get; }
		public ICommand ConcertCommand { get; }
		public ICommand ResCommand { get; set; }
		public ICommand MuseumCommand { get; }

		#endregion

		public ApplicationViewModel()
		{
			// Add available pages
			ParkCommand = new DelegateCommand(OnFindExecute, OnFindCanExecute);
			ConcertCommand = new DelegateCommand(OnFindConcertExecute, OnFindCanExecute);
			ResCommand = new DelegateCommand(OnFindResExecute, OnFindCanExecute);
			MuseumCommand = new DelegateCommand(OnFindMuseumExecute, OnFindCanExecute);
			// Set starting page
			//  CurrentPageViewModel = PageViewModels[0];
		}
		public delegate void BestyHandler();
		public event BestyHandler bestevent;

		public delegate void BestyConcertHandler();
		public event BestyConcertHandler bestConcertevent;

		public delegate void BestyResHandler();
		public event BestyResHandler bestResevent;

		public delegate void BestyMuseumHandler();
		public event BestyMuseumHandler bestMuseumevent;
		#region Properties / Commands

		private bool OnFindCanExecute()
		{
			return true;
		}

		private void OnFindExecute()
		{
			bestevent();
		}
		private void OnFindConcertExecute()
		{
			bestConcertevent();
		}

		private void OnFindResExecute()
		{
			bestResevent();
		}

		private void OnFindMuseumExecute()
		{
			bestMuseumevent();
		}

		#endregion


	}
}
