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
using Windows.ApplicationModel.Resources;
using Windows.ApplicationModel.Resources.Core;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace SolutionsToBE
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class DefinitionSearch : SolutionsToBE.Common.LayoutAwarePage
    {
        
        ResourceLoader rl = new ResourceLoader();
        public DefinitionSearch()
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

        public void se(object sender, TappedRoutedEventArgs e) 
        {
            string key = srchbx.Text;
            if (key == "alpha" || key == "Alpha")
            {
                DefinitionDisplay.bstr = rl.GetString("Alpha");
                DefinitionDisplay.bname = "Alpha";
                this.Frame.Navigate(typeof(DefinitionDisplay));

            }

            if (key == "base terminal" || key == "Base Terminal")
            {
                DefinitionDisplay.bstr = rl.GetString("Base Terminal");
                DefinitionDisplay.bname = "Base Terminal";
                this.Frame.Navigate(typeof(DefinitionDisplay));
                
            }
            if (key == "beta" || key == "Beta")
            {
                DefinitionDisplay.bstr = rl.GetString("Beta");
                DefinitionDisplay.bname = "Beta";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }
            if (key == "capacitor" || key == "Capacitor")
            {
                DefinitionDisplay.bstr = rl.GetString("Capacitor");
                DefinitionDisplay.bname = "Capacitor";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }
            if (key == "collector terminal" || key == "Collector Terminal")
            {
                DefinitionDisplay.bstr = rl.GetString("Collector Terminal");
                DefinitionDisplay.bname = "Collector Terminal";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }
            if (key == "common base" || key == "Common Base")
            {
                DefinitionDisplay.bstr = rl.GetString("Common Base Mode");
                DefinitionDisplay.bname = "Common Base Mode";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }

          
            if (key == "common collector" || key == "Common Collector")
            {
                DefinitionDisplay.bstr = rl.GetString("Common Collector Mode");
                DefinitionDisplay.bname = "Common Collector Mode";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }
            if (key == "dc load line" || key == "Dc Load Line")
            {
                DefinitionDisplay.bstr = rl.GetString("DC Load Line");
                DefinitionDisplay.bname = "DC Load Line";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }
            if (key == "common emitter" || key == "Common Emitter")
            {
                DefinitionDisplay.bstr = rl.GetString("Common Emitter Mode");
                DefinitionDisplay.bname = "Common Emitter Mode";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }
            if (key == "diffusion capacitance" || key == "Diffusion Capacitance")
            {
                DefinitionDisplay.bstr = rl.GetString("Diffusion Capacitance");
                DefinitionDisplay.bname = "Diffusion Capacitance";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }
            if (key == "diode" || key == ("Diode"))
            {
                DefinitionDisplay.bstr = rl.GetString("Diode");
                DefinitionDisplay.bname = "Diode";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }
            if (key == "diode current equation" || key == "Diode Current Equation")
            {
                DefinitionDisplay.bstr = rl.GetString("Diode Current Equation");
                DefinitionDisplay.bname = "Diode Current Equation";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }
            if (key == "diode voltage" || key == "Diode Voltage")
            {
                DefinitionDisplay.bstr = rl.GetString("Diode Voltage Equation");
                DefinitionDisplay.bname = "Diode Voltage Equation";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }
            if (key == "emitter terminal" || key == "Emitter Terminal")
            {
                DefinitionDisplay.bstr = rl.GetString("Emitter Terminal");
                DefinitionDisplay.bname = "Emitter Terminal";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }
            if (key == "filter" || key == "Filter")
            {
                DefinitionDisplay.bstr = rl.GetString("Filter");
                DefinitionDisplay.bname = "Filter";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }
            if (key == "forward bias" || key == "Forward Bias")
            {
                DefinitionDisplay.bstr = rl.GetString("Forward Bias");
                DefinitionDisplay.bname = "Forward Bias";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }
            if (key == "input characteristics" || key == "Input Characteristics")
            {
                DefinitionDisplay.bstr = rl.GetString("Input Characteristics");
                DefinitionDisplay.bname = "Input Characteristics";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }
            if (key == "npn transistor" || key == "NPN Transistor")
            {
                DefinitionDisplay.bstr = rl.GetString("NPN Transistor");
                DefinitionDisplay.bname = "NPN Transistor";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }
            if (key == "output characteristics" || key == "Output Characteristics")
            {
                DefinitionDisplay.bstr = rl.GetString("Output Characteristics");
                DefinitionDisplay.bname = "Output Characteristics";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }
            if (key == "peak inverse voltage" || key == "Peak Inverse Voltage")
            {
                DefinitionDisplay.bstr = rl.GetString("Peak Inverse Voltage");
                DefinitionDisplay.bname = "Peak Inverse Voltage";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }
            if (key == "pnp transistor" || key == "PNP Transistor")
            {
                DefinitionDisplay.bstr = rl.GetString("PNP Transistor");
                DefinitionDisplay.bname = "PNP Transistor";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }
            if (key == "rectifier" || key == "Rectifier")
            {
                DefinitionDisplay.bstr = rl.GetString("Rectifier");
                DefinitionDisplay.bname = "Rectifier";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }
            if (key == "resistor" || key == "Resistor")
            {
                DefinitionDisplay.bstr = rl.GetString("Resistor");
                DefinitionDisplay.bname = "Resistor";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }
            if (key == "reverse bias" || key == "Reverse Bias")
            {
                DefinitionDisplay.bstr = rl.GetString("Reverse Bias");
                DefinitionDisplay.bname = "Reverse Bias";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }
            if (key == "reverse recovery time" || key == "Reverse Recovery Time")
            {
                DefinitionDisplay.bstr = rl.GetString("Reverse Recovery Time");
                DefinitionDisplay.bname = "Reverse Recovery Time";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }
            if (key == "ripple factor" || key == "Ripple Factor")
            {
                DefinitionDisplay.bstr = rl.GetString("Ripple Factor");
                DefinitionDisplay.bname = "Ripple Factor";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }
            if (key == "transistor" || key == "Transistor")
            {
                DefinitionDisplay.bstr = rl.GetString("Transistor");
                DefinitionDisplay.bname = "Transistor";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }
            if (key == "transition capacitance" || key == "Transition Capacitance")
            {
                DefinitionDisplay.bstr = rl.GetString("Transition Capacitance");
                DefinitionDisplay.bname = "Transition Capacitance";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }
            if (key == "types of filters" || key == "Types of Filters")
            {
                DefinitionDisplay.bstr = rl.GetString("Types of Filters");
                DefinitionDisplay.bname = "Types of Filters";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }
            if (key == "zener diode" || key == "Zener Diode")
            {
                DefinitionDisplay.bstr = rl.GetString("Zener Diode");
                DefinitionDisplay.bname = "Zener Diode";
                this.Frame.Navigate(typeof(DefinitionDisplay));
            }


        }

        private void key(object sender, KeyRoutedEventArgs e)
        {
            
            
            string str;
            str= e.Key.ToString();
            if (str == "Enter")
            {
               



                string key = srchbx.Text;
                if (key == "alpha" || key == "Alpha")
                {
                    DefinitionDisplay.bstr = rl.GetString("Alpha");
                    DefinitionDisplay.bname = "Alpha";
                    this.Frame.Navigate(typeof(DefinitionDisplay));

                }

                if (key == "base terminal" || key == "Base Terminal")
                {
                    DefinitionDisplay.bstr = rl.GetString("Base Terminal");
                    DefinitionDisplay.bname = "Base Terminal";
                    this.Frame.Navigate(typeof(DefinitionDisplay));

                }
                if (key == "beta" || key == "Beta")
                {
                    DefinitionDisplay.bstr = rl.GetString("Beta");
                    DefinitionDisplay.bname = "Beta";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }
                if (key == "capacitor" || key == "Capacitor")
                {
                    DefinitionDisplay.bstr = rl.GetString("Capacitor");
                    DefinitionDisplay.bname = "Capacitor";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }
                if (key == "collector terminal" || key == "Collector Terminal")
                {
                    DefinitionDisplay.bstr = rl.GetString("Collector Terminal");
                    DefinitionDisplay.bname = "Collector Terminal";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }
                if (key == "common base" || key == "Common Base")
                {
                    DefinitionDisplay.bstr = rl.GetString("Common Base Mode");
                    DefinitionDisplay.bname = "Common Base Mode";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }


                if (key == "common collector" || key == "Common Collector")
                {
                    DefinitionDisplay.bstr = rl.GetString("Common Collector Mode");
                    DefinitionDisplay.bname = "Common Collector Mode";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }
                if (key == "dc load line" || key == "Dc Load Line")
                {
                    DefinitionDisplay.bstr = rl.GetString("DC Load Line");
                    DefinitionDisplay.bname = "DC Load Line";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }
                if (key == "common emitter" || key == "Common Emitter")
                {
                    DefinitionDisplay.bstr = rl.GetString("Common Emitter Mode");
                    DefinitionDisplay.bname = "Common Emitter Mode";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }
                if (key == "diffusion capacitance" || key == "Diffusion Capacitance")
                {
                    DefinitionDisplay.bstr = rl.GetString("Diffusion Capacitance");
                    DefinitionDisplay.bname = "Diffusion Capacitance";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }
                if (key == "diode" || key == ("Diode"))
                {
                    DefinitionDisplay.bstr = rl.GetString("Diode");
                    DefinitionDisplay.bname = "Diode";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }
                if (key == "diode current equation" || key == "Diode Current Equation")
                {
                    DefinitionDisplay.bstr = rl.GetString("Diode Current Equation");
                    DefinitionDisplay.bname = "Diode Current Equation";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }
                if (key == "diode voltage" || key == "Diode Voltage")
                {
                    DefinitionDisplay.bstr = rl.GetString("Diode Voltage Equation");
                    DefinitionDisplay.bname = "Diode Voltage Equation";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }
                if (key == "emitter terminal" || key == "Emitter Terminal")
                {
                    DefinitionDisplay.bstr = rl.GetString("Emitter Terminal");
                    DefinitionDisplay.bname = "Emitter Terminal";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }
                if (key == "filter" || key == "Filter")
                {
                    DefinitionDisplay.bstr = rl.GetString("Filter");
                    DefinitionDisplay.bname = "Filter";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }
                if (key == "forward bias" || key == "Forward Bias")
                {
                    DefinitionDisplay.bstr = rl.GetString("Forward Bias");
                    DefinitionDisplay.bname = "Forward Bias";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }
                if (key == "input characteristics" || key == "Input Characteristics")
                {
                    DefinitionDisplay.bstr = rl.GetString("Input Characteristics");
                    DefinitionDisplay.bname = "Input Characteristics";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }
                if (key == "npn transistor" || key == "NPN Transistor")
                {
                    DefinitionDisplay.bstr = rl.GetString("NPN Transistor");
                    DefinitionDisplay.bname = "NPN Transistor";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }
                if (key == "output characteristics" || key == "Output Characteristics")
                {
                    DefinitionDisplay.bstr = rl.GetString("Output Characteristics");
                    DefinitionDisplay.bname = "Output Characteristics";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }
                if (key == "peak inverse voltage" || key == "Peak Inverse Voltage")
                {
                    DefinitionDisplay.bstr = rl.GetString("Peak Inverse Voltage");
                    DefinitionDisplay.bname = "Peak Inverse Voltage";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }
                if (key == "pnp transistor" || key == "PNP Transistor")
                {
                    DefinitionDisplay.bstr = rl.GetString("PNP Transistor");
                    DefinitionDisplay.bname = "PNP Transistor";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }
                if (key == "rectifier" || key == "Rectifier")
                {
                    DefinitionDisplay.bstr = rl.GetString("Rectifier");
                    DefinitionDisplay.bname = "Rectifier";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }
                if (key == "resistor" || key == "Resistor")
                {
                    DefinitionDisplay.bstr = rl.GetString("Resistor");
                    DefinitionDisplay.bname = "Resistor";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }
                if (key == "reverse bias" || key == "Reverse Bias")
                {
                    DefinitionDisplay.bstr = rl.GetString("Reverse Bias");
                    DefinitionDisplay.bname = "Reverse Bias";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }
                if (key == "reverse recovery time" || key == "Reverse Recovery Time")
                {
                    DefinitionDisplay.bstr = rl.GetString("Reverse Recovery Time");
                    DefinitionDisplay.bname = "Reverse Recovery Time";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }
                if (key == "ripple factor" || key == "Ripple Factor")
                {
                    DefinitionDisplay.bstr = rl.GetString("Ripple Factor");
                    DefinitionDisplay.bname = "Ripple Factor";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }
                if (key == "transistor" || key == "Transistor")
                {
                    DefinitionDisplay.bstr = rl.GetString("Transistor");
                    DefinitionDisplay.bname = "Transistor";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }
                if (key == "transition capacitance" || key == "Transition Capacitance")
                {
                    DefinitionDisplay.bstr = rl.GetString("Transition Capacitance");
                    DefinitionDisplay.bname = "Transition Capacitance";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }
                if (key == "types of filters" || key == "Types of Filters")
                {
                    DefinitionDisplay.bstr = rl.GetString("Types of Filters");
                    DefinitionDisplay.bname = "Types of Filters";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }
                if (key == "zener diode" || key == "Zener Diode")
                {
                    DefinitionDisplay.bstr = rl.GetString("Zener Diode");
                    DefinitionDisplay.bname = "Zener Diode";
                    this.Frame.Navigate(typeof(DefinitionDisplay));
                }


            }
        }

        
        

     

        
    }
}
