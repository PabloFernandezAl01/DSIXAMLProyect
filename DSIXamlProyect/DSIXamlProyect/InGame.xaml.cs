using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Gaming.Input;
using Windows.System;
using Windows.UI.Input;
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

        private readonly object myLock = new object();
        private List<Gamepad> myGamePads = new List<Gamepad>();
        private Gamepad mainGamepad = null;
        private GamepadReading reading, prereading;
        private DispatcherTimer GameTimer = null;

        double xOri, yOri;
        bool clicked = false;

        public InGame()
        {
            this.InitializeComponent();
            Gamepad.GamepadAdded += (object sender, Gamepad e) =>
            {
                lock (myLock)
                {
                    if (!myGamePads.Contains(e)) myGamePads.Add(e);
                }
            };

            Gamepad.GamepadRemoved += (object sender, Gamepad e) =>
            {
                lock (myLock)
                {
                    int indexRemoved = myGamePads.IndexOf(e);
                    if (indexRemoved > -1)
                    {
                        if (mainGamepad == myGamePads[indexRemoved])
                        {
                            mainGamepad = null;
                        }
                        myGamePads.RemoveAt(indexRemoved);
                    }
                }
            };
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            GameTimerSetUp();
        }

        public void GameTimerSetUp()
        {
            GameTimer = new DispatcherTimer();
            GameTimer.Tick += GameTimer_Tick; //funcion que se ejecuta cada intervalo
            GameTimer.Interval = new TimeSpan(100000); //tiempo que dura el intervalo
            GameTimer.Start();
        }
        void GameTimer_Tick(object sender, object e)
        {
            LeeMando();
            //ZMMando();
            AplMando();
        }
        private void LeeMando()
        {
            if (myGamePads.Count != 0)
            {
                mainGamepad = myGamePads[0];
                prereading = reading;
                reading = mainGamepad.GetCurrentReading();
            }
        }
        private void ZMMando()
        {
            if (reading.RightThumbstickX < -0.1) reading.RightThumbstickX += 0.1;
            else if (reading.RightThumbstickX > 0.1) reading.RightThumbstickX -= 0.1;
            else reading.RightThumbstickX = 0;

            if (reading.RightThumbstickY < -0.1) reading.RightThumbstickY += 0.1;
            else if (reading.RightThumbstickX > 0.1) reading.RightThumbstickY -= 0.1;
            else reading.RightThumbstickY = 0;
        }
        private void AplMando()
        {
            if (mainGamepad != null)
            {
                //Calculamos los valores en base a los actuales y las cosas pulsdas en el mando 
                double L = (double)jugadorAzul.GetValue(Canvas.LeftProperty);
                double T = (double)jugadorAzul.GetValue(Canvas.TopProperty);
                int MovX = (int)(10 * reading.RightThumbstickX);
                int MovY = (int)(10 * reading.RightThumbstickY);

                jugadorAzul.SetValue(Canvas.LeftProperty, L + MovX);
                jugadorAzul.SetValue(Canvas.TopProperty, T - MovY);
            }


            //No tiene que ver con el mando pero aprovecho que el timer esta ya hecho
            if (clicked)
            {
                if (Canvas.GetLeft(joystick) < xOri - 10) jugadorRojo.SetValue(Canvas.LeftProperty, Canvas.GetLeft(jugadorRojo) - 5);
                if (Canvas.GetLeft(joystick) > xOri + 10) jugadorRojo.SetValue(Canvas.LeftProperty, Canvas.GetLeft(jugadorRojo) + 5);

                if (Canvas.GetTop(joystick) < yOri - 10) jugadorRojo.SetValue(Canvas.TopProperty, Canvas.GetTop(jugadorRojo) - 5);
                if (Canvas.GetTop(joystick) > yOri + 10) jugadorRojo.SetValue(Canvas.TopProperty, Canvas.GetTop(jugadorRojo) + 5);
            }

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

            if (e.OriginalKey == VirtualKey.GamepadB || e.OriginalKey == VirtualKey.GamepadLeftThumbstickDown ||
               e.OriginalKey == VirtualKey.GamepadLeftThumbstickUp || e.OriginalKey == VirtualKey.GamepadLeftThumbstickLeft ||
               e.OriginalKey == VirtualKey.GamepadLeftThumbstickRight)
            {
                e.Handled = true;
                return;
            }

            //Teclado
            if (e.Key == VirtualKey.Up || e.Key == VirtualKey.GamepadDPadUp) findNextElement(candidate, FocusNavigationDirection.Up);
            else if (e.Key == VirtualKey.Down || e.Key == VirtualKey.GamepadDPadDown) findNextElement(candidate, FocusNavigationDirection.Down);
            else if (e.Key == VirtualKey.Right || e.Key == VirtualKey.GamepadDPadRight) findNextElement(candidate, FocusNavigationDirection.Right);
            else if (e.Key == VirtualKey.Left || e.Key == VirtualKey.GamepadDPadLeft) findNextElement(candidate, FocusNavigationDirection.Left);
            else
            {
                switch (e.Key)
                {
                    case VirtualKey.A:
                        jugadorRojo.SetValue(Canvas.LeftProperty, Canvas.GetLeft(jugadorRojo) - 10);
                        break;
                    case VirtualKey.D:
                        jugadorRojo.SetValue(Canvas.LeftProperty, Canvas.GetLeft(jugadorRojo) + 10);
                        break;
                    case VirtualKey.S:
                        jugadorRojo.SetValue(Canvas.TopProperty, Canvas.GetTop(jugadorRojo) + 10);
                        break;
                    case VirtualKey.W:
                        jugadorRojo.SetValue(Canvas.TopProperty, Canvas.GetTop(jugadorRojo) - 10);
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

        private void Image_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            clicked = true;
            xOri = Canvas.GetLeft(joystick);
            yOri = Canvas.GetTop(joystick);
        }

        private void Image_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            if (clicked)
            {
                PointerPoint point = e.GetCurrentPoint(canvasJoystick);

                if (point.Position.X > 0 && point.Position.X < canvasJoystick.Width && point.Position.Y > 0 && point.Position.Y < canvasJoystick.Height)
                {
                    joystick.SetValue(Canvas.LeftProperty, point.Position.X - 50);
                    joystick.SetValue(Canvas.TopProperty, point.Position.Y - 50);
                }
            }
        }

        private void Image_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            clicked = false;
            joystick.SetValue(Canvas.LeftProperty, xOri);
            joystick.SetValue(Canvas.TopProperty, yOri);
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
