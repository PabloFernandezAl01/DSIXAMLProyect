﻿#pragma checksum "C:\Users\pablo\OneDrive\Escritorio\DSI\DSIXAMLProyect\DSIXamlProyect\DSIXamlProyect\SeleccionPersonaje.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CD670AE4A0EA8419A30E4BC39114630D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DSIXamlProyect
{
    partial class SeleccionPersonaje : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // SeleccionPersonaje.xaml line 12
                {
                    global::Windows.UI.Xaml.Controls.Canvas element2 = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                    ((global::Windows.UI.Xaml.Controls.Canvas)element2).KeyDown += this.Canvas_KeyDown;
                }
                break;
            case 3: // SeleccionPersonaje.xaml line 13
                {
                    this.Fondo = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4: // SeleccionPersonaje.xaml line 14
                {
                    this.volver = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.volver).Click += this.GoBack;
                }
                break;
            case 5: // SeleccionPersonaje.xaml line 19
                {
                    this.Derecha = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Derecha).Click += this.rightClick;
                }
                break;
            case 6: // SeleccionPersonaje.xaml line 22
                {
                    this.Izquierda = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Izquierda).Click += this.leftClick;
                }
                break;
            case 7: // SeleccionPersonaje.xaml line 62
                {
                    this.Listo = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Listo).Click += this.GoToEscenario;
                }
                break;
            case 8: // SeleccionPersonaje.xaml line 65
                {
                    this.Player4 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 9: // SeleccionPersonaje.xaml line 66
                {
                    this.Player3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 10: // SeleccionPersonaje.xaml line 67
                {
                    this.Player5 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 11: // SeleccionPersonaje.xaml line 68
                {
                    this.Player2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 12: // SeleccionPersonaje.xaml line 69
                {
                    this.Player1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 13: // SeleccionPersonaje.xaml line 70
                {
                    this.MainPlayer = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

