﻿#pragma checksum "..\..\..\..\..\..\Views\Settings.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "007470913647485D9CC78672CCF38B0BE5B1E8BF"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using SteamAutoCrack.ViewModels;
using SteamAutoCrack.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace SteamAutoCrack.Views {
    
    
    /// <summary>
    /// Settings
    /// </summary>
    public partial class Settings : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\..\..\Views\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox SaveConfig;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\..\Views\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox DebugLog;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\..\Views\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox LogToFile;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\..\Views\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RestoreConfig;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\..\Views\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Download;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\..\Views\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock GoldbergVersion;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\..\Views\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ForceUpdate;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\..\Views\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateAppList;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\..\Views\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Close;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SteamAutoCrack;component/views/settings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Views\Settings.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.SaveConfig = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 2:
            this.DebugLog = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            this.LogToFile = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            this.RestoreConfig = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\..\..\Views\Settings.xaml"
            this.RestoreConfig.Click += new System.Windows.RoutedEventHandler(this.RestoreConfig_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Download = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\..\..\Views\Settings.xaml"
            this.Download.Click += new System.Windows.RoutedEventHandler(this.Download_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.GoldbergVersion = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.ForceUpdate = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.UpdateAppList = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\..\..\Views\Settings.xaml"
            this.UpdateAppList.Click += new System.Windows.RoutedEventHandler(this.UpdateAppList_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Close = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\..\..\Views\Settings.xaml"
            this.Close.Click += new System.Windows.RoutedEventHandler(this.Close_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
