﻿#pragma checksum "..\..\..\Pages\Authorize.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E0CC7B3149D132191FC527A72CBA93AAED4A99B9F3E0B9CED50E37717E19E219"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CookingBook.Pages;
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


namespace CookingBook.Pages {
    
    
    /// <summary>
    /// Authorize
    /// </summary>
    public partial class Authorize : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Pages\Authorize.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextLogin;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Pages\Authorize.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox TextPassword;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Pages\Authorize.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Password;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Pages\Authorize.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Login;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Pages\Authorize.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAuth;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Pages\Authorize.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SungUpButton;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Pages\Authorize.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextOrSingUp;
        
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
            System.Uri resourceLocater = new System.Uri("/CookingBook;component/pages/authorize.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Authorize.xaml"
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
            this.TextLogin = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\..\Pages\Authorize.xaml"
            this.TextLogin.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.Password = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.Login = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.ButtonAuth = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Pages\Authorize.xaml"
            this.ButtonAuth.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SungUpButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Pages\Authorize.xaml"
            this.SungUpButton.Click += new System.Windows.RoutedEventHandler(this.SungUpButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TextOrSingUp = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

