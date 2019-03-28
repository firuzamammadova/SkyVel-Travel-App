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
    public class RegisterViewModel : ViewModelBase, IPageViewModel
    {
        private IUserDataService _userDataService;

        public ICommand DoneCommand { get; set; }
        public RegisterViewModel(IUserDataService userDataService)
        {
            _userDataService = userDataService;
            DoneCommand = new DelegateCommand(OnDoneExecute, OnDoneCanExecute);
           
        }

        private bool OnDoneCanExecute()
        {
            return true;
        }
        public delegate void RegisterSuccessfullyHandler();
        public event RegisterSuccessfullyHandler RegisterSuccessfullyEvent;
        private void OnDoneExecute()
        {

            //if (_userDataService.AddUser(_user))
            // MessageBox.Show(_user.Email);
            RegisterSuccessfullyEvent();
        }
        public string Name
        {
            get { return _user.Name; }
            set
            {
                if (value != _user.Name)
                {
                    _user.Name = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Email
        {
            get { return _user.Email; }
            set
            {
                if (value != _user.Email)
                {
                    _user.Email = value;
                    OnPropertyChanged();
                }
            }
        }
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
        public DateTime Birthday
        {
            get { return _user.Birthday; }
            set
            {
                if (value != _user.Birthday)
                {
                    _user.Birthday = value;
                    OnPropertyChanged();
                }
            }
        }
       
        public string UserName
        {
            get { return _user.Username; }
            set
            {
                if (value != _user.Username)
                {
                    _user.Username = value;
                    OnPropertyChanged();
                }
            }
        }
        private User _user=new User();
        //public User Userr
        //{

        //    get { return this._user; }
        //    set
        //    {
        //        // Implement with property changed handling for INotifyPropertyChanged

        //        this._user = value;
        //        this.OnPropertyChanged(); // Method to raise the PropertyChanged event in your BaseViewModel class...

        //    }
        //}

    }
}
