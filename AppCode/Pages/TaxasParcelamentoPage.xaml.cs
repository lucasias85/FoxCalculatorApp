namespace FoxCalculatorApp.AppCode.Pages;

public partial class TaxasParcelamentoPage : ContentPage
{
	public TaxasParcelamentoPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked_NovasTaxas(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NovasTaxasPage());
    }
}