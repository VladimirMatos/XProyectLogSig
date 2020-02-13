using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinSigandLogPage
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage(string Email)
        {
            InitializeComponent();
            EntryUsername.Text = Email;
        }

        void IcShowandHidePass(System.Object sender, System.EventArgs e)
        {
            icPassShow.Source = !EntryPass.IsPassword ? "ic_show" : "ic_hide";
            EntryPass.IsPassword = !EntryPass.IsPassword;

        }
        async void GoToSignUpTapped(object sender, EventArgs e)
        {
           await Navigation.PushModalAsync(new SignUpPage(EntryUsername.Text,EntryPass.Text));
        }
        async void ButtonLogin(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EntryUsername.Text) || string.IsNullOrEmpty(EntryPass.Text))
            {
                await DisplayAlert("Alert", "You have been alerted", "OK");
            }
            else
            {
                await Navigation.PushModalAsync(new DiscoveryPage());
            }
           
        }
    }
}
