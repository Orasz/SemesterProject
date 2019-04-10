using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HappyPass
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();

           // GetDatafromAPI();
		}
        
        public class RootObject
        {
            public string date { get; set; }
            public string explanation { get; set; }
            public string media_type { get; set; }
            public string service_version { get; set; }
            public string title { get; set; }
            public string url { get; set; }
        }



       /* private async void GetDatafromAPI()
        {
            HttpClient client = new HttpClient();

            var response = await client.GetStringAsync("https://api.nasa.gov/neo/rest/v1/feed?start_date=2015-09-07&end_date=2015-09-08&api_key=uWIHKHVBfdX9jwm988Hb2ISkEAczjZt3dYQBOLNA");

            var mynewobject = JsonConvert.DeserializeObject<List<RootObject>>(response);

            ObjectView.ItemsSource = mynewobject;
        }*/
    }
}