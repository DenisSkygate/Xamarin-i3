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
            if (!Logged)
                LaunchLogin();


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


        public static string email;
        public static string password;
        public static string pseudo;

        public static string firstName;
        public static string lastName;
        public static DateTime birthday;

        public static bool status_Friend;
        public static bool status_FriendPlus;
        public static bool status_Player2;

        public static List<string> Movies = new List<string>();
        public static List<string> TvShows = new List<string>();
        public static List<string> Books = new List<string>();
        public static List<string> Music = new List<string>();

        public static List<Skill> Skills = new List<Skill>();

        public static List<string> Games = new List<string>();

    }
}
