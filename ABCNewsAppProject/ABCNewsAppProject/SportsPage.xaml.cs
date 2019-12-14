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
	public partial class SportsPage : ContentPage
	{
		public SportsPage ()
		{
            var image = new Image { Source = "SportsPic.jpg" };
            InitializeComponent ();
		}

        private void Button_HomePage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}