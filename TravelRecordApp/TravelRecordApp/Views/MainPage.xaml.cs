using System;
using System.Collections.Generic;
using System.ComponentModel;
using TravelRecordApp.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TravelRecordApp.ViewModel;

namespace TravelRecordApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        MainViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();

            var assembly = typeof(MainPage);

            viewModel = new MainViewModel();
            BindingContext = viewModel;

            iconImage.Source = ImageSource.FromResource("TravelRecordApp.Assets.Images.plane.png", assembly);
        }


        private void registerButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }
    }
}
