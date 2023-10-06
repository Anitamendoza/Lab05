using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab05
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //this.dtPrueba.MaximumDate= DateTime.Now;
            //dtPrueba.MaximumDate = DateTime.Now;

            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ButtonDemo());
            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ButtonCode());
            };
            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new DatepickerDemo());
            };
            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EditorDemo());
            };
            Item5.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EditorCode());
            };
            Item6.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EntryDemo());
            };
            Item7.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EntryCode());
            };
            Item8.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new LabelDemo());
            };
            Item9.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new LabelCode());
            };
            Item10.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new LocalImage());
            };
            Item11.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EmbeddedImage());
            };
        }
    }
}