using FoxCalculatorApp.AppCode.Models;

namespace FoxCalculatorApp.AppCode.Pages;

public partial class NovasTaxasPage : ContentPage
{
	TaxasModel tx = new TaxasModel();

	public NovasTaxasPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked_AplicarTaxas(object sender, EventArgs e)
    {
		tx.Parcela01 = Convert.ToDouble(textBoxParcela01.Text);
		tx.Parcela02 = Convert.ToDouble(textBoxParcela02.Text);
        tx.Parcela03 = Convert.ToDouble(textBoxParcela03.Text);
        tx.Parcela04 = Convert.ToDouble(textBoxParcela04.Text);
        tx.Parcela05 = Convert.ToDouble(textBoxParcela05.Text);
        tx.Parcela06 = Convert.ToDouble(textBoxParcela06.Text);
        tx.Parcela07 = Convert.ToDouble(textBoxParcela07.Text);
        tx.Parcela08 = Convert.ToDouble(textBoxParcela08.Text);
        tx.Parcela09 = Convert.ToDouble(textBoxParcela09.Text);
        tx.Parcela10 = Convert.ToDouble(textBoxParcela10.Text);
        tx.Parcela11 = Convert.ToDouble(textBoxParcela11.Text);
        tx.Parcela12 = Convert.ToDouble(textBoxParcela12.Text);

        try
        {
            await App.Database.Inserir(tx);
            await DisplayAlert("Sucesso", "Taxas Cadastradas", "OK");
            await Navigation.PushAsync(new TaxasParcelamentoPage());
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro!", "Não foi possível salvar as novas taxas: " + ex.Message, "OK");
        }

    }
}