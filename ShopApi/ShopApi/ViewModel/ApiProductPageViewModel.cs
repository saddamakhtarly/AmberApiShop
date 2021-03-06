﻿using ShopApi.Models;
using ShopApi.View;
using ShopApi.WebService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ShopApi.ViewModel
{
    public class ApiProductPageViewModel : NotifyModel
    {
        public INavigation Navigation { get; set; }
        public ApiProductPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }

        public Command ShowProduct
        {
            get
            {
                return new Command(async () =>
                {

                    var resp = await new ApiFunctions().apiproduct(GlobalVariables.apilogin.access_token);
                    Products = new ObservableCollection<ProductDate>(resp.data as List<ProductDate>);
                   

                });
            }

        }

        ObservableCollection<ProductDate> _products;
        public ObservableCollection<ProductDate> Products
        {
            get { return _products; }
            set
            {
                _products = value;
                OnPropertyChanged();
            }
        }
    }
}
