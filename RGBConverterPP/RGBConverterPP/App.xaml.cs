using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RGBConverterPP.Views;

namespace RGBConverterPP
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new ColorPicker();
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
