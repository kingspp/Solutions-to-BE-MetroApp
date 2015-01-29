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
    public sealed partial class def1 : App1.Common.LayoutAwarePage
    {
        public def1()
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
            this.Frame.Navigate(typeof(alpha1));
        }

        private void az(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(baseter));
        }

        private void ca(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(capacitor));
        }

        private void co(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(collector_terminal));
        }

        private void cb(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(commonbase));
        }

        private void ce(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(commonemitter));
        }

        private void cc(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(commoncollecotr));
        }

        private void dc(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(dcloadline));
        }

        private void dca(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(diffusioncapacitance));
        }

        private void di(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(diode));
        }

        private void de(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(diodecurrent));
        }

        private void dv(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(diodevoltage));

        }

        private void em(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(emittertermional ));
        }

        private void fi(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(filter));
        }

        private void fo(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(forwardbias));
        }

        private void inh(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(inputcharacterestics));
        }

        private void np(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(npntransistor));
        }

        private void oc(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(outputcharacterestics));
        }

        private void pi(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(peakinversevoltage));
        }

        private void pn(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(pnptransistor));
        }

        private void re(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(resistor));
        }

        private void rb(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(reversebias));
        }

        private void rr(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(reverserecoverytime));
        }

        private void rip(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ripplefactor));
        }

        private void tr(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(transistor));
        }

        private void tc(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(transitioncapacitance));
        }

        private void ty(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(typesoffilters));
        }

        private void ze(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(zenerdiode));
        }

        private void afg(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(beta));
        }















    }
}
