using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ABCNewsAppProject.Views;
using ABCNewsAppProject.Models;

namespace ABCNewsAppProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            var image = new Image { Source = "ABCNewsPic.jpg" };
            InitializeComponent();
        }

        private void Button_LogIn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

        private void Button_PopularNews_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PopularPage());
        }

        private void Button_GamingNews_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GamingPage());
        }

        private void Button_SportsNews_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SportsPage());
        }

        private void Button_CelebrityNews_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CelebrityPage());
        }
    }
}
