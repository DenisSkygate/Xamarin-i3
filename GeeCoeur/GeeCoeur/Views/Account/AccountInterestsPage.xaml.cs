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

            ShowExistingInterests(MovieLayout, GeeCoeurPage.SignedAccount.Movies);
            ShowExistingInterests(GamesLayout, GeeCoeurPage.SignedAccount.Games);
            ShowExistingInterests(MusicsLayout, GeeCoeurPage.SignedAccount.Music);
            ShowExistingInterests(TvShowsLayout, GeeCoeurPage.SignedAccount.TvShows);
            ShowExistingInterests(BooksLayout, GeeCoeurPage.SignedAccount.Books);


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
            AddInterest(GamesEntry, GamesLayout, GeeCoeurPage.SignedAccount.Games);
        }

        void AddMovies_Clicked(object sender, System.EventArgs e)
        {
            AddInterest(MoviesEntry, MovieLayout, GeeCoeurPage.SignedAccount.Movies);
        }

        void AddBooks_Clicked(object sender, System.EventArgs e)
        {
            AddInterest(BooksEntry, BooksLayout, GeeCoeurPage.SignedAccount.Books);
        }

        void AddTvShows_Clicked(object sender, System.EventArgs e)
        {
            AddInterest(TvShowsEntry, TvShowsLayout, GeeCoeurPage.SignedAccount.TvShows);
        }

        void AddMusics_Clicked(object sender, System.EventArgs e)
        {
            AddInterest(MusicsEntry, MusicsLayout, GeeCoeurPage.SignedAccount.Music);
        }

        void AddInterest(Entry entry, StackLayout layout, List<string> theList)
        {
            if (entry.Text != "")
            {
                InterestView interest = new InterestView(entry.Text, theList);
                interest.AddToList();
                layout.Children.Add(interest);
                entry.Text = "";
            }
        }

        void ShowExistingInterests(StackLayout layout, List<string> theList)
        {
            foreach (string item in theList)
            {
                InterestView interest = new InterestView(item, theList);
                layout.Children.Add(interest);
            }
            
        }
    }
}
