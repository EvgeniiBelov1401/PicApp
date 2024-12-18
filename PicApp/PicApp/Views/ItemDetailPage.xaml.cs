using PicApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PicApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}