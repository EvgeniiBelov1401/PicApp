using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PicApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PictureListPage : ContentPage
    {
        private List<string> _imageSources;

        public PictureListPage()
        {
            InitializeComponent();
            LoadImages();
            imagesCollectionView.ItemsSource = _imageSources;
        }

        private void LoadImages()
        {

            _imageSources = new List<string>
            {
                "image1.jpg",
                "image2.jpg",
                "image3.jpg",
            };
        }

        private async void OnImageSelected(object sender, SelectionChangedEventArgs e)
        {

            var selectedImage = (string)e.CurrentSelection[0];
            if (selectedImage != null)
            {
                await Navigation.PushAsync(new ImageDetailPage(selectedImage));
            }
        }
    }
}