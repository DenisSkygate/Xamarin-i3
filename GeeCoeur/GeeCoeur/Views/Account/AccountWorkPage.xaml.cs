using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GeeCoeur.Views.Account
{
    public partial class AccountWorkPage : ContentPage
    {
        public AccountWorkPage()
        {
            InitializeComponent();
        }
        async void Next_Clicked(object sender, System.EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new GeeCoeurPage());

            // await (this.Parent as TabbedPage).Navigation.PopAsync();

            GeeCoeurPage.SignedAccount.Work.Title = Title.Text;
            GeeCoeurPage.SignedAccount.Work.Description = Description.Text;
        }
        void Back_Clicked(object sender, System.EventArgs e)
        {
            var papa = (this.Parent as TabbedPage);
            papa.CurrentPage = papa.Children[papa.Children.IndexOf(this) -1];
        }
    }
}