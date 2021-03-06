﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp.ViewModels
{
    public class MainWindowModel : ViewModelBase
	{
		public SignInViewModel SignInViewModel { get; }
		public RegisterViewModel RegisterViewModel { get; }

		public WelcomeViewModel WelcomeViewModel { get; }
		public HotelViewModel HotelViewModel { get; }

		public ApplicationViewModel ApplicationViewModel { get; set; }
		public HotelGoodJob HotelGoodJob { get; set; }
		public ConcertViewModel ConcertViewModel { get; }
		public PlanViewModel PlanViewModel { get; }
		public FlightViewModel FlightViewModel { get; }
		public FindDealsViewModel FindDealsViewModel { get; }
		public SlideViewModel SlideViewModel { get; }
		public GoodJobViewModel goodJobViewModel { get; }
		public FindDeals2ViewModel FindDeals2ViewModel { get; }
		public FindHotelsViewModel FindHotelViewModel { get; }
		//public PlanViewModel PlanViewModel { get; }

		public IPageViewModel currentView;

		public IPageViewModel CurrentView
		{
			get { return currentView; }
			set
			{
				currentView = value;
				OnPropertyChanged();
			}
		}
        public int zindex=0;

		public int Zindex
		{
			get { return zindex; }
			set
			{
                zindex = value;
				OnPropertyChanged();
			}
		}
	
		public MainWindowModel(SlideViewModel slideViewModel,
            RegisterViewModel registerViewModel, 
            FlightViewModel flightViewModel,
            WelcomeViewModel welcomeViewModel,
            SignInViewModel signInViewModel,
            HotelViewModel hotelViewModel,
            ApplicationViewModel applicationViewModel ,
            FindDealsViewModel findDealsViewModel,
            GoodJobViewModel goodjobViewModel,
            PlanViewModel planViewModel,
            FindHotelsViewModel findHotelsViewModel,
            HotelGoodJob hotelGoodJob,
            FindDeals2ViewModel findDeals2ViewModel)
		{
            FindHotelViewModel = findHotelsViewModel;
            goodJobViewModel = goodjobViewModel;
            FindDeals2ViewModel = findDeals2ViewModel;
            FindDealsViewModel = findDealsViewModel;
            SlideViewModel = slideViewModel;
			SignInViewModel = signInViewModel;
            RegisterViewModel = registerViewModel;
			WelcomeViewModel = welcomeViewModel;
			ApplicationViewModel = applicationViewModel;
			FlightViewModel = flightViewModel ;
			HotelViewModel = hotelViewModel;
            PlanViewModel = planViewModel;
           // HotelGoodJob.EEESuccessfullyEvent+=new HotelGoodJob.EEESuccessfullyHandler(ent);
            FindHotelViewModel.ChoSuccessfullyEvent += new FindHotelsViewModel.ChoSuccessfullyHandler(myChoSuccessfullyHandler);
            goodJobViewModel.ConSuccessfullyEvent += new GoodJobViewModel.ConSuccessfullyHandler(myConSuccesfullyHandler);
            FindDeals2ViewModel.GoodJobSuccessfullyEvent += new FindDeals2ViewModel.GoodJobSuccessfullyHandler(mygooddoneSuccesfullyHandler);
            FindDealsViewModel.GoSuccessfullyEvent += new FindDealsViewModel.GoSuccessfullyHandler(mygosuccesfullyHandler);
            RegisterViewModel.RegisterSuccessfullyEvent += new RegisterViewModel.RegisterSuccessfullyHandler(mydonesuccesfullyHandler);
            SlideViewModel.EntSuccessfullyEvent += new SlideViewModel.EntSuccessfullyHandler(myEntsuccesfullyHandler);
            SlideViewModel.PlanSuccessfullyEvent += new SlideViewModel.PlanSuccessfullyHandler(myPlansuccesfullyHandler);
            SlideViewModel.StSuccessfullyEvent += new SlideViewModel.StSuccessfullyHandler(myStsuccesfullyHandler);
            SlideViewModel.FlSuccessfullyEvent += new SlideViewModel.FlSuccessfullyHandler(myFlsuccesfullyHandler);
            SlideViewModel.LogSuccessfullyEvent += new SlideViewModel.LogSuccessfullyHandler(myLogsuccesfullyHandler);
            SlideViewModel.HotelSuccessfullyEvent += new SlideViewModel.HotelSuccessfullyHandler(myHotelsuccesfullyHandler);
			SignInViewModel.SignSuccessfullyEvent += new SignInViewModel.SignSuccessfullyHandler(mySignSuccessfullyHandler);
			SignInViewModel.RegisterSuccessfullyEvent += new SignInViewModel.RegisterSuccessfullyHandler(myRegisterSuccessfullyHandler);
			WelcomeViewModel.StartSuccessfullyEvent += new WelcomeViewModel.StartSuccessfullyHandler(myStartHandler);
			FlightViewModel.FindSuccessfullyEvent += new FlightViewModel.FindSuccessfullyHandler(myFindSuccessfullyHandler);
			HotelViewModel.SearchSuccessfullyEvent += new HotelViewModel.SearchSuccessfullyHandler(mySearchHandler);
			ApplicationViewModel.bestevent += new ApplicationViewModel.BestyHandler(BestHandler);
			ApplicationViewModel.bestConcertevent += new ApplicationViewModel.BestyConcertHandler(BestConcertHandler);
			ApplicationViewModel.bestResevent += new ApplicationViewModel.BestyResHandler(BestResHandler);
			ApplicationViewModel.bestMuseumevent += new ApplicationViewModel.BestyMuseumHandler(BestMuseumHandler);
			CurrentView = signInViewModel ;

		//450 800
		}

        private void ent()
        {
            CurrentView = ApplicationViewModel;
        }

        private void myLogsuccesfullyHandler()
        {
            CurrentView = SignInViewModel;
            Zindex = 0;
        }

        private void myHotelsuccesfullyHandler()
        {
            CurrentView = HotelViewModel;
        }

        private void myChoSuccessfullyHandler()
        {
            //dfvd
            CurrentView = ApplicationViewModel;
        }

        private void myFlsuccesfullyHandler()
        {
            CurrentView = FlightViewModel;
        }

        private void myStsuccesfullyHandler()
        {
            CurrentView = WelcomeViewModel;
        }

        private void myPlansuccesfullyHandler()
        {
            CurrentView = PlanViewModel;
        }

        private void myConSuccesfullyHandler()
        {
            CurrentView = HotelViewModel;
           // CurrentView = PlanViewModel;
        }

        private void mygooddoneSuccesfullyHandler()
        {
            CurrentView = goodJobViewModel;
        }

        private void mygosuccesfullyHandler()
        {
            CurrentView = FindDeals2ViewModel;
        }

        private void myEntsuccesfullyHandler()
        {
            CurrentView = ApplicationViewModel;
        }

        private void mydonesuccesfullyHandler()
        {
            CurrentView = SignInViewModel;
        }

        private void myRegisterSuccessfullyHandler()
        {
            CurrentView = RegisterViewModel;
        }
        
        private void mySearchHandler()
		{
			CurrentView = FindHotelViewModel;
            FindHotelViewModel.ho();
		}

		private void myStartHandler()
		{
			CurrentView = FlightViewModel;
		}

		private void mySignSuccessfullyHandler()
		{

			CurrentView = WelcomeViewModel;
            Zindex = 38;
		}

		private void myFindSuccessfullyHandler()
		{
			CurrentView = FindDealsViewModel;
		}

		public void Load()
        {
            //PlanViewModel.Load();
        }
		private void BestHandler()
		{
			CurrentView = new ParkViewModel();
		}



		private void BestConcertHandler()
		{
			CurrentView = new ConcertViewModel();
		}

		private void BestResHandler()
		{
			CurrentView = new RestaurantViewModel();
		}

		private void BestMuseumHandler()
		{
			CurrentView = new MuseumViewModel();
		}

	}
}
