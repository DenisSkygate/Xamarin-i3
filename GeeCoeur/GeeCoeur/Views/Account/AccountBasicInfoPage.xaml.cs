﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GeeCoeur.Views.Account
{
    public partial class AccountBasicInfoPage : ContentPage
    {
        public AccountBasicInfoPage()
        {
            InitializeComponent();
        }
        void Next_Clicked(object sender, System.EventArgs e)
        {
            GeeCoeurPage.FirstName = FirstName.Text;
            GeeCoeurPage.LastName = Lastname.Text;
            GeeCoeurPage.Username = Username.Text;
            var papa = (this.Parent as TabbedPage);
            papa.CurrentPage = papa.Children[papa.Children.IndexOf(this)+1];
        }

    }
}
