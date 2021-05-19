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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238


namespace DSIXamlProyect
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainMenu : Page
    {
        public MainMenu()
        {
            this.InitializeComponent();

            //Idioma.actual = Idioma.Idiomas.Castellano;
            CambiarIdioma();
        }


        private void CambiarIdioma()
        {
            BotonJugar.Text = Idioma.getText(Idioma.Texto.jugar);
            BotonAjustes.Text = Idioma.getText(Idioma.Texto.opciones);
            BotonIdioma.Text = Idioma.getText(Idioma.Texto.idioma);
            BotonSalir.Text = Idioma.getText(Idioma.Texto.salir);

            switch (Idioma.actual)
            {
                case Idioma.Idiomas.Castellano:
                    Flag.Source = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "\\Assets\\spain_flag.png"));
                    break;
                case Idioma.Idiomas.Ingles:
                    Flag.Source = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "\\Assets\\bandera_inglaterra.png"));
                    break;
                case Idioma.Idiomas.Aleman:
                    Flag.Source = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "\\Assets\\bandera_alemania.jpg"));
                    break;
                case Idioma.Idiomas.Frances:
                    Flag.Source = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "\\Assets\\french_flag.jpg"));
                    break;
            }
        }

        private void GoToAjustes(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Ajustes), e);
        }

        private void ExitApp(object sender, RoutedEventArgs e)
        {
            CoreApplication.Exit();
        }

        private void GoToModoDeJuego(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ModoDeJuego), e);
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
                if (candidate == null) candidate = Jugar;
                (candidate as Control).Focus(FocusState.Keyboard);
            }
            else if (e.Key == VirtualKey.GamepadDPadUp)
            {
                candidate = FocusManager.FindNextFocusableElement(FocusNavigationDirection.Previous);
                if (candidate == null) candidate = Salir;
                (candidate as Control).Focus(FocusState.Keyboard);
            }
            e.Handled = true; //Activar el manejo del objeto
        }

        private void IdiomaButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SeleccionIdioma), e);
        }
    }
}
