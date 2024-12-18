using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PicApp.Models
{
    public class Profile:INotifyPropertyChanged
    {
        public string PinCode { get; set; }

        public Profile(string pincode)
        {
            this.PinCode = pincode;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
