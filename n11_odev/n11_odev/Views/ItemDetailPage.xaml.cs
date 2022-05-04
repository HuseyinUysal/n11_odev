using n11_odev.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace n11_odev.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}