using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinSigandLogPage.ViewModel;

namespace XamarinSigandLogPage.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
            BindingContext = new SignUpPageViewModel();

        }
        private void GoToLoginTapped(object sender, EventArgs e)
        {

        }

        private void SignUpButton(object sender, EventArgs e)
        {
  
        }
    }
}