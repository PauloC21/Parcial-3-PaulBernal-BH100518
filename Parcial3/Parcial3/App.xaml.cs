﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Parcial3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CodeBehind());
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
