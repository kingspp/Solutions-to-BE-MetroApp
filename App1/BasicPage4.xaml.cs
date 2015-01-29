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

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace App1
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class BasicPage4 : App1.Common.LayoutAwarePage
    {
        public BasicPage4()
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

        private void se(object sender, TappedRoutedEventArgs e)
        {
            string key = srchbx.Text;
            if (key == "alpha" || key == "Alpha")
                this.Frame.Navigate(typeof(alpha1));
            if (key == "base terminal" || key == "Base Terminal")
                this.Frame.Navigate(typeof(baseter));
            if (key == "beta" || key == "Beta")
                this.Frame.Navigate(typeof(beta));
            if (key == "capacitor" || key == "Capacitor")
                this.Frame.Navigate(typeof(capacitor));
            if (key == "collector terminal" || key == "Collector Terminal")
                this.Frame.Navigate(typeof(collector_terminal));
            if (key == "common base " || key == "Common Base ")
                this.Frame.Navigate(typeof(commonbase));
            if (key == "common emitter" || key == "Common Emitter")
                this.Frame.Navigate(typeof(commonemitter));
            if (key == "common collector" || key == "Common Collector")
                this.Frame.Navigate(typeof(commoncollecotr));
            if (key == "dc load line" || key == "Dc Load Line")
                this.Frame.Navigate(typeof(dcloadline));
            if (key == "common emitter" || key == "Common Emitter")
                this.Frame.Navigate(typeof(commonemitter));
            if (key == "diffusion capacitance" || key == "Diffusion Capacitance")
                this.Frame.Navigate(typeof(diffusioncapacitance));
            if (key == "diode" || key == ("Diode"))
                this.Frame.Navigate(typeof(diode));
            if (key == "diode current equation" || key == "Diode Current Equation")
                this.Frame.Navigate(typeof(diodecurrent));
            if (key == "diode voltage" || key == "Diode Voltage")
                this.Frame.Navigate(typeof(diodevoltage));
            if (key == "emitter terminal" || key == "Emitter Terminal")
                this.Frame.Navigate(typeof(emittertermional));
            if (key == "filter" || key == "Filter")
                this.Frame.Navigate(typeof(filter));
            if (key == "forward bias" || key == "Forward Bias")
                this.Frame.Navigate(typeof(forwardbias));
            if (key == "input characteristics" || key == "Input Characteristics")
                this.Frame.Navigate(typeof(inputcharacterestics));
            if (key == "npn transistor" || key == "NPN Transistor")
                this.Frame.Navigate(typeof(npntransistor));
            if (key == "output characteristics" || key == "Output Characteristics")
                this.Frame.Navigate(typeof(outputcharacterestics));
            if (key == "peak inverse voltage" || key == "Peak Inverse Voltage")
                this.Frame.Navigate(typeof(peakinversevoltage));
            if (key == "pnp transistor" || key == "PNP Transistor")
                this.Frame.Navigate(typeof(pnptransistor));
            if (key == "resistor" || key == "Resistor")
                this.Frame.Navigate(typeof(resistor));
            if (key == "reverse bias" || key == "Reverse Bias")
                this.Frame.Navigate(typeof(reversebias));
            if (key == "reverse recovery time" || key == "Reverse Recovery Time")
                this.Frame.Navigate(typeof(reverserecoverytime));
            if (key == "ripple factor" || key == "Ripple Factor")
                this.Frame.Navigate(typeof(ripplefactor));
            if (key == "transistor" || key == "Transistor")
                this.Frame.Navigate(typeof(transistor));
            if (key == "transition capacitance" || key == "Transition Capacitance")
                this.Frame.Navigate(typeof(transitioncapacitance));
            if (key == "types of filters" || key == "Types of Filters")
                this.Frame.Navigate(typeof(typesoffilters));
            if (key == "zener diode" || key == "Zener Diode")
                this.Frame.Navigate(typeof(zenerdiode));


        }
    }
}
