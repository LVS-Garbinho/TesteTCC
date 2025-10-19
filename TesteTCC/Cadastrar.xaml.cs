namespace TesteTCC;

public partial class Cadastrar : ContentPage
{
	public Cadastrar()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        // Voltar para a página anterior
        await Navigation.PopAsync();
    }
}
