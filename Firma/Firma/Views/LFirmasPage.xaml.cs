using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Firma.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LFirmasPage : ContentPage
    {


        public LFirmasPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            var listadireccione = await App.BaseDatos.ObtenerListaFirmas();
            lsfirmas.ItemsSource = listadireccione;
        }

        private async void toolbar01_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new SignaturePage());

        }

        private void lsfirmas_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}