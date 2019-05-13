using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HappyPass
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            HelpQrLbl.GestureRecognizers.Add(new TapGestureRecognizer((view) => OnHelpQrLblClicked()));
            HelpNumberLbl.GestureRecognizers.Add(new TapGestureRecognizer((view) => OnHelpNumberLblClicked()));
            UniqueNr.GestureRecognizers.Add(new TapGestureRecognizer((view) => OnNumberImgClicked()));
            QRCode.GestureRecognizers.Add(new TapGestureRecognizer((view) => OnNumberImgClicked()));
        }

        private async void OnNumberImgClicked()
        {
            await Navigation.PushModalAsync(new InfoPage());
        }

        private async void OnHelpNumberLblClicked()
        {
            await Navigation.PushModalAsync(new Help2Page());
        }

        private async void OnHelpQrLblClicked()
        {
            await Navigation.PushModalAsync(new Help1Page());
        }

        private async void SignInBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SignInPage());
        }
    }
}
