﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RGB
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainRGB();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
