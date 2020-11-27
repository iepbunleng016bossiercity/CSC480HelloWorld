using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld1
{
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();

            slider1.Value = 0.5;
        }

        void Slider_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            label1.Text = String.Format("Value is {0:F2}",e.NewValue);
        }

    }
}
