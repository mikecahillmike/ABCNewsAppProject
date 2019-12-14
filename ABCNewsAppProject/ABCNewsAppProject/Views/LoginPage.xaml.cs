using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABCNewsAppProject.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ABCNewsAppProject.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}
        void SignIn_Clicked(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.BlankInput())
            {
                DisplayAlert("Login", "Logged in", "");
            }
            else
            {
                DisplayAlert("Login", "Log in  failed", "");
            }
        }
	}
}