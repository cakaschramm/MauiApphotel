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
        dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);
        
        dtpck_checkout.MinimumDate = dtpck_checkin.Date?.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date?.AddMonths(2);    }

    private async void btn_contratar_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new hospedagemcontratada());
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