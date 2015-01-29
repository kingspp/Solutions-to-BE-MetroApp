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
using System.Resources;
using Windows.ApplicationModel.Resources;
using Windows.ApplicationModel.Resources.Core;




// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{

    
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
       
        private readonly DispatcherTimer _timer;

       

        //Make a place to store the last time the displayed item was set
        private DateTime _lastChange;
        public MainPage()
        {
            
            this.InitializeComponent();
            _timer = new DispatcherTimer
            {
                //Set the interval between ticks (in this case 2 seconds to see it working)
                Interval = TimeSpan.FromSeconds(7)
            };

            //Change what's displayed when the timer ticks
            _timer.Tick += ChangeImage;
            //Start the timer
            _timer.Start();

            

           

        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void ChangeImage(object sender, object o)
        {
            Random random = new Random();
            int i = random.Next(1, 7);
            //Get the number of items in the flip view
            var totalItems = flipView1.Items.Count;
            //Figure out the new item's index (the current index plus one, if the next item would be out of range, go back to zero)
            var newItemIndex = (flipView1.SelectedIndex + i) % totalItems;
            //Set the displayed item's index on the flip view
            flipView1.SelectedIndex = newItemIndex;
        }

        private void DisplayedItemChanged(object sender, SelectionChangedEventArgs e)
        {

            //Show the time deltas...
            var currentTime = DateTime.Now;

            if (_lastChange != default(DateTime))
            {
               // TimeDelta.Text = (currentTime - _lastChange).ToString();
            }

            _lastChange = currentTime;

            //Since the page is configured before the timer is, check to make sure that we've actually got a timer
            if (!ReferenceEquals(_timer, null))
            {
                _timer.Stop();
                _timer.Start();
            }
        }
        private void tap(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage2));
        }

        private void TimeDelta_Tapped_1(object sender, TappedRoutedEventArgs e)
        {

        }

       
    }
}
