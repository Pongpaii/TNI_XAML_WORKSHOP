using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace tni2213211861
{	
	public partial class NavPg2 : ContentPage
	{	
		public NavPg2 ()
		{
			InitializeComponent ();

            closeBbtn.Clicked += CloseBbtn_Clicked;
            btoCbtn.Clicked += BtoCbtn_Clicked;
		}

        private void BtoCbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavPg3()) ;
        }

        async private void CloseBbtn_Clicked(object sender, EventArgs e)
        {
			await Navigation.PopAsync();

        }
    }
}

