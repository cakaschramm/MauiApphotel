using MauiApphotel.Models;
using MauiApphotel.Properties.Models;
namespace MauiApphotel.Resources.Views;

public partial class contratacaohospedagem : ContentPage
{
    App PropriedadesApp;

    public contratacaohospedagem()
    {
        InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

        dtpck_checkin.MinimumDate = DateTime.Now;
        dtpck_checkin.MaximumDate = DateTime.Now.AddMonths(1);

        dtpck_checkout.MinimumDate = dtpck_checkin.Date?.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date?.AddMonths(2);
    }

    private void btn_contratar_Clicked(object sender, EventArgs e)
    {
        try
        {
            hospedagem h = new()
            { 
            QntAdultos = Convert.ToInt32(stp_adultos.Value),
            QntCriancas = Convert.ToInt32(stp_criancas.Value),
            QuartoSelecionado = (Quarto) pck_quarto.SelectedItem,
            DataCheckIn = dtpck_checkin.Date,
            DataCheckOut = dtpck_checkout.Date
            };
            Navigation.PushAsync(new hospedagemcontratada()
            {
                BindingContext = h
            });
        }
        catch (Exception ex)

        {
            Console.WriteLine(ex.Message);
        }
    }

    private async void btnsobre_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new Sobre());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        dtpck_checkout.MinimumDate = e.NewDate?.AddDays(1);
        dtpck_checkout.MaximumDate = e.NewDate?.AddMonths(2);

    }
}