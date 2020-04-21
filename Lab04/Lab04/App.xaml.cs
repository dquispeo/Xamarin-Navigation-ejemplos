using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab04
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new NavigationPage(new Page1Xaml());
            //MainPage = new NavigationPage(new TabbedPage1());
            //MainPage = new NavigationPage(new CarouselPage1());
            MainPage = new NavigationPage(new Page3());
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
