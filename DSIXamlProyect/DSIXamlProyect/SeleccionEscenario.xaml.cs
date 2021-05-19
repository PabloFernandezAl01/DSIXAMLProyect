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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DSIXamlProyect
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class SeleccionEscenario : Page
    {

        string[] imagesSrc;
        Image[] images;

        int index = 0;

        public SeleccionEscenario()
        {
            imagesSrc = new string[] { "1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg" };
            images = new Image[5];

            this.InitializeComponent();

            images[0] = Escenario1;
            images[1] = Escenario2;
            images[2] = Escenario3;
            images[3] = Escenario4;
            images[4] = Escenario5;

            CambiarIdioma();
        }

        void CambiarIdioma()
        {
            SeleccionaEscenario.Text = Idioma.getText(Idioma.Texto.seleccionEscenario);
            NombreEscenario.Text = Idioma.getText(index + Idioma.Texto.nombre1);
        }

        void StablishImages()
        {
            int j = index;
            for (int i = 0; i < 5; i++)
            {
                BitmapImage bitmapImage = new BitmapImage();
                string path = "ms-appx:///Assets/Escenarios/" + imagesSrc[i];
                Uri uri = new Uri(path);
                bitmapImage.UriSource = uri;

                images[j].Source = bitmapImage;

                j++;
                if (j == 5) j = 0;
            }
            CambiarIdioma();
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
                this.Frame.GoBack();
        }

        private void GoToIngame(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InGame), e);
        }

        private void ArrowRight(object sender, RoutedEventArgs e)
        {
            index--;
            if (index == -1) index = 4;
            StablishImages();
        }

        private void ArrowLeft(object sender, RoutedEventArgs e)
        {
            index++;
            if (index == 5) index = 0;
            StablishImages();
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
            if (e.Key == VirtualKey.Down ||e.Key == VirtualKey.Right || e.Key == VirtualKey.GamepadDPadDown) findNextElement(candidate, FocusNavigationDirection.Next);
            else if (e.Key == VirtualKey.Up ||e.Key == VirtualKey.Left ||e.Key == VirtualKey.GamepadDPadUp) findNextElement(candidate, FocusNavigationDirection.Previous);
            e.Handled = true; //Activar el manejo del objeto
        }
    }
}
