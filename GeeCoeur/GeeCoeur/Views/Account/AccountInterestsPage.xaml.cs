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

        private void AddGame_Clicked(object sender, EventArgs e)
        {
            if (GameEntry.Text != "")
            {
                GeeCoeurPage.User.Games.Add(GameEntry.Text);
                var lab = new Label();
                lab.Text = GameEntry.Text;
                this.GamesLayout.Children.Add(lab);
                GameEntry.Text = "";
            }
        }

        private void AddMovies_Clicked(object sender, EventArgs e)
        {
            if (MoviesEntry.Text != "")
            {
                GeeCoeurPage.User.Movies.Add(MoviesEntry.Text);
                var lab = new Label();
                lab.Text = MoviesEntry.Text;
                this.MoviesLayout.Children.Add(lab);
                MoviesEntry.Text = "";
            }
        }
    }
}
