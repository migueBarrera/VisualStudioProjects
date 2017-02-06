using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _002_Contador
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //Variables
        int contador;

        public MainPage()
        {
            this.InitializeComponent();
            contador = 0 ;
        }

        private void btnMenos_Click(object sender, RoutedEventArgs e)
        {
            //RestarContador
            decrementarContador();

            //ActualizarTextBlock
            mostrarContador();
        }

        private void btnMas_Click(object sender, RoutedEventArgs e)
        {
            //IncrementarContador
            incrementarContador();

            //ActualizarTextBlock
            mostrarContador();
        }

        private void incrementarContador()
        {
            //IncrementarContador
            contador = contador + 1;
        }

        private void decrementarContador()
        {
            //Decrementar
            contador = contador - 1;
        }

        private void mostrarContador()
        {
            textContador.Text = "" + contador;
        }

    }
}
