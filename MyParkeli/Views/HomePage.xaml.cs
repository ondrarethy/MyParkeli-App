using System;
using System.Collections.Generic;
using MyParkeli.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyParkeli.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        private HomeViewModel viewModel;

        public HomePage()
        {
            InitializeComponent();
            this.viewModel = new HomeViewModel();
            this.BindingContext = this.viewModel;
        }
    }
}
