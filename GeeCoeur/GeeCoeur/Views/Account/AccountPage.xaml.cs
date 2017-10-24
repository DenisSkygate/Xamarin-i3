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
        }
    }
}
