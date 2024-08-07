using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tni2213211861
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            var pg1 = new NavPg1();
            var pg2 = new NavPg2();
            var np = new NavigationPage(pg1);
            var menu = new MenuPage();
            var fp = new FlyoutPage();
            fp.Flyout = new MenuPage();
            fp.Detail = new NavigationPage(new Homepage());

           
            MainPage = fp;
        }

        protected override void OnStart ()
        {

        }

        protected override void OnSleep ()
        {

        }

        protected override void OnResume ()
        {

        }
    }
}

