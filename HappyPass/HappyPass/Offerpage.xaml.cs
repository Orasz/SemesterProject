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
	public partial class Offerpage : ContentPage
	{
        public Offerpage()
        {
            InitializeComponent();
        }

        public Offerpage(string offName, string name, string address, string phone,string url, string mainImg, string mapImg)
        {
            InitializeComponent();
            OfferImg.Source = mainImg;
            OfferNamelbl.Text = offName;
            Namelbl.Text = name;
            Addresslbl.Text = address;
            Phonelbl.Text = phone;
            Urllbl.Text = url;
            MapImg.Source = mapImg;
        }
    }
}