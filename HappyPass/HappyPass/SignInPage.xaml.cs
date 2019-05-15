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
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        private async void SignInBtn_Clicked(object sender, EventArgs e)
        {
            //check if user exists in the db, otherwise go to registerPage
            if (!string.IsNullOrWhiteSpace(UniNumEntry.Text))
            {
                if (App.Database.CheckUserAsync(long.Parse(UniNumEntry.Text)))
                {
                    await Navigation.PushModalAsync(new TabbedRoot());
                }
                else
                {
                    await DisplayAlert("Error", "There's no user with this ID", "Close");
                }
            }
        }
    }
}