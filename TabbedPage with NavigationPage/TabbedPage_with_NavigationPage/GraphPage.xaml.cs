﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedPage_with_NavigationPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GraphPage : ContentPage
    {
        public GraphPage()
        {
            InitializeComponent();
        }

        /* async void OnUpcomingAppointmentsButtonClicked(object sender, EventArgs e)
         {
             await Navigation.PushAsync(new UpcomingAppointmentsPage());　ボタン？？
         }*/
    }
}
