﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TabbedPage_with_NavigationPage
{
    public class RMPageCS : ContentPage  //contenview→ContentPage
    {
        public RMPageCS()
        {
            Title = "1RM測定"; //表示どこかわからない
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Welcome to RMPage!",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    },

                }
            };
        }
    }
}
