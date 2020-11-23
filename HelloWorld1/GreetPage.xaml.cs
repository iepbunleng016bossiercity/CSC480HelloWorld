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
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Title","Alert me","OK");
        }
    }
}
