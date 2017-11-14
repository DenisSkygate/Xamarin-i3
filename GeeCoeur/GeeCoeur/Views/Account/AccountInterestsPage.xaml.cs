using GeeCoeur.Views.Account.Items;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GeeCoeur.Views.Account
{
    public partial class AccountInterestsPage : ContentPage
    {
        public AccountInterestsPage()
        {
            InitializeComponent();
        }
        void Next_Clicked(object sender, System.EventArgs e)
        {
            var papa = (this.Parent as TabbedPage);
            papa.CurrentPage = papa.Children[papa.Children.IndexOf(this) + 1];
        }

        void Back_Clicked(object sender, System.EventArgs e)
        {
            var papa = (this.Parent as TabbedPage);
            papa.CurrentPage = papa.Children[papa.Children.IndexOf(this) - 1];
        }

        void AddGames_Clicked(object sender, System.EventArgs e)
        {
            var interest = new InterestView(GamesEntry.Text, GeeCoeurPage.SignedAccount.Games);
            this.GamesLayout.Children.Add(interest);
            GamesEntry.Text = "";
        }

        void AddMovies_Clicked(object sender, System.EventArgs e)
        {
            var interest = new InterestView(MoviesEntry.Text, GeeCoeurPage.SignedAccount.Movies);
            this.MovieLayout.Children.Add(interest);
            MoviesEntry.Text = "";
        }

        void AddBooks_Clicked(object sender, System.EventArgs e)
        {
            var interest = new InterestView(BooksEntry.Text, GeeCoeurPage.SignedAccount.Books);
            this.BooksLayout.Children.Add(interest);
            BooksEntry.Text = "";
        }

        // Add TvShows & Musics
    }
}
