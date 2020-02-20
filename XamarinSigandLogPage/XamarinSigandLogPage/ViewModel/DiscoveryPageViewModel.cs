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
        

        public UserModels UserDisc { get; set; }
        public ICommand CommandColorChange { get; set; }

        public DiscoveryPageViewModel()
        {
            UserDisc = new UserModels();

            CommandColorChange = new Command(() =>
            {
                
            }
            );
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
       
}
