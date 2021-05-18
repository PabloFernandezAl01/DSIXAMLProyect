using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
        public ModoDeJuego()
        {
            this.InitializeComponent();
        }

        private void VolverAlMenu(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainMenu));
        }

        private void GoToModoLocal(object sender, RoutedEventArgs e)
        {
            if(Local.FocusState != FocusState.Unfocused || Online.FocusState != FocusState.Unfocused)
            {
                this.Frame.Navigate(typeof(ModoLocal));
            }
            else this.Frame.Navigate(typeof(SeleccionEscenario));
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
        }
    }
}
