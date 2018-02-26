using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Support.V7.AppCompat;
using MyClubConnect.Core.ViewModels;

namespace MyClubConnect.Droid.Activities
{
    [Activity(
       Theme = "@style/AppTheme.Login",
       LaunchMode = LaunchMode.SingleTop,
       ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize,
       Name = "myClubConnect.droid.activities.LoginActivity"
    )]
    public class LoginActivity : MvxAppCompatActivity<LoginViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.LoginActivity);
        }
    }
}