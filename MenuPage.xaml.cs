using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace tni2213211861
{	
	public partial class MenuPage : ContentPage
	{	
		public MenuPage()
		{
			InitializeComponent ();

            stackbtn.Clicked += Stackbtn_Clicked;
            homebtn.Clicked += Homebtn_Clicked;
            gridbtn.Clicked += Gridbtn_Clicked;
            pfbtn.Clicked += Pfbtn_Clicked;
            ytbtn.Clicked += Ytbtn_Clicked;
            navbtn.Clicked += Navbtn_Clicked;
            tabbtn.Clicked += Tabbtn_Clicked;
            spbtn.Clicked += Spbtn_Clicked;
		}

        private void Spbtn_Clicked(object sender, EventArgs e)
        {
            var fp = Parent as FlyoutPage;
            fp.Detail = new NavigationPage(new SpPage());
            fp.IsPresented = false;
        }

        private void Tabbtn_Clicked(object sender, EventArgs e)
        {
            //tabbedPg
            var tp = new TabbedPage();
            tp.Children.Add(new Homepage()); //first tab
            tp.Children.Add(new tabpg1()); //1 tab
            tp.Children.Add(new tabpg2()); //2 tab
            tp.Children.Add(new tabpg3()); //3 tab
             
            var fp = Parent as FlyoutPage;
            fp.Detail = new NavigationPage(tp);
            fp.IsPresented = false;
        }

        private void Navbtn_Clicked(object sender, EventArgs e)
        {
            var fp = Parent as FlyoutPage;
            fp.Detail = new NavigationPage(new NavPg1());
            fp.IsPresented = false;
        }

        private void Ytbtn_Clicked(object sender, EventArgs e)
        {
            var fp = Parent as FlyoutPage;
            fp.Detail = new NavigationPage(new YoutubePage());
            fp.IsPresented = false;
        }

        private void Pfbtn_Clicked(object sender, EventArgs e)
        {
            var fp = Parent as FlyoutPage;
            fp.Detail = new NavigationPage(new Pfpage());
            fp.IsPresented = false;
        }

        private void Gridbtn_Clicked(object sender, EventArgs e)
        {
            var fp = Parent as FlyoutPage;
            fp.Detail = new NavigationPage(new gridpage());
            fp.IsPresented = false;
        }

        private void Homebtn_Clicked(object sender, EventArgs e)
        {
            var fp = Parent as FlyoutPage;
            fp.Detail = new NavigationPage(new Homepage());
            fp.IsPresented = false;
        }

        private void Stackbtn_Clicked(object sender, EventArgs e)
        {
            var fp = Parent as FlyoutPage;
            fp.Detail = new NavigationPage(new stackedpage());
            fp.IsPresented = false;
        }
    }
}

