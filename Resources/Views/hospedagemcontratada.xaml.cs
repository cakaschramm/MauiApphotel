namespace MauiApphotel.Resources.Views;

public partial class hospedagemcontratada : ContentPage
{
    public hospedagemcontratada()
    {
        InitializeComponent();
    }

    private async void ButtonVoltar_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new contratacaohospedagem());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}