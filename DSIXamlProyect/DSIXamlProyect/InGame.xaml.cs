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
    public sealed partial class InGame : Page
    {
        string color = "blue";

        public InGame()
        {
            this.InitializeComponent();
        }

        private void GoToAjustes(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Ajustes), e);
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
            if (e.Key == VirtualKey.Up || e.Key == VirtualKey.Right || e.Key == VirtualKey.GamepadDPadDown) findNextElement(candidate, FocusNavigationDirection.Next);
            else if (e.Key == VirtualKey.Down || e.Key == VirtualKey.Left || e.Key == VirtualKey.GamepadDPadUp) findNextElement(candidate, FocusNavigationDirection.Previous);
            else
            {
                switch (e.Key)
                {
                    case VirtualKey.A:
                    case VirtualKey.GamepadRightThumbstickLeft:
                        jugadorAzul.SetValue(Canvas.LeftProperty, Canvas.GetLeft(jugadorAzul) - 10);
                        break;
                    case VirtualKey.D:
                    case VirtualKey.GamepadRightThumbstickRight:
                        jugadorAzul.SetValue(Canvas.LeftProperty, Canvas.GetLeft(jugadorAzul) + 10);
                        break;
                    case VirtualKey.S:
                    case VirtualKey.GamepadRightThumbstickDown:
                        jugadorAzul.SetValue(Canvas.TopProperty, Canvas.GetTop(jugadorAzul) + 10);
                        break;
                    case VirtualKey.W:
                    case VirtualKey.GamepadRightThumbstickUp:
                        jugadorAzul.SetValue(Canvas.TopProperty, Canvas.GetTop(jugadorAzul) - 10);
                        break;
                }
            }

            e.Handled = true; //Activar el manejo del objeto
        }

        private void Ability_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmapImage = new BitmapImage();
            if (habilidad.Visibility == Visibility.Collapsed)
            {
                string path = "ms-appx:///Assets/bolaAzulVacia.png";
                Uri uri = new Uri(path);
                bitmapImage.UriSource = uri;

                bolaHabilidad.Source = bitmapImage;

                habilidad.Visibility = Visibility.Visible;
            }
            else
            {
                string path = "ms-appx:///Assets/bolaAzul.jpg";
                Uri uri = new Uri(path);
                bitmapImage.UriSource = uri;

                bolaHabilidad.Source = bitmapImage;

                habilidad.Visibility = Visibility.Collapsed;
            }
        }

        private void Hit_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmapImage = new BitmapImage();

            if (color == "red")
            {
                string path = "ms-appx:///Assets/tennisballblue.png";
                Uri uri = new Uri(path);
                bitmapImage.UriSource = uri;

                jugadorRojo.Rotation = 0;

                tennis.Source = bitmapImage;

                color = "blue";
            }
            else
            {
                string path = "ms-appx:///Assets/tennisballred.png";
                Uri uri = new Uri(path);
                bitmapImage.UriSource = uri;

                jugadorRojo.Rotation = -30;

                tennis.Source = bitmapImage;

                color = "red";
            }
        }
    }
}
