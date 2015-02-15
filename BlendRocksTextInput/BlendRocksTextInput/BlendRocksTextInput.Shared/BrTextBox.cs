using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace BlendRocksTextInput
{
    public sealed class BrTextBox : TextBox
    {
        private const string StateCollapse = "Collapse";
        private const string StateExpand = "Expand";
        private bool hasFocus;

        public BrTextBox()
        {
            DefaultStyleKey = typeof(BrTextBox);
            GotFocus += BrTextBox_GotFocus;
            LostFocus += BrTextBox_LostFocus;
            Loaded += BrTextBox_Loaded;
            TextChanged += BrTextBox_TextChanged;
        }

        private void BrTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // In case viewmodels clear the string
            if (string.IsNullOrWhiteSpace(Text) && hasFocus == false)
            {
                VisualStateManager.GoToState(this, StateCollapse, true);
            }
        }

        private void BrTextBox_Loaded(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Text))
            {
                VisualStateManager.GoToState(this, StateCollapse, true);
            }
            else
            {
                VisualStateManager.GoToState(this, StateExpand, true);
            }
        }

        private void BrTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            hasFocus = false;

            if (string.IsNullOrWhiteSpace(Text) == true)
            {
                VisualStateManager.GoToState(this, StateCollapse, true);
            }
        }

        private void BrTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            hasFocus = true;

            if (string.IsNullOrWhiteSpace(Text) == true)
            {
                VisualStateManager.GoToState(this, StateExpand, true);
            }
        }
    }
}
