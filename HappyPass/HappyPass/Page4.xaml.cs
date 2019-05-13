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
	public partial class Page4 : ContentPage
	{
		public Page4 ()
		{
			InitializeComponent ();
            for(int i = 6;i < 100; i++)
            {
                AgePicker.Items.Add(i.ToString());
            }
            for(int i = 0; i<4; i++)
            {
                KidsPicker.Items.Add(i.ToString());
            }
            KidsPicker.Items.Add("4+");
            SexPicker.Items.Add("Male");
            SexPicker.Items.Add("Female");
            CountryPicker.Items.Add("Norway");
            CountryPicker.Items.Add("Sweden");
            CountryPicker.Items.Add("Denmark");
            CountryPicker.Items.Add("Finland");
            CountryPicker.Items.Add("Germany");
            CountryPicker.Items.Add("Italy");
            CountryPicker.Items.Add("Portugal");
            CountryPicker.Items.Add("Spain");
            CountryPicker.Items.Add("Holland");
            CountryPicker.Items.Add("France");




        }
    }
}