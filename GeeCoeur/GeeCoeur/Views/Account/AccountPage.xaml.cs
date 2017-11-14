using GeeCoeur.Model;
using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;

namespace GeeCoeur.Views.Account
{
    public partial class AccountPage : ContentPage
    {
        
        public AccountPage()
        {
            InitializeComponent();
            updateVisibleInfo();
        }

        public void updateVisibleInfo()
        {
            if (GeeCoeurPage.email != null && GeeCoeurPage.email != "")
            {
                Label_Email.Text = GeeCoeurPage.email;
            }
            if (GeeCoeurPage.pseudo != null && GeeCoeurPage.pseudo != "")
            {
                Label_Pseudo.Text = GeeCoeurPage.pseudo;
            }
            if (GeeCoeurPage.firstName != null || GeeCoeurPage.lastName != null)
            {
                Label_Name.Text = GeeCoeurPage.firstName + GeeCoeurPage.lastName;
            }
            if (GeeCoeurPage.birthday != null)
            {
                Label_BirthDay.Text = GeeCoeurPage.birthday.Date.ToString();
            }

            Switch_Friend.IsToggled = GeeCoeurPage.status_Friend;
            Switch_FriendPlus.IsToggled = GeeCoeurPage.status_FriendPlus;
            Switch_Player2.IsToggled = GeeCoeurPage.status_Player2;

            // Update Skills
            foreach (Skill newItem in GeeCoeurPage.Skills)
            {
                var label = new Label();
                label.Text = newItem.name;
                SkillsLayout.Children.Add(label);
            }
            // Update Movies
            foreach (string newItem in GeeCoeurPage.Movies)
            {
                var label = new Label();
                label.Text = newItem;
                MovieList.Children.Add(label);
            }
            // Update Games
            foreach (string newItem in GeeCoeurPage.Games)
            {
                var label = new Label();
                label.Text = newItem;
                GameList.Children.Add(label);
            }
            // Update Music
            foreach (string newItem in GeeCoeurPage.Music)
            {
                var label = new Label();
                label.Text = newItem;
                MusicList.Children.Add(label);
            }
            // Update Books
            foreach (string newItem in GeeCoeurPage.Books)
            {
                var label = new Label();
                label.Text = newItem;
                BookList.Children.Add(label);
            }
            foreach (string newItem in GeeCoeurPage.TvShows)
            {
                var label = new Label();
                label.Text = newItem;
                TvShowsList.Children.Add(label);
            }
            
        }


        private void ButtonUpdate_Clicked(object sender, EventArgs e)
        {
            updateVisibleInfo();
        }
    }
}
