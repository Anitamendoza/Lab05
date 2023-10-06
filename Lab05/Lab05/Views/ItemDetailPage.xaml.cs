using Lab05.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Lab05.Views
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