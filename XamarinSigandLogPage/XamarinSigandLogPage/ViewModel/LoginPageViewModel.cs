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
   public class LoginPageViewModel : INotifyPropertyChanged
    {
        public UserModels UserLogin { get; set; }
        public ICommand CommandValid { get; set; }
        public ICommand CommandGoToSignUpTapped { get; set; }
        public bool HideAndShow { get; set; }
        public string ImageView { get; set; }
        public ICommand CommandVisible { get; set; }
        public LoginPageViewModel()
        {
            UserLogin = new UserModels();
            HideAndShow = true;
            ImageView = "ic_show";
            CommandVisible = new Command(() =>
            {
                ImageView = !HideAndShow ? "ic_show" : "ic_hide";
                HideAndShow = !HideAndShow;
            }
            );

            CommandGoToSignUpTapped = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new SignUpPage());
            }
            );

            CommandValid = new Command(async()=>
            {
                if (string.IsNullOrEmpty(UserLogin.Username) || string.IsNullOrEmpty(UserLogin.Pass))
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
