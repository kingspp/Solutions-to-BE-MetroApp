using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.ApplicationModel.Resources;
using Windows.ApplicationModel.Resources.Core;


// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace App1
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public partial class DefinitionList : App1.Common.LayoutAwarePage
    {
        ResourceLoader rl = new ResourceLoader();
        public static string name;
        public static string str;
        public DefinitionList()
        {
          
            this.InitializeComponent();
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }

        private void aa(object sender, TappedRoutedEventArgs e)
        {

         
            DefinitionDisplay.bstr = rl.GetString("Alpha");
            DefinitionDisplay.bname = "Alpha";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void az(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("Base Terminal");
            DefinitionDisplay.bname = "Base Terminal";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void ca(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("Capacitor");
            DefinitionDisplay.bname = "Capacitor";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void co(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("Collector Terminal");
            DefinitionDisplay.bname = "Collector Terminal";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void cb(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("Common Base Mode");
            DefinitionDisplay.bname = "Common Base Mode";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void ce(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("Common Emitter Mode");
            DefinitionDisplay.bname = "Common Emitter Mode";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void cc(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("Common Collector Mode");
            DefinitionDisplay.bname = "Common Collector Mode";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void dc(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("DC Load Line");
            DefinitionDisplay.bname = "DC Load Line";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void dca(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("Diffusion Capacitance");
            DefinitionDisplay.bname = "Diffusion Capacitance";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void di(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("Diode");
            DefinitionDisplay.bname = "Diode";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void de(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("Diode Current Equation");
            DefinitionDisplay.bname = "Diode Current Equation";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void dv(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("Diode Voltage Equation");
            DefinitionDisplay.bname = "Diode Voltage Equation";
            this.Frame.Navigate(typeof(DefinitionDisplay));

        }

        private void em(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("Emitter Terminal");
            DefinitionDisplay.bname = "Emitter Terminal";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void fi(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("Filter");
            DefinitionDisplay.bname = "Filter";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void fo(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("Forward Bias");
            DefinitionDisplay.bname = "Forward Bias";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void inh(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("Input Characteristics");
            DefinitionDisplay.bname = "Input Characteristics";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void np(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("NPN Transistor");
            DefinitionDisplay.bname = "NPN Transistor";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void oc(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("Output Characteristics");
            DefinitionDisplay.bname = "Output Characteristics";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void pi(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("Peak Inverse Voltage");
            DefinitionDisplay.bname = "Peak Inverse Voltage";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void pn(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("PNP Transistor");
            DefinitionDisplay.bname = "PNP Transistor";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void re(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("Resistor");
            DefinitionDisplay.bname = "Resistor";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void rb(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("Reverse Bias");
            DefinitionDisplay.bname = "Reverse Bias";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void rr(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("Reverse Recovery Time");
            DefinitionDisplay.bname = "Reverse Recovery Time";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void rip(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("Ripple Factor");
            DefinitionDisplay.bname = "Ripple Factor";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void tr(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("Transistor");
            DefinitionDisplay.bname = "Transistor";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void tc(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("Transition Capacitance");
            DefinitionDisplay.bname = "Transition Capacitance";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void ty(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("Types of Filters");
            DefinitionDisplay.bname = "Types of Filters";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void ze(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("Zener Diode");
            DefinitionDisplay.bname = "Zener Diode";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void afg(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("Beta");
            DefinitionDisplay.bname = "Beta";
            this.Frame.Navigate(typeof(DefinitionDisplay));
        }

        private void rec(object sender, TappedRoutedEventArgs e)
        {
            DefinitionDisplay.bstr = rl.GetString("Rectifier");
            DefinitionDisplay.bname = "Rectifier";
            this.Frame.Navigate(typeof(DefinitionDisplay));


        }















    }
}
