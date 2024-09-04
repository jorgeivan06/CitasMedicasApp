

namespace CitasMedicasApp.Paginas;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();

        

    }
    private async void OnReservarCitasClicked(object sender, EventArgs e)

    {
        await Navigation.PushAsync(new ThirdPage());

    }
    private async void OnCerrarSesionClicked(object sender, EventArgs e)
    {

        await Navigation.PopToRootAsync();
    }
}