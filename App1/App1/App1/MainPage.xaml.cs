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

        async void MetodoIngresar(object sender, EventArgs args)
        {
            try
            {
                Console.WriteLine(" COMPROBACIÓN DE ENTRADA A EL MÉTODO INGRESAR ");

                if (entryUsuario.Text.Equals("usuarioPrueba"))
                {
                    await Navigation.PushAsync(new ClaseMenu());
                }
                else
                {
                    Console.WriteLine(" USUARIO INCORRECTO ");

                    await DisplayAlert("Avisoooo", "Se requiere de usuario correcto", "OK");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("Exepción Parametro: " + e);

            }
        }

    }
}
