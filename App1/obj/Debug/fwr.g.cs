﻿

#pragma checksum "C:\Users\Madhu\Documents\Visual Studio 2012\Projects\App1\App1\fwr.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9D7A17D6A1741CCEF4BD42A93166F7C6"
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
    partial class fwr : global::App1.Common.LayoutAwarePage, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 70 "..\..\fwr.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.er;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 36 "..\..\fwr.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.GoBack;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

