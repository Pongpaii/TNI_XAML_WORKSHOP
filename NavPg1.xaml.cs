using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace tni2213211861
{	
	public partial class NavPg1 : ContentPage
	{	
		public NavPg1 ()
		{
			InitializeComponent ();

            gotobbtn.Clicked += Gotobbtn_Clicked;
            gotoCbtn.Clicked += GotoCbtn_Clicked;
            gotoGamebtn.Clicked += GotoGamebtn_Clicked;
            gotoTabbtn.Clicked += GotoTabbtn_Clicked;

        }

        private void GotoTabbtn_Clicked(object sender, EventArgs e)
        {
            //tabbedPg
            var tp = new TabbedPage();
            tp.Children.Add(new Homepage()); //first tab
            tp.Children.Add(new tabpg1()); //1 tab
            tp.Children.Add(new tabpg2()); //2 tab
            tp.Children.Add(new tabpg3()); //3 tab
            Navigation.PushAsync(tp);
        }

        private void GotoGamebtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ROCKPPSC());
        }

        private void GotoCbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavPg3());
        }

        async private void Gotobbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavPg2());
            
        }




    }
}

