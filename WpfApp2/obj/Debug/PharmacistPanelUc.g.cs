﻿#pragma checksum "..\..\PharmacistPanelUc.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "800AD90862A156198D9A4E9199287FF8"
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


namespace WpfApp2 {
    
    
    /// <summary>
    /// PharmacistPanelUc
    /// </summary>
    public partial class PharmacistPanelUc : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\PharmacistPanelUc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem fileAddMedicine;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\PharmacistPanelUc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem filelogoutPharmacist;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\PharmacistPanelUc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem helpabout;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\PharmacistPanelUc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox medtxt_update;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\PharmacistPanelUc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox medprice_update;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\PharmacistPanelUc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button medupdate_Btnu;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\PharmacistPanelUc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button meddelete_Btn;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\PharmacistPanelUc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid_AllMedicines;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\PharmacistPanelUc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbosearchpresc_pharma;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\PharmacistPanelUc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchtxt_pharma;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\PharmacistPanelUc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid_Prescriptions;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/pharmacistpaneluc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PharmacistPanelUc.xaml"
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
            
            #line 6 "..\..\PharmacistPanelUc.xaml"
            ((WpfApp2.PharmacistPanelUc)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.fileAddMedicine = ((System.Windows.Controls.MenuItem)(target));
            
            #line 20 "..\..\PharmacistPanelUc.xaml"
            this.fileAddMedicine.Click += new System.Windows.RoutedEventHandler(this.fileAddMedicine_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.filelogoutPharmacist = ((System.Windows.Controls.MenuItem)(target));
            
            #line 21 "..\..\PharmacistPanelUc.xaml"
            this.filelogoutPharmacist.Click += new System.Windows.RoutedEventHandler(this.filelogoutPharmacist_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.helpabout = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 5:
            this.medtxt_update = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.medprice_update = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.medupdate_Btnu = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\PharmacistPanelUc.xaml"
            this.medupdate_Btnu.Click += new System.Windows.RoutedEventHandler(this.medupdate_Btnu_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.meddelete_Btn = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\PharmacistPanelUc.xaml"
            this.meddelete_Btn.Click += new System.Windows.RoutedEventHandler(this.meddelete_Btn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dataGrid_AllMedicines = ((System.Windows.Controls.DataGrid)(target));
            
            #line 60 "..\..\PharmacistPanelUc.xaml"
            this.dataGrid_AllMedicines.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGrid_AllMedicines_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.cbosearchpresc_pharma = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            this.searchtxt_pharma = ((System.Windows.Controls.TextBox)(target));
            
            #line 91 "..\..\PharmacistPanelUc.xaml"
            this.searchtxt_pharma.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchtxt_pharma_TextChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.dataGrid_Prescriptions = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
