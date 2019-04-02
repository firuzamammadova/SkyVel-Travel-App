using MaterialDesignThemes.Wpf;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TravelApp.DataServices;
using TravelApp.Model;

namespace TravelApp.ViewModels
{
	public class SignInViewModel : ViewModelBase, IPageViewModel
	{
		public ICommand SignInCommand { get; set; }
		public ICommand RegisterCommand { get; set; }
        private IUserDataService _userDataService;

        public SignInViewModel(IUserDataService userDataService)
		{
            _userDataService = userDataService;
            SignInCommand = new DelegateCommand(OnSignInExecute, OnSignInCanExecute);
			RegisterCommand = new DelegateCommand(OnRegisterExecute, OnRegisterCanExecute);
		}

        private bool OnRegisterCanExecute()
        {
            return true;
        }

        private void OnRegisterExecute()
        {
            RegisterSuccessfullyEvent();
        }

        public delegate void SignSuccessfullyHandler();
		public event SignSuccessfullyHandler SignSuccessfullyEvent;

        public delegate void RegisterSuccessfullyHandler();
		public event RegisterSuccessfullyHandler RegisterSuccessfullyEvent;
        public string color = "white";

        public string Color
        {
            get { return color; }
            set
            {
                color = value;
                OnPropertyChanged();
            }
        }

        public string user = "UserName";

        public string User
        {
            get { return user; }
            set
            {
                user = value;
                OnPropertyChanged();
            }
        }
        private void OnSignInExecute()
        {
            // if (_userDataService.CheckSignIn(_user))
            // {

            if (UserName == null)
                Color = "red";
                User = "Please Fill";
                
            if (Password == null)

                Password = "Please Fill";
            if (UserName!=null&&UserName!="Please Fill"&& Password != null)
               
                    SignSuccessfullyEvent();
            //}
            //else
            //{
           //  MessageBox.Show("wrong password");

           // }
		}

		private bool OnSignInCanExecute()
		{
			return true;
		}
        public string UserName
        {
            get { return _user.Username; }
            set
            {
                if (value != _user.Username)
                {
                    Color = "white";
                    _user.Username = value;
                    OnPropertyChanged();
                }
            }
        }
        private User _user = new User();
        public string Password
        {

            get { return _user.Password; }
            set
            {
                if (value != _user.Password)
                {
                    _user.Password = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
