using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ProjectProducts
{
    public class ProductsViewModel
    {
        public ObservableCollection<Product> Products { get; }
        public Product NewProduct { get; set; }
        public Command AddCommand { get; }
        public Command SaveCommand { get; }
        public Command DismissCommand { get; }

        public ProductsViewModel()
        {
            Products = new ObservableCollection<Product>()
            {
                new Product("PC", 20000),
                new Product("Mac", 70000),
                new Product("Smartphone", 8000)
            };

            NewProduct = new Product("", 0);

            AddCommand = new Command(OpenNewProduct);
            SaveCommand = new Command(SaveNewProduct);
            DismissCommand = new Command(DismissNewProduct);
        }

        private async void OpenNewProduct()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new NewProductPage(this));
        }

        private async void SaveNewProduct()
        {
            Products.Add(NewProduct);
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }

        private async void DismissNewProduct()
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}
