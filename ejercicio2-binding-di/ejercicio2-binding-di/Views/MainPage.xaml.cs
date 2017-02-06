using ejercicio2_binding_di.ViewModels;
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

namespace ejercicio2_binding_di
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public clsMainPageVM miViewModel { get; }
        public MainPage()
        {
            this.InitializeComponent();
            this.miViewModel = (clsMainPageVM)this.DataContext;
        }
        private void guardar_Click(object sender, RoutedEventArgs e)
        {
            this.txtNombre.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            this.txtApellidos.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            this.txtApellidos.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            this.txtFecha.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            this.txtTelefono.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            this.txtDireccion.GetBindingExpression(TextBox.TextProperty).UpdateSource();
        }

        private void ListView_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            
            ListView listView = (ListView)sender;
            //listView.SelectedItem = e.OriginalSource;
            allContactsMenuFlyout.ShowAt(listView, e.GetPosition(listView));
            var a = ((FrameworkElement)e.OriginalSource).DataContext;
        }


    }
}
