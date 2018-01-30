using HenHouseDomotica.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HenHouseDomotica
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
        }

        private async void LigaLuzesGalinheiro(object sender, EventArgs e)
        {
            await DisplayAlert("Menssagem", "Luzes Ligada com sucesso", "OK");
        }

        private async void DesligarLuzesGalinheiro(object sender, EventArgs e)
        {
            await DisplayAlert("Menssagem", "Luzes Desligada com sucesso", "OK");
        }

        private async void EventosCliked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new EventoPage());
        }

        private void AtualizarEstadoGalinheiro()
        {

        }
    }
}