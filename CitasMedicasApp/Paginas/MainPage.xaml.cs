using CitasMedicasApp.Paginas;

namespace CitasMedicasApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnIniciarSesionClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SecondPage());
        }
    }

}
