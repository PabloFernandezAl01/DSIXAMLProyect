﻿#pragma checksum "C:\Users\Yojhan\Documents\Universidad\Diseño Sistemas Interactivos\DSIXAMLProyect\DSIXamlProyect\DSIXamlProyect\ModoLocal.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A7B752F89D487073984C437BEF5A1285"
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
    partial class ModoLocal : 
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
            case 2: // ModoLocal.xaml line 13
                {
                    global::Windows.UI.Xaml.Controls.Canvas element2 = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                    ((global::Windows.UI.Xaml.Controls.Canvas)element2).KeyDown += this.Canvas_keyDown;
                }
                break;
            case 3: // ModoLocal.xaml line 21
                {
                    this.seleccionarOponente = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // ModoLocal.xaml line 31
                {
                    this.Jugadores = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 5: // ModoLocal.xaml line 82
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.GoBack;
                }
                break;
            case 6: // ModoLocal.xaml line 91
                {
                    this.Listo = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Listo).Click += this.GoToEscenario;
                }
                break;
            case 7: // ModoLocal.xaml line 109
                {
                    this.Jugador = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // ModoLocal.xaml line 35
                {
                    this.AMIGO1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.AMIGO1).Click += this.Amigo1;
                }
                break;
            case 9: // ModoLocal.xaml line 44
                {
                    this.AMIGO2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.AMIGO2).Click += this.Amigo2;
                }
                break;
            case 10: // ModoLocal.xaml line 53
                {
                    this.AMIGO3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.AMIGO3).Click += this.Amigo3;
                }
                break;
            case 11: // ModoLocal.xaml line 62
                {
                    this.AMIGO4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.AMIGO4).Click += this.Amigo4;
                }
                break;
            case 12: // ModoLocal.xaml line 71
                {
                    this.AMIGO5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.AMIGO5).Click += this.Amigo5;
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

