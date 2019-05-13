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
        private const string Url = "http://beirahost.com/new.json";
        // This handles the Web data request
        private HttpClient _client = new HttpClient();
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
                }
                catch(Exception e)
                {
                    Debug.WriteLine(e);
                }
            }
        }
    }
}