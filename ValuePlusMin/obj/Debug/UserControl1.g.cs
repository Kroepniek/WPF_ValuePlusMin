﻿#pragma checksum "..\..\UserControl1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "07B279DE3FE611B78747C8C96D570EF06F74765BA04C7105F7C55E40E50259F1"
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
using ValuePlusMin;


namespace ValuePlusMin {
    
    
    /// <summary>
    /// UserControl1
    /// </summary>
    public partial class UserControl1 : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\UserControl1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ValuePlusMin.UserControl1 NumericValuePlusMin;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\UserControl1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\UserControl1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse btnMin;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\UserControl1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse btnPlus;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\UserControl1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxValue;
        
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
            System.Uri resourceLocater = new System.Uri("/ValuePlusMin;component/usercontrol1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UserControl1.xaml"
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
            this.NumericValuePlusMin = ((ValuePlusMin.UserControl1)(target));
            return;
            case 2:
            this.Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.btnMin = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 17 "..\..\UserControl1.xaml"
            this.btnMin.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btnMin_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnPlus = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 29 "..\..\UserControl1.xaml"
            this.btnPlus.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btnPlus_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbxValue = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\UserControl1.xaml"
            this.tbxValue.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txbValue_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

