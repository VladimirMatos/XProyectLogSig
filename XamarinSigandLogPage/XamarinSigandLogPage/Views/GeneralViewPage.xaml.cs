using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinSigandLogPage.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeneralViewPage : ContentView
    {
        public GeneralViewPage()
        {
           InitializeComponent();
        }
        public static readonly BindableProperty TextLabelProperty = BindableProperty.Create(nameof(TextLabel), typeof(string), typeof(GeneralViewPage), string.Empty);
        public string TextLabel
        {
            get => (string)GetValue(TextLabelProperty);
            set => SetValue(TextLabelProperty, value);
        }
        public static readonly BindableProperty ImageViewProperty = BindableProperty.Create(nameof(ImageView), typeof(ImageSource), typeof(GeneralViewPage), default(ImageSource));
        public ImageSource ImageView
        {
            get => (ImageSource)GetValue(ImageViewProperty);
            set => SetValue(ImageViewProperty, value);
        }
        public static readonly BindableProperty TextLabelSmallProperty = BindableProperty.Create(nameof(TextLabeSmall), typeof(string), typeof(GeneralViewPage), string.Empty);
        public string TextLabeSmall
        {
            get => (string)GetValue(TextLabelSmallProperty);
            set => SetValue(TextLabelSmallProperty, value);
        }

    }

}