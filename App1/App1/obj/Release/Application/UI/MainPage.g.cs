﻿

#pragma checksum "C:\Users\Prathyush\Documents\Visual Studio 2012\Projects\App1\App1\Application\UI\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B52B88836CBADBF0664EBF1E42CADE45"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App1
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 17 "..\..\..\Application\UI\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.tap;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 23 "..\..\..\Application\UI\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.DisplayedItemChanged;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

