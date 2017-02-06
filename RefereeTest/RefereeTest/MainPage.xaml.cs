using RefereeTest.DAL;
using RefereeTest.DAL.SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RefereeTest
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Listado listado;
        public static string DB_PATH = Path.Combine(Path.Combine(ApplicationData.Current.LocalFolder.Path, "referee.sqlite"));//DataBase Name
        public MainPage()
        {
            this.InitializeComponent();
            
            listado = new Listado();
            obtenerTrivial();
          

            
        }

        private async void obtenerTrivial()
        {
            SQLiteManejadora manejadoraSQLite = new SQLiteManejadora();
            Trivial trivial = await listado.gettrivial();
            manejadoraSQLite.CreateDatabase(DB_PATH);
            manejadoraSQLite.Insert(trivial);

        }
    }
}
