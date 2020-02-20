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
    public partial class DiscoveryPage : ContentPage   
    {
        public DiscoveryPage()
        {
            InitializeComponent();
            BindingContext = new DiscoveryPageViewModel();
        }

        private void TapNearby(object sender, EventArgs e)
        {
            
        }
    }
}