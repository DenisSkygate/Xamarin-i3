using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace UXDivers.Artina.Grial
{
	public partial class NavBarTC : ContentView
	{
		public NavBarTC()
		{
			InitializeComponent();

		}
		public void ChangeLeftLabel(string text, bool visible)
		{
			this.LeftLabel.Text = text;
			this.LeftLabel.IsVisible = visible;
		}
		public void ChangeCenterLabel(string text, bool visible)
		{
			this.CenterLabel.Text = text;
			this.CenterLabel.IsVisible = visible;
		}

		public void OnHamburgerIconTapped(Object sender, EventArgs e)
		{
			Element current = this;

			while (current.Parent != null)
			{
				current = current.Parent;
				if (current.GetType().Name == "RootPage")
				{
					break;
				}
			}

			var master = current as MasterDetailPage;

			if (master != null)
			{
				master.IsPresented = true;
			}
		}

		public async void OnLeftTapped(Object sender, EventArgs e)
		{
		//	await Navigation.PopAsync();
		}
		public async void OnRightTapped(Object sender, EventArgs e)
		{
		//	await Navigation.PushAsync(new PharmacyPage());
		}
	}
}

