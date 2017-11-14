using GeeCoeur.Model;
using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;

namespace GeeCoeur.Views.Account
{
    public partial class AccountPage : ContentPage
    {
        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            PicButton.IsEnabled = false;
            Stream stream = await DependencyService.Get<IPicturePicker>().GetImageStreamAsync();

            if (stream != null)
            {
                Image image = new Image
                {
                    Source = ImageSource.FromStream(() => stream),
                    BackgroundColor = Color.Gray
                };
                TapGestureRecognizer recognizer = new TapGestureRecognizer();
                recognizer.Tapped += (sender2, args) =>
                {
                };
                image.GestureRecognizers.Add(recognizer);

                ProfilePic.Children.Add(image);
            }
            else
            {
                PicButton.IsEnabled = true;
            }
        }
        public AccountPage()
        {
            InitializeComponent();
            updateVisibleInfo();
        }

        public void updateVisibleInfo()
        {
            if (GeeCoeurPage.SignedAccount.Email != null && GeeCoeurPage.SignedAccount.Email != "")
            {
                Label_Email.Text = GeeCoeurPage.SignedAccount.Email;
            }
            if (GeeCoeurPage.SignedAccount.Pseudo != null && GeeCoeurPage.SignedAccount.Pseudo != "")
            {
                Label_Pseudo.Text = GeeCoeurPage.SignedAccount.Pseudo;
            }
            if (GeeCoeurPage.SignedAccount.FirstName != null || GeeCoeurPage.SignedAccount.LastName != null)
            {
                Label_Name.Text = GeeCoeurPage.SignedAccount.FirstName + " " + GeeCoeurPage.SignedAccount.LastName;
            }
            if (GeeCoeurPage.SignedAccount.Birthday != null)
            {
                Label_BirthDay.Text = GeeCoeurPage.SignedAccount.Birthday.Date.ToString();
            }

            Switch_Friend.IsToggled = GeeCoeurPage.SignedAccount.Status[0];
            Switch_FriendPlus.IsToggled = GeeCoeurPage.SignedAccount.Status[1];
            Switch_Player2.IsToggled = GeeCoeurPage.SignedAccount.Status[2];

            // Update Skills
            foreach (Skill newItem in GeeCoeurPage.SignedAccount.Skills)
            {
                var label = new Label();
                label.Text = newItem.name;
                SkillsLayout.Children.Add(label);
            }
            // Update Movies
            foreach (string newItem in GeeCoeurPage.SignedAccount.Movies)
            {
                var label = new Label();
                label.Text = newItem;
                MovieList.Children.Add(label);
            }
            // Update Games
            foreach (string newItem in GeeCoeurPage.SignedAccount.Games)
            {
                var label = new Label();
                label.Text = newItem;
                GameList.Children.Add(label);
            }
            // Update Music
            foreach (string newItem in GeeCoeurPage.SignedAccount.Music)
            {
                var label = new Label();
                label.Text = newItem;
                MusicList.Children.Add(label);
            }
            // Update Books
            foreach (string newItem in GeeCoeurPage.SignedAccount.Books)
            {
                var label = new Label();
                label.Text = newItem;
                BookList.Children.Add(label);
            }
            foreach (string newItem in GeeCoeurPage.SignedAccount.TvShows)
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
