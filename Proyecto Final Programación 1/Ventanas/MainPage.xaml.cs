using Proyecto_Final_Programación_1.Ventanas;

namespace Proyecto_Final_Programación_1;


public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }
    //Esto hace que sea visible la ventana de inicio 

    private void AbrirNuevaVentana(object sender, EventArgs e)
    {
        // Cerrar la ventana actual
        Application.Current.MainPage.Navigation.PopAsync();

        // Abrir una nueva ventana
        Application.Current.MainPage.Navigation.PushAsync(new CarList());
    }
    //Abre la ventana de la lista de carros

    private void BotonSalida(object sender, EventArgs e)
    {
        // Cerrar la aplicación
        System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
    }
    private void BotonConocenos(object sender, EventArgs e)
    {
        // Cerrar la ventana actual
        Application.Current.MainPage.Navigation.PopAsync();

        // Abrir una nueva ventana
        Application.Current.MainPage.Navigation.PushAsync(new Conocenos());
    }
}


