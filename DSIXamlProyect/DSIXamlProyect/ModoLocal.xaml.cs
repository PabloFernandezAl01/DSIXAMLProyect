using System;
using System.Collections.Generic;
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
    public sealed partial class ModoLocal : Page
    {
        Thickness ceroThickness = new Thickness(0, 0, 0, 0);
        Thickness someThickness = new Thickness(5, 5, 5, 5);
        bool selectioned = false;
        Button[] buttons;
        public ModoLocal()
        {
            this.InitializeComponent();
            buttons = new Button[5];
            buttons[0] = AMIGO1; buttons[1] = AMIGO2;
            buttons[2] = AMIGO3; buttons[3] = AMIGO4;
            buttons[4] = AMIGO5;

            CambiarIdioma();
        }

        void CambiarIdioma()
        {
            seleccionarOponente.Text = Idioma.getText(Idioma.Texto.seleccionModoDeJuego);
            Jugador.Text = Idioma.getText(Idioma.Texto.jugador);

            for(int i = 0; i < buttons.Length; i++)
            {
                var b = buttons[i];
                b.Content = Idioma.getText(Idioma.Texto.amigo) + " " + (i + 1);
            }
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
                this.Frame.GoBack();
        }

        private void GoToEscenario(object sender, RoutedEventArgs e)
        {
            if (selectioned) this.Frame.Navigate(typeof(SeleccionEscenario));
        }

        void removeFocusAndAlphaToAll()
        {
            for (int i = 0; i < 5; i++)
            {
                buttons[i].BorderThickness = ceroThickness;
                buttons[i].Opacity = 0.7;
            }
        }

        //Botones
        private void Amigo5(object sender, RoutedEventArgs e)
        {
            removeFocusAndAlphaToAll();
            AMIGO5.BorderThickness = someThickness;
            AMIGO5.Opacity = 1;
            Listo.Opacity = 0.5;
            selectioned = false;
        }

        private void Amigo4(object sender, RoutedEventArgs e)
        {
            removeFocusAndAlphaToAll();
            AMIGO4.BorderThickness = someThickness;
            AMIGO4.Opacity = 1;
            Listo.Opacity = 0.5;
            selectioned = false;
        }

        private void Amigo3(object sender, RoutedEventArgs e)
        {
            removeFocusAndAlphaToAll();
            AMIGO3.BorderThickness = someThickness;
            AMIGO3.Opacity = 1;
            Listo.Opacity = 0.5;
            selectioned = false;
        }

        private void Amigo2(object sender, RoutedEventArgs e)
        {
            removeFocusAndAlphaToAll();
            AMIGO2.BorderThickness = someThickness;
            AMIGO2.Opacity = 1;
            Listo.Opacity = 1;
            selectioned = true;
        }

        private void Amigo1(object sender, RoutedEventArgs e)
        {
            removeFocusAndAlphaToAll();
            AMIGO1.BorderThickness = someThickness;
            AMIGO1.Opacity = 1;
            Listo.Opacity = 1;
            selectioned = true;
        }

        void findNextElement(DependencyObject candidate, FocusNavigationDirection next)
        {
            candidate = FocusManager.FindNextFocusableElement(next);
            if (candidate != null)
                (candidate as Control).Focus(FocusState.Keyboard);
        }

        private void Canvas_keyDown(object sender, KeyRoutedEventArgs e)
        {
            DependencyObject candidate = null; //Candidato a ser el siguiente foco 

            //Teclado
            if (e.Key == VirtualKey.Down || e.Key == VirtualKey.GamepadDPadDown) findNextElement(candidate, FocusNavigationDirection.Down);
            else if (e.Key == VirtualKey.Up || e.Key == VirtualKey.GamepadDPadUp) findNextElement(candidate, FocusNavigationDirection.Up);
            else if (e.Key == VirtualKey.Right || e.Key == VirtualKey.GamepadDPadRight) findNextElement(candidate, FocusNavigationDirection.Right);
            else if (e.Key == VirtualKey.Left || e.Key == VirtualKey.GamepadDPadLeft) findNextElement(candidate, FocusNavigationDirection.Left);
            e.Handled = true; //Activar el manejo del objeto
        }
    }
}
