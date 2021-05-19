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
    public sealed partial class SeleccionPersonaje : Page
    {
        Image[] players = new Image[5];
        int pos = 0;
        public SeleccionPersonaje()
        {
            this.InitializeComponent();
            players[0] = Player1;
            players[1] = Player2;
            players[2] = Player3;
            players[3] = Player4;
            players[4] = Player5;
        }

        private void GoToEscenario(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SeleccionEscenario));
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
                this.Frame.GoBack();
        }

        void findNextElement(DependencyObject candidate, FocusNavigationDirection next)
        {
            candidate = FocusManager.FindNextFocusableElement(next);
            if (candidate != null)
                (candidate as Control).Focus(FocusState.Keyboard);
        }

        void setPosition()
        {
            MainPlayer.SetValue(Canvas.LeftProperty, players[pos].GetValue(Canvas.LeftProperty));
            MainPlayer.SetValue(Canvas.TopProperty, players[pos].GetValue(Canvas.TopProperty));
        }

        private void Canvas_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            DependencyObject candidate = null; //Candidato a ser el siguiente foco 

            //Teclado
            if (e.Key == VirtualKey.Down || e.Key == VirtualKey.GamepadDPadDown) findNextElement(candidate, FocusNavigationDirection.Down);
            else if (e.Key == VirtualKey.Up || e.Key == VirtualKey.GamepadDPadUp) findNextElement(candidate, FocusNavigationDirection.Up);
            else if (e.Key == VirtualKey.Right || e.Key == VirtualKey.GamepadDPadRight) findNextElement(candidate, FocusNavigationDirection.Right);
            else if (e.Key == VirtualKey.Left || e.Key == VirtualKey.GamepadDPadLeft) findNextElement(candidate, FocusNavigationDirection.Left);
            e.Handled = true; //Activar el manejo del objeto
        }

        private void rightClick(object sender, RoutedEventArgs e)
        {
            pos--; if (pos < 0) pos = 4;
            setPosition();
        }

        private void leftClick(object sender, RoutedEventArgs e)
        {
            pos++; if (pos > 4) pos = 0;
            setPosition();
        }

    }
}
