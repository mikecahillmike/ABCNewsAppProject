using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ABCNewsAppProject
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GamingPage : ContentPage
	{
		public GamingPage ()
		{
			InitializeComponent ();
		}

        private void Button_HomePage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}