using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class Login : ContentPage
  {
    public Login()
    {
      InitializeComponent();
    }



    #region EVENTOS
    private async void btnAcceder_Clicked(object sender, EventArgs e)
    {
      if (Validacion())
      {
        if (entUsuario.Text.Equals("estudiante2021") && entClave.Text.Equals("uisrael2021"))
        {
          await Navigation.PushModalAsync(new MainPage());
        }
        else
        {
          await DisplayAlert("Error", "Los datos son incorrectos", "Aceptar");
        }
      }
    }
    #endregion

    #region METODOS
    private bool Validacion()
    {
      bool resultado = true;
      if (String.IsNullOrEmpty(entUsuario.Text))
      {
        resultado = false;
        DisplayAlert("Mensaje", "Ingrese el usuario", "Aceptar");
      }
      else if (String.IsNullOrEmpty(entClave.Text))
      {
        resultado = false;
        DisplayAlert("Mensaje", "Ingrese la clave", "Aceptar");
      }
      return resultado;
    }
    #endregion
  }
}