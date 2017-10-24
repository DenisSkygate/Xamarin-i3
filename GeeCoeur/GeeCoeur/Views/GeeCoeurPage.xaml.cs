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
            var account = new AccountCreationPage();
            account.Disappearing += LoginDisapeared;
            Navigation.PushModalAsync(account);
        }

        private void LoginDisapeared(object sender, EventArgs e)
        {
            var account = new AccountCompletionPage();
            Navigation.PushModalAsync(account);
        }



        public static bool Logged = false;
        public static bool AccountCompleted = false;



        public static string Email;
        public static string Password;

        public static string FirstName;
        public static string LastName;
        public static string Username;
        public static DateTime Birthday;

        static public List<string> Skills;

    }
}
