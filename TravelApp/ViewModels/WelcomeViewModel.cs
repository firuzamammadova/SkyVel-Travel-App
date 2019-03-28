using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TravelApp.ViewModels
{
  public  class WelcomeViewModel:IPageViewModel
    {
		public WelcomeViewModel()
		{
			StartCommand = new DelegateCommand(OnStartExecute, OnStartCanExecute);
		}
		public delegate void StartSuccessfullyHandler();
		public event StartSuccessfullyHandler StartSuccessfullyEvent;
		private void OnStartExecute()
		{
			StartSuccessfullyEvent();
		}

		private bool OnStartCanExecute()
		{
			return true;		}

		public ICommand StartCommand { get; set; }


	}
}
