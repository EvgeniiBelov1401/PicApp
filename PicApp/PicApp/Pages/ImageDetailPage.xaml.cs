﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PicApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageDetailPage : ContentPage
    {
        public ImageDetailPage(string imageSource)
        {
            InitializeComponent();
            imageDetail.Source = imageSource; 
        }
    }
}
}