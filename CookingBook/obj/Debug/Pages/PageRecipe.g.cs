﻿#pragma checksum "..\..\..\Pages\PageRecipe.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8FD76EFEAB779A24A217F4D8DAE534B3A13F883AE730707E63E54DB0514D48C6"
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
    /// PageRecipe
    /// </summary>
    public partial class PageRecipe : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Pages\PageRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listProducts;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Pages\PageRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboFilter;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Pages\PageRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboSort;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Pages\PageRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbCounter;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Pages\PageRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextSearch;
        
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
            System.Uri resourceLocater = new System.Uri("/CookingBook;component/pages/pagerecipe.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PageRecipe.xaml"
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
            this.listProducts = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.ComboFilter = ((System.Windows.Controls.ComboBox)(target));
            
            #line 55 "..\..\..\Pages\PageRecipe.xaml"
            this.ComboFilter.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboFilter_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ComboSort = ((System.Windows.Controls.ComboBox)(target));
            
            #line 56 "..\..\..\Pages\PageRecipe.xaml"
            this.ComboSort.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboSort_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbCounter = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.TextSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 58 "..\..\..\Pages\PageRecipe.xaml"
            this.TextSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
