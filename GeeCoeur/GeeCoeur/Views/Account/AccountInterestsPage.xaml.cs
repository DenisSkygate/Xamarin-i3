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
            GamesEntry.Text = "";
            MoviesEntry.Text = "";
            BooksEntry.Text = "";
            TvShowsEntry.Text = "";
            MusicsEntry.Text = "";
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

        // Here are the buttons to add the interests

        void AddGames_Clicked(object sender, System.EventArgs e)
        {
            if (GamesEntry.Text != "")
            {
                var interest = new InterestView(GamesEntry.Text, GeeCoeurPage.SignedAccount.Games);
                this.GamesLayout.Children.Add(interest);
                GamesEntry.Text = "";
            }
        }

        void AddMovies_Clicked(object sender, System.EventArgs e)
        {
            if (MoviesEntry.Text != "")
            {
                var interest = new InterestView(MoviesEntry.Text, GeeCoeurPage.SignedAccount.Movies);
                this.MovieLayout.Children.Add(interest);
                MoviesEntry.Text = "";
            }
        }

        void AddBooks_Clicked(object sender, System.EventArgs e)
        {
            if (BooksEntry.Text != "")
            {
                var interest = new InterestView(BooksEntry.Text, GeeCoeurPage.SignedAccount.Books);
                this.BooksLayout.Children.Add(interest);
                BooksEntry.Text = "";
            }
        }

        void AddTvShows_Clicked(object sender, System.EventArgs e)
        {
            if (TvShowsEntry.Text != "")
            {
                var interest = new InterestView(TvShowsEntry.Text, GeeCoeurPage.SignedAccount.TvShows);
                this.TvShowsLayout.Children.Add(interest);
                TvShowsEntry.Text = "";
            }
        }

        void AddMusics_Clicked(object sender, System.EventArgs e)
        {
            if (MusicsEntry.Text != "")
            {
                var interest = new InterestView(MusicsEntry.Text, GeeCoeurPage.SignedAccount.Music);
                this.MusicsLayout.Children.Add(interest);
                MusicsEntry.Text = "";
            }
        }
    }
}
