﻿#pragma checksum "C:\Users\Yojhan\Documents\Universidad\Diseño Sistemas Interactivos\DSIXAMLProyect\DSIXamlProyect\DSIXamlProyect\MainMenu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3EA2C759AAE1DF6635EEB01377ECAE9A"
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
    partial class MainMenu : 
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
            case 2: // MainMenu.xaml line 12
                {
                    this.MiCanvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                    ((global::Windows.UI.Xaml.Controls.Canvas)this.MiCanvas).KeyDown += this.Canvas_KeyDown;
                }
                break;
            case 3: // MainMenu.xaml line 13
                {
                    this.Fondo = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4: // MainMenu.xaml line 22
                {
                    this.Jugar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Jugar).Click += this.GoToModoDeJuego;
                }
                break;
            case 5: // MainMenu.xaml line 26
                {
                    this.Ajustes = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Ajustes).Click += this.GoToAjustes;
                }
                break;
            case 6: // MainMenu.xaml line 29
                {
                    this.IdiomaButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 7: // MainMenu.xaml line 32
                {
                    this.Salir = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Salir).Click += this.ExitApp;
                }
                break;
            case 8: // MainMenu.xaml line 33
                {
                    this.BotonSalir = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // MainMenu.xaml line 30
                {
                    this.BotonIdioma = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // MainMenu.xaml line 27
                {
                    this.BotonAjustes = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // MainMenu.xaml line 23
                {
                    this.BotonJugar = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

