﻿#pragma checksum "..\..\FightUI.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5C072C1B045E2D3F9FEA34FF48D9C5E219607C18"
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
using rpgGame;


namespace rpgGame {
    
    
    /// <summary>
    /// FightUI
    /// </summary>
    public partial class FightUI : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\FightUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FightLogTextBlock;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\FightUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FightButton;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\FightUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StatsButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\FightUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShopButton;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\FightUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateaMonsterButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\FightUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButton;
        
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
            System.Uri resourceLocater = new System.Uri("/rpgGame;component/fightui.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FightUI.xaml"
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
            this.FightLogTextBlock = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.FightButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\FightUI.xaml"
            this.FightButton.Click += new System.Windows.RoutedEventHandler(this.FightButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.StatsButton = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\FightUI.xaml"
            this.StatsButton.Click += new System.Windows.RoutedEventHandler(this.StatsButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ShopButton = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\FightUI.xaml"
            this.ShopButton.Click += new System.Windows.RoutedEventHandler(this.ShopButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CreateaMonsterButton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\FightUI.xaml"
            this.CreateaMonsterButton.Click += new System.Windows.RoutedEventHandler(this.CreateMonsterButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BackButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\FightUI.xaml"
            this.BackButton.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

