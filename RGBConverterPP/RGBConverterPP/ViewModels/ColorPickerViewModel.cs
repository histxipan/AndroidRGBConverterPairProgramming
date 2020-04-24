using System;
using System.Collections.Generic;
using System.Text;
using RGBConverterPP.Models;
using Xamarin.Forms;

namespace RGBConverterPP.ViewModels
{
    public class RGBConverterViewModel : BaseViewModel
    {
        private ColorDef _currentColor;


        double redOfColorPicker = 0;

        public double RedOfColorPicker
        {
            get { return redOfColorPicker; }
            set
            {
                _currentColor.Red = value;
                SetProperty(ref redOfColorPicker, value);
                OnPropertyChanged("Color");
            }
        }

        double greenOfColorPicker = 0;
        public double GreenOfColorPicker
        {
            get { return greenOfColorPicker; }
            set
            {
                _currentColor.Green = value;
                SetProperty(ref greenOfColorPicker, value);
                OnPropertyChanged("Color");
            }
        }

        double blueOfColorPicker = 0;
        public double BlueOfColorPicker
        {
            get { return blueOfColorPicker; }
            set
            {
                _currentColor.Blue = value;
                SetProperty(ref blueOfColorPicker, value);
                OnPropertyChanged("Color");
            }
        }

        Color color = Color.FromRgb(0, 0, 0);
        public Color Color
        {
            get
            {
                color = Color.FromRgb(Convert.ToInt32(_currentColor.Red), Convert.ToInt32(_currentColor.Green), Convert.ToInt32(_currentColor.Blue));
                return color;
            }

        }

        public RGBConverterViewModel()
        {
            Title = "ColorPicker";
            _currentColor = new ColorDef { Red = 0, Green = 0, Blue = 0 };
            RedOfColorPicker = _currentColor.Red;
            GreenOfColorPicker = _currentColor.Green;
            BlueOfColorPicker = _currentColor.Blue;
        }
    }

}
