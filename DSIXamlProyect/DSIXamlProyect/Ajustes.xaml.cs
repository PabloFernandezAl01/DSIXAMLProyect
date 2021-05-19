using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

    public sealed partial class Ajustes : Page
    {
        bool one, two, three;
        public Ajustes()
        {
            this.InitializeComponent();
            one = two = three = false;
            cambiarIdioma();
        }

        void cambiarIdioma()
        {
            ajustesJuego.Text = Idioma.getText(Idioma.Texto.ajustes);
            musica.Text = Idioma.getText(Idioma.Texto.musica);
            efectos.Text = Idioma.getText(Idioma.Texto.efectos);
            tutoriales.Text = Idioma.getText(Idioma.Texto.tutoriales);
            emparejado.Text = Idioma.getText(Idioma.Texto.emparejado);
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
                this.Frame.GoBack();
        }

        private void VolverAlMenu(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainMenu));
        }

        void findNextElement(DependencyObject candidate, FocusNavigationDirection next)
        {
            candidate = FocusManager.FindNextFocusableElement(next);
            if (candidate != null)
                (candidate as Control).Focus(FocusState.Keyboard);
        }

        private void Canvas_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            DependencyObject candidate = null; //Candidato a ser el siguiente foco 

            //Teclado
            if (e.Key == VirtualKey.Down || e.Key == VirtualKey.GamepadDPadDown) findNextElement(candidate, FocusNavigationDirection.Down);
            else if (e.Key == VirtualKey.Up ||  e.Key == VirtualKey.GamepadDPadUp) findNextElement(candidate, FocusNavigationDirection.Up);
            else if (e.Key == VirtualKey.Left ||  e.Key == VirtualKey.GamepadDPadLeft) findNextElement(candidate, FocusNavigationDirection.Left);
            else if (e.Key == VirtualKey.Right || e.Key == VirtualKey.GamepadDPadRight) findNextElement(candidate, FocusNavigationDirection.Right);
            e.Handled = true;
        }

        void click(ref bool a, Button b)
        {
            a = !a;
            
            if(a) b.Background = new SolidColorBrush(Windows.UI.Colors.Green);
            else b.Background = new SolidColorBrush(Windows.UI.Colors.Red);
        }

        private void MusicaButtonClick(object sender, RoutedEventArgs e)
        {
            click(ref one, MusicaButton);
        }

        private void EfectosButtonClick(object sender, RoutedEventArgs e)
        {
            click(ref two, EfectosButton);
        }

        private void TutorialesButtonClick(object sender, RoutedEventArgs e)
        {
            click(ref three, TutorialesButton);
        }
    }
}
