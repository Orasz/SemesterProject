using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HappyPass
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisterPage : ContentPage
	{
		public RegisterPage ()
		{
			InitializeComponent ();
		}

        private async void ContinueBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new TabbedRoot());
        }
        private async void RegisterBtnClicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(NameEntry.Text)&&
               !string.IsNullOrWhiteSpace(AgeEntry.Text) &&
               !string.IsNullOrWhiteSpace(EmailEntry.Text)&&
               !string.IsNullOrWhiteSpace(AddressEntry.Text)&&
               !string.IsNullOrWhiteSpace(GenderEntry.Text)&&
               !string.IsNullOrWhiteSpace(NumChildEntry.Text)&&
               !string.IsNullOrWhiteSpace(UserIDEntry.Text))
            {
                await App.Database.SaveUserAsync(new User
                {
                    Name = NameEntry.Text,
                    Age = int.Parse(AgeEntry.Text),
                    Email = EmailEntry.Text,
                    Address = AddressEntry.Text,
                    Sex = GenderEntry.Text,
                    NChildren = int.Parse(NumChildEntry.Text),
                    UserID = long.Parse(UserIDEntry.Text)
                });
                await Navigation.PushModalAsync(new TabbedRoot());
            }
            else
            {
                await DisplayAlert("Error", "invalid input", "close");
            }

        }
    }
}