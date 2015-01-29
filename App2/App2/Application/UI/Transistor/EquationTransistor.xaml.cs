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

namespace App2
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class EquationTransistor : App2.Common.LayoutAwarePage
    {
        public EquationTransistor()
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

        private void de(object sender, TappedRoutedEventArgs e)
        {
            double p, q, r, ib, ic, ie, A, B, vbb, vcc, vbe, vce, rb, rc;
            vcc = Convert.ToDouble(TextBox1.Text);
            vbb = Convert.ToDouble(TextBox2.Text);
            rb = Convert.ToDouble(TextBox3.Text);
            rc = Convert.ToDouble(TextBox4.Text);
            vbe = Convert.ToDouble(TextBox5.Text);
            vce = Convert.ToDouble(TextBox5_Copy.Text);
            ib = (vbb - vbe) / rb;//Base Current
            ic = (vcc - vce) / rc;//Collector current
            B = ic / ib;//beta
            ie = ic + ib;//Emitter Current
            A = ic / ie;//alpha
            p = ib * 1000000;
            q = ic * 1000;
            r = ie * 1000;

            op1.Text = ie.ToString();
            op2.Text = ic.ToString();
            op3.Text = ib.ToString();
            op4.Text = B.ToString();
            op5.Text = A.ToString();

        }
    }
}
