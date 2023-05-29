using Proyecto_Final_Programación_1.Vehiculos;

namespace Proyecto_Final_Programación_1.Ventanas;

public partial class CarList : ContentPage
{
    public CarList()
    {
        InitializeComponent();
    }

    private void CuatroPorCuatro(object sender, EventArgs e)
    {
        // Cerrar la ventana actual
        Application.Current.MainPage.Navigation.PopAsync();

        // Abrir una nueva ventana
        Application.Current.MainPage.Navigation.PushAsync(new CuatroPorCuatro());
    }
    private void Sedán(object sender, EventArgs e)
    {
        // Cerrar la ventana actual
        Application.Current.MainPage.Navigation.PopAsync();

        // Abrir una nueva ventana
        Application.Current.MainPage.Navigation.PushAsync(new Sedán());
    }
    private void PickUp(object sender, EventArgs e)
    {
        // Cerrar la ventana actual
        Application.Current.MainPage.Navigation.PopAsync();

        // Abrir una nueva ventana
        Application.Current.MainPage.Navigation.PushAsync(new PickUp());
    }
    private void SUV(object sender, EventArgs e)
    {
        // Cerrar la ventana actual
        Application.Current.MainPage.Navigation.PopAsync();

        // Abrir una nueva ventana
        Application.Current.MainPage.Navigation.PushAsync(new SUV());
    }


}