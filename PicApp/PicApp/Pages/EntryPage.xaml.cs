using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PicApp.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PicApp.Models;

namespace PicApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryPage : ContentPage
    {
        Profile profile = new Profile("1111");

        public Profile Profile { get;set; }
        public EntryPage()
        {
            InitializeComponent();
            
        }

        protected override void OnAppearing()
        {
            if (App.Current.Properties.TryGetValue("CurrentUser", out object profile))
            {
                Profile=profile as Profile;
                pinCode.Text=Profile.PinCode;
            }
            else
            {
                Profile=new Profile("1111");
                App.Current.Properties.Add("CurrentUser", Profile);
            }
            base.OnAppearing();
        }

        private void NotifyUser(object sender, ToggledEventArgs e)
        {
            if (pinCode.Text == profile.PinCode)
            {
                DisplayAlert("Внимание","Успешный вход","ОК");
            }
        }
        private async void Login_Click(object sender, EventArgs e)
        {
            if (pinCode.Text == profile.PinCode)
            {
                wrongPin.IsVisible = false;
                await Task.Delay(1500);
                await Navigation.PushAsync(new PictureListPage());
            }
            else
            {
                wrongPin.IsVisible = true;
            }
        }
    }
}