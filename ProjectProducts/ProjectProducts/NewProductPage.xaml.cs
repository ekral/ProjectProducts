using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectProducts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewProductPage : ContentPage
    {
        private readonly ProductsViewModel productsViewModel;

        public NewProductPage(ProductsViewModel productsViewModel)
        {
            InitializeComponent();
            BindingContext = this.productsViewModel = productsViewModel;
        }
    }
}