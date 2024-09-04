namespace CitasMedicasApp.Paginas
{
    public partial class ThirdPage : ContentPage
    {

        public ThirdPage()
        {
            InitializeComponent();
        }

        private async void BtnReservarClicked(object sender, EventArgs e)
        {
            
            string Fecha = FechaPicker.Date.ToString("dd/MM/yyyy");
            string Especialidad = EspecialidadPicker.SelectedItem?.ToString() ?? "No seleccionada";
            string Medico = MedicoPicker.SelectedItem?.ToString() ?? "No seleccionado";

            if (string.IsNullOrWhiteSpace(Fecha) || Especialidad == "No seleccionada" || Medico == "No seleccionado")
            {
                await DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
                return;
            }

            await Navigation.PushAsync(new QuaterPage(Fecha, Especialidad, Medico));
        }
    }
}
