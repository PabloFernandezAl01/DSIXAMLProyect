using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI;
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
    public sealed partial class ModoDeJuego : Page
    {
        Thickness ceroThickness = new Thickness(0, 0, 0, 0);
        Thickness someThickness = new Thickness(5, 5, 5, 5);
        bool selectioned = false;
        public ModoDeJuego()
        {
            this.InitializeComponent();
            CambiarTexto();
        }

        void CambiarTexto()
        {
            seleccionModoJuego.Text = Idioma.getText(Idioma.Texto.seleccionModoDeJuego);
            Facil.Content = Idioma.getText(Idioma.Texto.facil);
            Medio.Content = Idioma.getText(Idioma.Texto.medio);
            Dificil.Content = Idioma.getText(Idioma.Texto.dificil);
            multijugador.Text = Idioma.getText(Idioma.Texto.multijugador);
            Local.Content = Idioma.getText(Idioma.Texto.local);
            Online.Content = Idioma.getText(Idioma.Texto.online);
        }

        private void VolverAlMenu(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainMenu));
        }

        private void GoToModoLocal(object sender, RoutedEventArgs e)
        {
           if(selectioned) this.Frame.Navigate(typeof(ModoLocal));
        }

        private void FacilClick(object sender, RoutedEventArgs e)
        {
            JugadroVsIA.Opacity = 1;
            Multijugador.Opacity = 0.5;
            Facil.BorderThickness = someThickness;
            Medio.BorderThickness = ceroThickness;
            Dificil.BorderThickness = ceroThickness;

            Local.BorderThickness = ceroThickness;
            Online.BorderThickness = ceroThickness;

            Listo.Opacity = 1;

            selectioned = true;
        }

        private void MedioClick(object sender, RoutedEventArgs e)
        {
            JugadroVsIA.Opacity = 1;
            Multijugador.Opacity = 0.5;
            Facil.BorderThickness = ceroThickness;
            Medio.BorderThickness = someThickness;
            Dificil.BorderThickness = ceroThickness;

            Local.BorderThickness = ceroThickness;
            Online.BorderThickness = ceroThickness;

            Listo.Opacity = 1;

            selectioned = true;
        }

        private void DificilClick(object sender, RoutedEventArgs e)
        {
            JugadroVsIA.Opacity = 1;
            Multijugador.Opacity = 0.5;
            Facil.BorderThickness = ceroThickness;
            Medio.BorderThickness = ceroThickness;
            Dificil.BorderThickness = someThickness;

            Local.BorderThickness = ceroThickness;
            Online.BorderThickness = ceroThickness;

            Listo.Opacity = 1;

            selectioned = true;
        }

        private void LocalClick(object sender, RoutedEventArgs e)
        {
            JugadroVsIA.Opacity = 0.5;
            Multijugador.Opacity = 1;
            Local.BorderThickness = someThickness;
            Online.BorderThickness = ceroThickness;

            Facil.BorderThickness = ceroThickness;
            Medio.BorderThickness = ceroThickness;
            Dificil.BorderThickness = ceroThickness;

            Listo.Opacity = 1;

            selectioned = true;
        }

        private void OnlineClick(object sender, RoutedEventArgs e)
        {
            JugadroVsIA.Opacity = 0.5;
            Multijugador.Opacity = 1;
            Local.BorderThickness = ceroThickness;
            Online.BorderThickness = someThickness;

            Facil.BorderThickness = ceroThickness;
            Medio.BorderThickness = ceroThickness;
            Dificil.BorderThickness = ceroThickness;

            Listo.Opacity = 1;

            selectioned = true;
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
            if (e.Key == VirtualKey.Down || e.Key == VirtualKey.GamepadDPadDown) findNextElement(candidate, FocusNavigationDirection.Next);
            else if (e.Key == VirtualKey.Up || e.Key == VirtualKey.GamepadDPadUp) findNextElement(candidate, FocusNavigationDirection.Previous);
            else if (e.Key == VirtualKey.Right || e.Key == VirtualKey.GamepadDPadRight) findNextElement(candidate, FocusNavigationDirection.Right);
            else if(e.Key == VirtualKey.Left || e.Key == VirtualKey.GamepadDPadLeft) findNextElement(candidate, FocusNavigationDirection.Left);
            e.Handled = true; //Activar el manejo del objeto
        }
    }
}
