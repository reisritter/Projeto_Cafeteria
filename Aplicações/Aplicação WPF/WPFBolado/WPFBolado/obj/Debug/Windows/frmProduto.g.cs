﻿#pragma checksum "..\..\..\Windows\frmProduto.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C7C2D91E99497FB5410051DF784BD533"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WPFBolado.Windows;


namespace WPFBolado.Windows {
    
    
    /// <summary>
    /// frmProduto
    /// </summary>
    public partial class frmProduto : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Windows\frmProduto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgProduto;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Windows\frmProduto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPesquisa;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Windows\frmProduto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPesquisa;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Windows\frmProduto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpd;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Windows\frmProduto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCadastra;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Windows\frmProduto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSair;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFBolado;component/windows/frmproduto.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\frmProduto.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\Windows\frmProduto.xaml"
            ((WPFBolado.Windows.frmProduto)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 9 "..\..\..\Windows\frmProduto.xaml"
            ((System.Windows.Controls.Grid)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Grid_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dtgProduto = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.txtPesquisa = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnPesquisa = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Windows\frmProduto.xaml"
            this.btnPesquisa.Click += new System.Windows.RoutedEventHandler(this.btnPesquisa_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnUpd = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Windows\frmProduto.xaml"
            this.btnUpd.Click += new System.Windows.RoutedEventHandler(this.btnUpd_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnCadastra = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Windows\frmProduto.xaml"
            this.btnCadastra.Click += new System.Windows.RoutedEventHandler(this.btnCadastra_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnSair = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Windows\frmProduto.xaml"
            this.btnSair.Click += new System.Windows.RoutedEventHandler(this.btnSair_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

