using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
    }

    private async void btnCalcular_Clicked(object sender, EventArgs e)
    {
      try
      {
        if (validacion())
        {
          labParcial1.Text = ((Convert.ToDouble(entNota1.Text) * (0.30)) + (Convert.ToDouble(entExamen1.Text) * (0.20))).ToString("F2");
          labParcial2.Text = ((Convert.ToDouble(entNota2.Text) * (0.30)) + (Convert.ToDouble(entExamen2.Text) * (0.20))).ToString("F2");
          double notaFinal = Convert.ToDouble(labParcial1.Text)+ Convert.ToDouble(labParcial2.Text);
          labNotaFinal.Text = notaFinal.ToString("F2");
          if (notaFinal >= 7)
          {
            labEstado.Text = "APROBADO";
            labEstado.TextColor = Color.Green;
          }
          else if (notaFinal >= 5 && notaFinal <= 6.9)
          {
            labEstado.Text = "COMPLEMENTARIO";
            labEstado.TextColor = Color.Orange;
          }
          else if (notaFinal < 5)
          {
            labEstado.Text = "REPROBADO";
            labEstado.TextColor = Color.Red;
          }
        }
      }
      catch (Exception ex)
      {
        await DisplayAlert("Error", ex.Message.ToString(), "Aceptar");
      }
    }
    private bool validacion()
    {
      bool resultado = true;
      if (String.IsNullOrEmpty(entNota1.Text))
      {
        resultado = false;
        DisplayAlert("Mensaje", "Ingrese valor nota 1", "Aceptar");
      }
      else if (String.IsNullOrEmpty(entExamen1.Text))
      {
        resultado = false;
        DisplayAlert("Mensaje", "Ingrese valor examen 1", "Aceptar");
      }
      else if (String.IsNullOrEmpty(entNota2.Text))
      {
        resultado = false;
        DisplayAlert("Mensaje", "Ingrese valor nota 2", "Aceptar");
      }
      else if (String.IsNullOrEmpty(entExamen2.Text))
      {
        resultado = false;
        DisplayAlert("Mensaje", "Ingrese valor examen 2", "Aceptar");
      }
      else if (Convert.ToDouble(entNota1.Text) < 0 || Convert.ToDouble(entNota1.Text) > 10)
      {
        resultado = false;
        DisplayAlert("Mensaje", "Ingrese nota 1 valida ", "Aceptar");
      }
      else if (Convert.ToDouble(entExamen1.Text) < 0 || Convert.ToDouble(entExamen1.Text) > 10)
      {
        resultado = false;
        DisplayAlert("Mensaje", "Ingrese examen 1 valida ", "Aceptar");
      }
      else if (Convert.ToDouble(entNota2.Text) < 0 || Convert.ToDouble(entNota2.Text) > 10)
      {
        resultado = false;
        DisplayAlert("Mensaje", "Ingrese nota 2 valida ", "Aceptar");
      }
      else if (Convert.ToDouble(entExamen2.Text) < 0 || Convert.ToDouble(entExamen2.Text) > 10)
      {
        resultado = false;
        DisplayAlert("Mensaje", "Ingrese examen 2 valida ", "Aceptar");
      }
      return resultado;
    }
  }
}
