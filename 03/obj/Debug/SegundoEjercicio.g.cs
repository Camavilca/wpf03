﻿#pragma checksum "..\..\SegundoEjercicio.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A8338EA80F0EA19D031381984981EEFBA9403E8B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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
using _03;


namespace _03 {
    
    
    /// <summary>
    /// SegundoEjercicio
    /// </summary>
    public partial class SegundoEjercicio : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\SegundoEjercicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboAnioPedido;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\SegundoEjercicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboMesPedido;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\SegundoEjercicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboEmpleado;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\SegundoEjercicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgvClientes;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\SegundoEjercicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgvEmpleados;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\SegundoEjercicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgvDetalle;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\SegundoEjercicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgvDetall;
        
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
            System.Uri resourceLocater = new System.Uri("/03;component/segundoejercicio.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SegundoEjercicio.xaml"
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
            
            #line 16 "..\..\SegundoEjercicio.xaml"
            ((System.Windows.Controls.Grid)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Grid_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cboAnioPedido = ((System.Windows.Controls.ComboBox)(target));
            
            #line 35 "..\..\SegundoEjercicio.xaml"
            this.cboAnioPedido.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboAnioPedido_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 35 "..\..\SegundoEjercicio.xaml"
            this.cboAnioPedido.Loaded += new System.Windows.RoutedEventHandler(this.cboAnioPedido_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cboMesPedido = ((System.Windows.Controls.ComboBox)(target));
            
            #line 38 "..\..\SegundoEjercicio.xaml"
            this.cboMesPedido.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboMesPedido_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cboEmpleado = ((System.Windows.Controls.ComboBox)(target));
            
            #line 41 "..\..\SegundoEjercicio.xaml"
            this.cboEmpleado.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboEmpleado_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 43 "..\..\SegundoEjercicio.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnMostrarLista);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dgvClientes = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.dgvEmpleados = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.dgvDetalle = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.dgvDetall = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
