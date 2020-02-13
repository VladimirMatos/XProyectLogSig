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
    public partial class DiscoveryPage : ContentPage
    {
        public DiscoveryPage()
        {
            InitializeComponent();
        }

        private void TapNearby(object sender, EventArgs e)
        {
            var TapColor = (GeneralViewPage)sender;
            if (TapColor.BackgroundColor == Color.Default)
            {
                TapColor.BackgroundColor = Color.Gold;
            }
            else
            {
                TapColor.BackgroundColor = Color.Default;
            }
        }
    }
}