using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyClubConnect.Core.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public LoginViewModel() 
        {
            Username = "TestUser";
            Password = "YouCantSeeMe";
            IsLoading = false;
        }

        private string _username;
        public string Username
        {
            get
            {
                return _username;
            }

            set
            {
                SetProperty(ref _username, value);
                RaisePropertyChanged(() => Username);
            }
        }

        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                SetProperty(ref _password, value);
                RaisePropertyChanged(() => Password);
            }
        }

        private bool _isLoading;

        public bool IsLoading
        {
            get
            {
                return _isLoading;
            }

            set
            {
                SetProperty(ref _isLoading, value);
            }
        }

        private IMvxCommand _loginCommand;
        public virtual IMvxCommand LoginCommand
        {
            get
            {
                _loginCommand = _loginCommand ?? new MvxCommand(() => ShowViewModel<MainViewModel>());
                return _loginCommand;
            }
        }
    }
}
