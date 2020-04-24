using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RGBConverterPP.ViewModels;


namespace RGBConverterPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ColorPicker : ContentPage
    {
        RGBConverterViewModel viewModel;

        public ColorPicker()
        {
            BindingContext = viewModel = new RGBConverterViewModel();

            InitializeComponent();
        }
    }
}