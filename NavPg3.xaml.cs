using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace tni2213211861
{	
	public partial class NavPg3 : ContentPage
	{	
		public NavPg3 ()
		{
			InitializeComponent();

            closeCbtn.Clicked += CloseCbtn_Clicked;
		}

        private void CloseCbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}

