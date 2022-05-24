﻿#pragma checksum "..\..\LoadCharacterWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "39E1E54E280C376A906345295A5E1EDCFFBDC0B129242B42EE0F876966F0E5BB"
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
    /// LoadCharacterWindow
    /// </summary>
    public partial class LoadCharacterWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\LoadCharacterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid listaPostaciDataGrid;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\LoadCharacterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn id_postaciColumn;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\LoadCharacterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn imieColumn;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\LoadCharacterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn nazwiskoColumn;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\LoadCharacterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn nazwa_zawoduColumn;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\LoadCharacterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CharacterIdInput;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\LoadCharacterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoadCharacterButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\LoadCharacterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteCharacterButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\LoadCharacterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MainMenuButton;
        
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
            System.Uri resourceLocater = new System.Uri("/CthulhuPlayerCard;component/loadcharacterwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LoadCharacterWindow.xaml"
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
            
            #line 8 "..\..\LoadCharacterWindow.xaml"
            ((CthulhuPlayerCard.LoadCharacterWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.listaPostaciDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 14 "..\..\LoadCharacterWindow.xaml"
            this.listaPostaciDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listaPostaciDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.id_postaciColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 4:
            this.imieColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.nazwiskoColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 6:
            this.nazwa_zawoduColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 7:
            this.CharacterIdInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.LoadCharacterButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\LoadCharacterWindow.xaml"
            this.LoadCharacterButton.Click += new System.Windows.RoutedEventHandler(this.LoadCharacterButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DeleteCharacterButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\LoadCharacterWindow.xaml"
            this.DeleteCharacterButton.Click += new System.Windows.RoutedEventHandler(this.DeleteCharacterButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.MainMenuButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\LoadCharacterWindow.xaml"
            this.MainMenuButton.Click += new System.Windows.RoutedEventHandler(this.MainMenuButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

