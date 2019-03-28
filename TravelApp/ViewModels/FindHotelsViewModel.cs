using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TravelApp.ViewModels
{
    public class FindHotelsViewModel : ViewModelBase, IPageViewModel
    {
        public ICommand ChoCommand { get; set; }
        public FindHotelsViewModel()
        {
            ChoCommand = new DelegateCommand(OnChoExecute, OnChoCanExecute);
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
