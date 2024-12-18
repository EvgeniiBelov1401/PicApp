using PicApp.Models;
using PicApp.Pages;
using PicApp.Services;
using PicApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PicApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new EntryPage());
        }

        protected override void OnStart()
        {
            
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
