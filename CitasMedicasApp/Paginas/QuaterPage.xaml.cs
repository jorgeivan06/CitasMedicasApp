using System;
using Microsoft.Maui.Controls;
namespace CitasMedicasApp.Paginas;

public partial class QuaterPage : ContentPage
{
	public QuaterPage(string fecha, string especialidad, string medico)
	{
		InitializeComponent();

        FechaLabel.Text = $"Fecha: {fecha}";
        EspecialidadLabel.Text = $"Especialidad: {especialidad}";
        MedicoLabel.Text = $"Médico: {medico}";

    }
    private async void BtnAceptarClicked(object sender, EventArgs e)
    {

        await Navigation.PopToRootAsync();
    }
    private async void BtnCancelarClicked(object sender, EventArgs e)
    {
       
        await Navigation.PushAsync(new FifthPage());
    }



}