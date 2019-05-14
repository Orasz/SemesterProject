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
	public partial class Help2Page : ContentPage
	{
        [Obsolete]
        public Help2Page ()
		{
			InitializeComponent ();
            NrImg.GestureRecognizers.Add(new TapGestureRecognizer((view) => OnImgClicked()));

        }
        private void BackBtnClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
        private void OnImgClicked()
        {
            Navigation.PushModalAsync(new InfoPage());
        }
    }
}