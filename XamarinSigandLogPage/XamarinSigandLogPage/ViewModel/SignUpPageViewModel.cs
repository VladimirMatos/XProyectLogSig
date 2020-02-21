using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinSigandLogPage.Models;
using XamarinSigandLogPage.Views;

namespace XamarinSigandLogPage.ViewModel
{
    public class SignUpPageViewModel : INotifyPropertyChanged
    {
        public UserModel UserSign { get; set; }
        public ICommand CommandGoToLoginTapped { get; set; }
        public ICommand CommandValid { get; set; }
        public int MyProperty { get; set; }
        public SignUpPageViewModel()
        {
            UserSign = new UserModel();

            CommandGoToLoginTapped = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PopToRootAsync();
            }
            );

            CommandValid = new Command(async () =>
            {
                if (string.IsNullOrEmpty(UserSign.Email) || string.IsNullOrEmpty(UserSign.Pass) || string.IsNullOrEmpty(UserSign.Username) || string.IsNullOrEmpty(UserSign.Repass))
                {
                    await App.Current.MainPage.DisplayAlert("Alert", "You have been alerted", "OK");
                }
                else
                {
                    await App.Current.MainPage.Navigation.PushAsync(new MenuTabbedPage());
                }
            }
          
            );
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
