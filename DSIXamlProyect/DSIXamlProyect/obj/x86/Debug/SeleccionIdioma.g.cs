﻿#pragma checksum "D:\Usuarios\Ivism18\Escritorio\DSIXAMLProyect\DSIXamlProyect\DSIXamlProyect\SeleccionIdioma.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9CA02B18067A09ACEAE98320ADC2D8A9"
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
    partial class SeleccionIdioma : 
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
            case 2: // SeleccionIdioma.xaml line 14
                {
                    this.MiCanvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                    ((global::Windows.UI.Xaml.Controls.Canvas)this.MiCanvas).KeyDown += this.Canvas_KeyDown;
                }
                break;
            case 3: // SeleccionIdioma.xaml line 18
                {
                    this.Fondo = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4: // SeleccionIdioma.xaml line 35
                {
                    this.Castellano = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Castellano).Click += this.IdiomaCastellano;
                }
                break;
            case 5: // SeleccionIdioma.xaml line 50
                {
                    this.Ingles = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Ingles).Click += this.IdiomaIngles;
                }
                break;
            case 6: // SeleccionIdioma.xaml line 65
                {
                    this.Frances = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Frances).Click += this.IdiomaFrances;
                }
                break;
            case 7: // SeleccionIdioma.xaml line 80
                {
                    this.Aleman = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Aleman).Click += this.IdiomaAleman;
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

