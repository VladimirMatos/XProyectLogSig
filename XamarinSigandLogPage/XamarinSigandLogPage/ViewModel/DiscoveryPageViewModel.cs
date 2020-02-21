using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinSigandLogPage.Models;

namespace XamarinSigandLogPage.ViewModel
{
    public class DiscoveryPageViewModel : INotifyPropertyChanged
    {

        public Color ColorBars {get; set; }
        public Color ColorCafe{ get; set; }
        public Color ColorFastFood{ get; set; }
        public Color ColorFineDining{ get; set; }
        public Color ColorNearby{ get; set; }
        public Color ColorFeatured{ get; set; }
        public UserModel UserDisc { get; set; }
        public ICommand CommandColorChange { get=> new Command((ColorSwitch)=> 
        {
            if (ColorSwitch.ToString() == "BarsHotels" )
            {
                ColorBars = Color.Gold;
            }
            else if (ColorSwitch.ToString() == "Cafe" )
            {
                ColorCafe = Color.Gold;
            }
            else if (ColorSwitch.ToString() == "FastFood" )
            {
                ColorFastFood = Color.Gold;
            }
            else if (  ColorSwitch.ToString() == "FineDining" )
            {
                ColorFineDining = Color.Gold;
            }
            else if ( ColorSwitch.ToString() == "Nearby" )
            {
                ColorNearby = Color.Gold;
            }
            else if ( ColorSwitch.ToString() == "FeaturedFoods")
            {
                ColorFeatured = Color.Gold;
            }
        }); 
          }
        public Items BarsandHotels { get; set; }
        public Items Cafe { get; set; }
        public Items FastFood { get; set; }
        public Items FineDining { get; set; }
        public Items Nearby { get; set; }
        public Items FeaturedFoods { get; set; }

        public Items LabelBarsandHotels { get; set; }
        public Items LabelCafe { get; set; }
        public Items LabelFastFood { get; set; }
        public Items LabelFineDining { get; set; }
        public Items LabelNearby { get; set; }
        public Items LabelFeaturedFoods { get; set; }

        public DiscoveryPageViewModel()
        {
            UserDisc = new UserModel();
            BarsandHotels = new Items()
            {
                ImageView = "cerveza", 
                LabelText= "Bar And Hotels"
            };

            Cafe = new Items()
            {
                ImageView = "cafeteria",
                LabelText = "Cafe"
            };

            FastFood = new Items()
            {
                ImageView = "comida",
                LabelText = "Fast Food"
            };

            FineDining = new Items()
            {
                ImageView = "camarero",
                LabelText = "Fine Dining"
            };

            Nearby = new Items()
            {
                ImageView = "alfiler",
                LabelText = "Nearby"
            };

            FeaturedFoods = new Items()
            {
                ImageView = "pizza",
                LabelText = "Featured Foods"
            };

        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}    

