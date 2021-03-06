﻿using System;
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
    public sealed partial class EquationsMain : App2.Common.LayoutAwarePage
    {
        public EquationsMain()
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

        private void vf(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EquationFwdVolDrop));
        }

        private void rd(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EquationDyResistance));
        }

        private void pw(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EquationPower));
        }

        private void rev(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EquationRevRecTime));
        }

        private void dv(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EquationDiodeVoltage));
        }

        private void gg(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EquationDiodeCurrent));
        }

        private void tt(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EquationMaxPower));
        }

        private void rp(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EquationRipFactor));
        }

        private void cccc(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EquationCapacitance));
        }
    }
}
