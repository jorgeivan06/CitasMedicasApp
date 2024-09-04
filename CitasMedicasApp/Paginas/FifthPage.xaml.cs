namespace CitasMedicasApp.Paginas;

public partial class FifthPage : ContentPage
{
	public FifthPage()
	{
		InitializeComponent();
	}
    private async void BtnAceptarClicked(object sender, EventArgs e)
    {

        await Navigation.PopToRootAsync();
    }

}