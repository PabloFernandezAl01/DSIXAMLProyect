﻿#pragma checksum "C:\hlocal\DSIXAMLProyect\DSIXamlProyect\DSIXamlProyect\Ajustes.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9CEEDB8981A20395C7ACFD9E253BFB17"
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
    partial class Ajustes : 
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
            case 2: // Ajustes.xaml line 11
                {
                    global::Windows.UI.Xaml.Controls.Canvas element2 = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                    ((global::Windows.UI.Xaml.Controls.Canvas)element2).KeyDown += this.Canvas_KeyDown;
                }
                break;
            case 3: // Ajustes.xaml line 32
                {
                    this.MusicaButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.MusicaButton).Click += this.MusicaButtonClick;
                }
                break;
            case 4: // Ajustes.xaml line 35
                {
                    this.EfectosButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.EfectosButton).Click += this.EfectosButtonClick;
                }
                break;
            case 5: // Ajustes.xaml line 38
                {
                    this.TutorialesButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.TutorialesButton).Click += this.TutorialesButtonClick;
                }
                break;
            case 6: // Ajustes.xaml line 41
                {
                    this.radioButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.radioButton).Click += this.IdiomaCastellano;
                }
                break;
            case 7: // Ajustes.xaml line 46
                {
                    this.radioButton1 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.radioButton1).Click += this.IdiomaFrances;
                }
                break;
            case 8: // Ajustes.xaml line 51
                {
                    this.radioButton2 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.radioButton2).Click += this.IdiomaIngles;
                }
                break;
            case 9: // Ajustes.xaml line 56
                {
                    this.button1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.button1).Click += this.GoBack;
                }
                break;
            case 10: // Ajustes.xaml line 61
                {
                    this.button1copy = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.button1copy).Click += this.VolverAlMenu;
                }
                break;
            case 11: // Ajustes.xaml line 83
                {
                    this.emparejado = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // Ajustes.xaml line 78
                {
                    this.tutoriales = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // Ajustes.xaml line 72
                {
                    this.efectos = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14: // Ajustes.xaml line 67
                {
                    this.musica = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15: // Ajustes.xaml line 16
                {
                    this.ajustesJuego = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

