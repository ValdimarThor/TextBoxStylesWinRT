using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace BlendRocksTextInput.Navigation
{
    public sealed partial class NavigationControl : UserControl
    {
        public NavigationControl()
        {
            this.InitializeComponent();
        }

        private void NavigateToFlipButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var frame = Window.Current.Content as Frame;
            frame.Navigate(typeof(FlipPage));
        }

        private void NavigateToIconicButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var frame = Window.Current.Content as Frame;
            frame.Navigate(typeof(IconicPage));
        }

        private void NavigateToSlideButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var frame = Window.Current.Content as Frame;
            frame.Navigate(typeof(MainPage));
        }

        private void NavigateToSplitButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var frame = Window.Current.Content as Frame;
            frame.Navigate(typeof(SplitPage));
        }
    }
}
