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
    public sealed partial class RectiferBWR : App2.Common.LayoutAwarePage
    {
        public RectiferBWR()
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

        private void we(object sender, TappedRoutedEventArgs e)
        {
            
Double n1,n2,rf,rl,v1,v2,w,f,vm,piv, PI=3.14;
Double im,irms,idc,vdc,pac,pdc,n,rip,h;
Double p,q,r,s,t;
n1 = Convert.ToDouble(TextBox1.Text);
n2 = Convert.ToDouble(TextBox2.Text);
rf = Convert.ToDouble(TextBox3.Text);
rl = Convert.ToDouble(TextBox4.Text);
w = Convert.ToDouble(TextBox5.Text);
v1 = Convert.ToDouble(TextBox5_Copy.Text);

v2=(n2/n1)*v1;//To find the value of V2
f=w/(2*PI);//To find Frequency
vm=v2;
im=vm/((2*rf)+rl);
//im=(vm/2)/sqrt(1+(rf/rl));//To find Im
irms = (im / Math.Sqrt(2));//To find Irms
idc=2*im/PI;//To find DC current
vdc=(2*vm/PI)/(1+(rf/rl));//To find DC Voltage
piv=2*vm;
pac=(irms*irms)*(rf+rl);//To find Power in ac
pdc=(idc*idc)*rl;//To find Power in dc
n=(pdc/pac)*100;//To find Efficiency
//To find Ripple Factor
h = irms / idc;
rip=Math.Sqrt((h*h)-1);
p=im*1000;
q=irms*1000;
r=idc*1000;
s=pac*1000;
t=pdc*1000;

op1.Text = vm.ToString();
op2.Text = im.ToString();
op3.Text = irms.ToString();
op4.Text = idc.ToString();
op5.Text = vdc.ToString();
op6.Text = piv.ToString();
op7.Text = pac.ToString();
op8.Text = pdc.ToString();
op9.Text = n.ToString();
op10.Text = rip.ToString();
op11.Text = f.ToString();
        }
    }
}
