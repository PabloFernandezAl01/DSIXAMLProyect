#pragma checksum "D:\Usuarios\Ivism18\Escritorio\DSIXAMLProyect\DSIXamlProyect\DSIXamlProyect\SeleccionEscenario.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7CE6160E603EE5640C76D59670C0F44F"
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
    partial class SeleccionEscenario : 
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
            case 2: // SeleccionEscenario.xaml line 20
                {
                    global::Windows.UI.Xaml.Controls.Canvas element2 = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                    ((global::Windows.UI.Xaml.Controls.Canvas)element2).KeyDown += this.Canvas_KeyDown;
                }
                break;
            case 3: // SeleccionEscenario.xaml line 21
                {
                    this.Fondo = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4: // SeleccionEscenario.xaml line 23
                {
                    this.Volver = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Volver).Click += this.GoBack;
                }
                break;
            case 5: // SeleccionEscenario.xaml line 28
                {
                    this.SeleccionaEscenario = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // SeleccionEscenario.xaml line 32
                {
                    this.Escenario1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 7: // SeleccionEscenario.xaml line 35
                {
                    this.Escenario2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 8: // SeleccionEscenario.xaml line 38
                {
                    this.Escenario5 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 9: // SeleccionEscenario.xaml line 41
                {
                    this.Escenario4 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 10: // SeleccionEscenario.xaml line 44
                {
                    this.Escenario3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 11: // SeleccionEscenario.xaml line 47
                {
                    global::Windows.UI.Xaml.Controls.Button element11 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element11).Click += this.ArrowLeft;
                }
                break;
            case 12: // SeleccionEscenario.xaml line 51
                {
                    global::Windows.UI.Xaml.Controls.Button element12 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element12).Click += this.ArrowRight;
                }
                break;
            case 13: // SeleccionEscenario.xaml line 61
                {
                    this.NombreEscenario = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14: // SeleccionEscenario.xaml line 64
                {
                    global::Windows.UI.Xaml.Controls.Button element14 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element14).Click += this.GoToIngame;
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

