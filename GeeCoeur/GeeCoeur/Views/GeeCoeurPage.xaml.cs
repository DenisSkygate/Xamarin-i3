using System;
using System.Collections.Generic;
using GeeCoeur.Views.Account;
using Xamarin.Forms;
using GeeCoeur.Model;

namespace GeeCoeur
{
    public partial class GeeCoeurPage : ContentPage
    {
        public GeeCoeurPage()
        {
            InitializeComponent();
            if (!Logged){
                LaunchLogin();
            }
        }
      
       

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AccountPage());
        }

        private void LaunchLogin()
        {
            var account = new AccountCreationPage();

            Navigation.PushAsync(account);
        }
        public static bool Logged = false;
        public static bool AccountCompleted = false;

        public static Account SignedAccount = new Account();

    }
}
