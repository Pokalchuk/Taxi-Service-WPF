﻿#pragma checksum "..\..\..\User\DetailsArrivalCar.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0C804D2324CAA5A640D237180A5929C951D81786EFD7446AC75C54DDF7E0CB83"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using TaxiServiceWPF;


namespace TaxiServiceWPF {
    
    
    /// <summary>
    /// DetailsArrivalCar
    /// </summary>
    public partial class DetailsArrivalCar : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\User\DetailsArrivalCar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonClose;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\User\DetailsArrivalCar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelCarNameChange;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\User\DetailsArrivalCar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelCarModelChange;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\User\DetailsArrivalCar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelCarNumberChange;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\User\DetailsArrivalCar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelTaxistNameChange;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\User\DetailsArrivalCar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelTime;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\User\DetailsArrivalCar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelPriceCheck;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\User\DetailsArrivalCar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageCarType;
        
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
            System.Uri resourceLocater = new System.Uri("/TaxiServiceWPF;component/user/detailsarrivalcar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\User\DetailsArrivalCar.xaml"
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
            
            #line 8 "..\..\..\User\DetailsArrivalCar.xaml"
            ((TaxiServiceWPF.DetailsArrivalCar)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buttonClose = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\User\DetailsArrivalCar.xaml"
            this.buttonClose.Click += new System.Windows.RoutedEventHandler(this.buttonClose_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.labelCarNameChange = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.labelCarModelChange = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.labelCarNumberChange = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.labelTaxistNameChange = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.labelTime = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.labelPriceCheck = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.imageCarType = ((System.Windows.Controls.Image)(target));
            return;
            case 10:
            
            #line 62 "..\..\..\User\DetailsArrivalCar.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonOkay_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

