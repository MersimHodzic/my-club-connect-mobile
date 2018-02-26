using MvvmCross.Core.ViewModels;
using MyClubConnect.Core.Services.Interfaces;
using MyClubConnect.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyClubConnect.Core
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        private IAuthenticationService _authenticationService;

        public AppStart(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public void Start(object hint = null)
        {
            if (_authenticationService.Authenticate())
            {
                ShowViewModel<MainViewModel>();
            }
            else
            {
                ShowViewModel<LoginViewModel>();
            }
        }
    }
}
