﻿#pragma checksum "..\..\AddNewPersonalThingType.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B5CD01D689D0D9E0F73665B3EE32631B6D501F6B68388E28E212822ECEFE16F7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CthulhuPlayerCard;
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


namespace CthulhuPlayerCard {
    
    
    /// <summary>
    /// AddNewPersonalThingType
    /// </summary>
    public partial class AddNewPersonalThingType : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\AddNewPersonalThingType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EnterTypeName;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AddNewPersonalThingType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EnterID;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AddNewPersonalThingType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddType;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\AddNewPersonalThingType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClearSpace;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AddNewPersonalThingType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteType;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\AddNewPersonalThingType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\AddNewPersonalThingType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddName_Copy1;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\AddNewPersonalThingType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid typy_przedmiotowDataGrid;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\AddNewPersonalThingType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn id_typuColumn;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\AddNewPersonalThingType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn nazwa_typuColumn;
        
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
            System.Uri resourceLocater = new System.Uri("/CthulhuPlayerCard;component/addnewpersonalthingtype.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddNewPersonalThingType.xaml"
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
            
            #line 8 "..\..\AddNewPersonalThingType.xaml"
            ((CthulhuPlayerCard.AddNewPersonalThingType)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.EnterTypeName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.EnterID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.AddType = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\AddNewPersonalThingType.xaml"
            this.AddType.Click += new System.Windows.RoutedEventHandler(this.AddTypeButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ClearSpace = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\AddNewPersonalThingType.xaml"
            this.ClearSpace.Click += new System.Windows.RoutedEventHandler(this.ClearTexboxButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DeleteType = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\AddNewPersonalThingType.xaml"
            this.DeleteType.Click += new System.Windows.RoutedEventHandler(this.DeleteTypeButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BackButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\AddNewPersonalThingType.xaml"
            this.BackButton.Click += new System.Windows.RoutedEventHandler(this.BackButtonClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.AddName_Copy1 = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.typy_przedmiotowDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 29 "..\..\AddNewPersonalThingType.xaml"
            this.typy_przedmiotowDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.typy_przedmiotowDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.id_typuColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 11:
            this.nazwa_typuColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

