using ShopApi.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopApi
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage =new NavigationPage( new ApiLoginPage());
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
