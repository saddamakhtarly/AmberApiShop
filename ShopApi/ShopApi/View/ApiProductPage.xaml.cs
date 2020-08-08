using ShopApi.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopApi.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApiProductPage : ContentPage
    {
        public ApiProductPage()
        {
            InitializeComponent(); 
            BindingContext = new ApiProductPageViewModel(Navigation);
        }
    }
}