using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DSIXamlProyect
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class SeleccionIdioma : Page
    {
        public SeleccionIdioma()
        {
            this.InitializeComponent();
        }

        private void Canvas_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            DependencyObject candidate = null; //Candidato a ser el siguiente foco 

            //Teclado
            if (e.Key == VirtualKey.Down)
            {
                candidate = FocusManager.FindNextFocusableElement(FocusNavigationDirection.Next);
                //if (candidate == null) candidate = Jugar;
                (candidate as Control).Focus(FocusState.Keyboard);
            }
            else if (e.Key == VirtualKey.Up)
            {
                candidate = FocusManager.FindNextFocusableElement(FocusNavigationDirection.Previous);
                //if (candidate == null) candidate = Salir;
                (candidate as Control).Focus(FocusState.Keyboard);
            }

            //Mando
            else if (e.Key == VirtualKey.GamepadDPadDown)
            {
                candidate = FocusManager.FindNextFocusableElement(FocusNavigationDirection.Next);
                if (candidate == null) candidate = Castellano;
                (candidate as Control).Focus(FocusState.Keyboard);
            }
            else if (e.Key == VirtualKey.GamepadDPadUp)
            {
                candidate = FocusManager.FindNextFocusableElement(FocusNavigationDirection.Previous);
                if (candidate == null) candidate = Aleman;
                (candidate as Control).Focus(FocusState.Keyboard);
            }
            e.Handled = true; //Activar el manejo del objeto
        }

        private void CambiarIdioma(Idioma.Idiomas idioma)
        {
            Idioma.actual = idioma;
            this.Frame.Navigate(typeof(MainMenu));
        }

        private void IdiomaCastellano(object sender, RoutedEventArgs e)
        {
            CambiarIdioma(Idioma.Idiomas.Castellano);
        }

        private void IdiomaIngles(object sender, RoutedEventArgs e)
        {
            CambiarIdioma(Idioma.Idiomas.Ingles);
        }
        private void IdiomaAleman(object sender, RoutedEventArgs e)
        {
            CambiarIdioma(Idioma.Idiomas.Aleman);
        }
        private void IdiomaFrances(object sender, RoutedEventArgs e)
        {
            CambiarIdioma(Idioma.Idiomas.Frances);
        }
    }
}
