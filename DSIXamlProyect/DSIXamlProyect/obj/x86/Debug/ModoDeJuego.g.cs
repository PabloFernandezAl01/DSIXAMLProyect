﻿#pragma checksum "C:\Users\Yojhan\Documents\Universidad\Diseño Sistemas Interactivos\DSIXAMLProyect\DSIXamlProyect\DSIXamlProyect\ModoDeJuego.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "995F1C677E690D4B179569A6B87DABF2"
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
    partial class ModoDeJuego : 
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
            case 2: // ModoDeJuego.xaml line 14
                {
                    global::Windows.UI.Xaml.Controls.Canvas element2 = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                    ((global::Windows.UI.Xaml.Controls.Canvas)element2).KeyDown += this.Canvas_KeyDown;
                }
                break;
            case 3: // ModoDeJuego.xaml line 17
                {
                    this.Fondo = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4: // ModoDeJuego.xaml line 22
                {
                    this.volver = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.volver).Click += this.VolverAlMenu;
                }
                break;
            case 5: // ModoDeJuego.xaml line 35
                {
                    this.Listo = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Listo).Click += this.GoToModoLocal;
                }
                break;
            case 6: // ModoDeJuego.xaml line 49
                {
                    this.seleccionModoJuego = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // ModoDeJuego.xaml line 60
                {
                    this.JugadroVsIA = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 8: // ModoDeJuego.xaml line 111
                {
                    this.Multijugador = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 9: // ModoDeJuego.xaml line 123
                {
                    this.Local = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Local).Click += this.LocalClick;
                }
                break;
            case 10: // ModoDeJuego.xaml line 136
                {
                    this.Online = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Online).Click += this.OnlineClick;
                }
                break;
            case 11: // ModoDeJuego.xaml line 118
                {
                    this.multijugador = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // ModoDeJuego.xaml line 72
                {
                    this.Facil = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Facil).Click += this.FacilClick;
                }
                break;
            case 13: // ModoDeJuego.xaml line 85
                {
                    this.Medio = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Medio).Click += this.MedioClick;
                }
                break;
            case 14: // ModoDeJuego.xaml line 98
                {
                    this.Dificil = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Dificil).Click += this.DificilClick;
                }
                break;
            case 15: // ModoDeJuego.xaml line 67
                {
                    this.jugadorVsIA = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

