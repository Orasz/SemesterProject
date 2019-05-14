using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Plugin.Connectivity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HappyPass
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        private const string Url = "http://beirahost.com/HappyPassOffers.json";
        // This handles the Web data request
        private HttpClient _client = new HttpClient();
        public List<Offer> list;

        [Obsolete]
        public Page1()
        {
            InitializeComponent();
            OnGetList();

        }

        protected async void OnGetList()
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                try
                {
                    var content = await _client.GetStringAsync(Url);
                    var tr = JsonConvert.DeserializeObject<List<Offer>>(content);
                    ObservableCollection<Offer> offers = new ObservableCollection<Offer>(tr);
                    myList.ItemsSource = offers;
                    list = tr;
                }
                catch(Exception e)
                {
                    Debug.WriteLine(e);
                }
            }
        }

        private async void offerPage(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            string OfferName = lbl.Text;
            string offName, Name, Address, Phone, Url, MapImg, MainImg;
            Offer o;
            if(list.Find(i => i.OfferName == OfferName) != null)
            {
               o = list.Find(i => i.OfferName == OfferName);
            }
            else
            {
               o = new Offer();
            }
            offName = o.OfferName;
            Name = o.Name;
            Address = o.Address;
            Phone = o.Phone;
            Url = o.Url;
            MapImg = o.MapImage;
            MainImg = o.MainImage;
            await Navigation.PushModalAsync(new Offerpage( offName, Name, Address, Phone, Url,MainImg,MapImg)) ;
            
        }
    }
}