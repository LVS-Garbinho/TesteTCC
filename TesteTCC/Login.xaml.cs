namespace TesteTCC;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        // Pega os textos digitados
        string nome = Nome.Text;
        string senha = Senha.Text;

        // Validação simples
        if (!string.IsNullOrWhiteSpace(nome) && !string.IsNullOrWhiteSpace(senha))
        {
            // Navega para a HomePage
            await Navigation.PushAsync(new HomePage());
        }
        else
        {
            await DisplayAlert("Erro", "Por favor, preencha nome e senha.", "OK");
        }

    }
}

