using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinSigandLogPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage(string Email,string password)
        {
            InitializeComponent();
            EntryEmail.Text = Email;
            
        }
        async void GoToLoginTapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new LoginPage(EntryEmail.Text));
        }

        async void SignUpButton(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EntryEmail.Text) || string.IsNullOrEmpty(EntryPass.Text) || string.IsNullOrEmpty(EntryUsername.Text) || string.IsNullOrEmpty(EntryRepPass.Text))
            {
                await DisplayAlert("Alert", "You have been alerted", "OK");
            }
  
        }
    }
}