using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GeeCoeur
{
    public partial class GeeCoeurPage : ContentPage
    {
        public GeeCoeurPage()
        {
            InitializeComponent();
            if (!Logged)
                LaunchLogin();
        }

        private void LaunchLogin()
        {
            Navigation.PushModalAsync(new AccountCreationPage());
        }

        static bool Logged = false;
    }
}
