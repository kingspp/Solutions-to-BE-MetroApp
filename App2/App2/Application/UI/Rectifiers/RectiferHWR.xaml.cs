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
    public sealed partial class RectifierHWR : App2.Common.LayoutAwarePage
    {
        int dval = 4;
        public RectifierHWR()
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

        public void run()
    {
        //Declarations
            double PI = 3.14;
            double n1, n2, rf, rl, v1, v2, w, f, vm, piv;
            double im, irms, idc, vdc, pac, pdc, n, rip, a, b;
            double p, q, r, s, t;

            //Get values
             n1 = Convert.ToDouble(TextBox1.Text);
             n2 = Convert.ToDouble(TextBox2.Text);
           rf= Convert.ToDouble(TextBox3.Text);
            rl = Convert.ToDouble(TextBox4.Text);
            w = Convert.ToDouble(TextBox5.Text);
            v1 = Convert.ToDouble(TextBox5_Copy.Text);

            //Calculation part
            v2 = (n2 / n1) * v1;//To find the value of V2 // Math.Round(((idc * idc) * rl),4)
             f = w / (2 * PI);//To find Frequency
             vm = Math.Round(v2,dval);
             im = Math.Round((vm / (rf + rl)), dval); 
            //im=(vm/2)/sqrt(1+(rf/rl));//To find Im
            irms = Math.Round((im / 2),dval);//To find Irms
            idc = Math.Round((im / PI),dval);//To find DC current
            vdc = Math.Round((vm / PI) / (1 + (rf / rl)),dval);//To find DC Voltage
            piv = Math.Round((vm), dval);
            pac = Math.Round(((irms * irms) * (rf + rl)), dval);//To find Power in ac
            pdc = Math.Round(((idc * idc) * rl), 4);//To find Power in dc
            n = Math.Round(((pdc / pac) * 100), dval);//To find Efficiency
            a = (irms / idc);//To find Ripple Factor
            b = a * a;
            rip = Math.Round((Math.Sqrt(b - 1)),dval);
            p = im * 1000;
            q = irms * 1000;
            r = idc * 1000;
            s = pac * 1000;
            t = pdc * 1000;
            f = Math.Round( (w / (2 * PI)),dval);

            //Display Output
            op1.Text = (vm+" V").ToString();
            op2.Text = (im + " A").ToString();
            op3.Text = (irms + " A").ToString();
            op4.Text = (idc + " A").ToString();
            op5.Text = (vdc + " V").ToString();
            op6.Text = (piv + " W").ToString();
            op7.Text = (pac + " W").ToString();
            op8.Text = (pdc + " W").ToString();
            op9.Text = (n + " ").ToString();
            op10.Text = (rip + " ").ToString();
            op11.Text = (f+ " Hz").ToString();
    }

        private void tap(object sender, TappedRoutedEventArgs e)
        {
            run();
        }

        private void keyy(object sender, KeyRoutedEventArgs e)
        {
            string str;
            str = e.Key.ToString();
            if (str == "Enter")
            {
                run();
            }
        }

    }
}
