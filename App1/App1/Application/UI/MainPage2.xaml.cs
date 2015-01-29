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
    public sealed partial class MainPage2 : App1.Common.LayoutAwarePage
    {
        public MainPage2()
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

        private void tap(object sender, TappedRoutedEventArgs e)
        {

            this.Frame.Navigate(typeof(RectifiersMain));
        }

        private void df(object sender, TappedRoutedEventArgs e)
        {
            
        }

        private void aa(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(definitions));
        }

        private void gh(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EquationTransistor));
        }

        private void eq(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FormulaMain));
        }

        private void ass(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Credits));
        }

        private void fea(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Features));
        }

        private void HyperlinkButton_Click_1(object sender, RoutedEventArgs e)
        {
            //Windows.System.Launcher.LaunchDefaultProgram(new Uri("http://www.google.com"));
            Uri targetUri = new Uri(@"http://www.codetronix.in");
            webView1.Navigate(targetUri);
        }

        private void eqo(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EquationsMain));
        }

        private void syll(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Syllabus));
        }

        private void reff(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Reference));
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void S(object sender, TappedRoutedEventArgs e)
        {
            App.Current.Exit();

            
        }

        

        
       
    }
}
