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
    public class SlideViewModel : IPageViewModel
    {
        public ICommand EntCommand { get; set; }
        public ICommand PlanCommand { get; set; }
        public ICommand StCommand { get; set; }
        public ICommand FlCommand { get; set; }
        public ICommand HotelCommand { get; set; }
        public ICommand logoutCommand { get; set; }
        public SlideViewModel()
        {
            EntCommand = new DelegateCommand(OnEntExecute, OnEntCanExecute);
            PlanCommand = new DelegateCommand(OnPlanExecute, OnEntCanExecute);
            FlCommand = new DelegateCommand(OnFlExecute, OnEntCanExecute);
            StCommand = new DelegateCommand(OnStExecute, OnEntCanExecute);
            HotelCommand = new DelegateCommand(OnHotelExecute, OnEntCanExecute);
            logoutCommand = new DelegateCommand(OnlogExecute, OnEntCanExecute);
        }

        private void OnlogExecute()
        {
            LogSuccessfullyEvent();
        }

        private void OnHotelExecute()
        {
            HotelSuccessfullyEvent();
        }

        private void OnFlExecute()
        {
            FlSuccessfullyEvent();
        }

        private void OnStExecute()
        {
            StSuccessfullyEvent();
        }

        private void OnPlanExecute()
        {
            PlanSuccessfullyEvent();
        }

        private bool OnEntCanExecute()
        {
            return true;
        }
        public delegate void EntSuccessfullyHandler();
        public event EntSuccessfullyHandler EntSuccessfullyEvent;
        public delegate void LogSuccessfullyHandler();
        public event LogSuccessfullyHandler LogSuccessfullyEvent;
        public delegate void HotelSuccessfullyHandler();
        public event HotelSuccessfullyHandler HotelSuccessfullyEvent;
        public delegate void FlSuccessfullyHandler();
        public event FlSuccessfullyHandler FlSuccessfullyEvent;
        public delegate void StSuccessfullyHandler();
        public event StSuccessfullyHandler StSuccessfullyEvent;
        public delegate void PlanSuccessfullyHandler();
        public event PlanSuccessfullyHandler PlanSuccessfullyEvent;
        private void OnEntExecute()
        {
          //  MessageBox.Show("sfdav");
            EntSuccessfullyEvent();
        }
    }
}
