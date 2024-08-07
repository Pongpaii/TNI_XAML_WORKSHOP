using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace tni2213211861
{	
	public partial class tabpg1 : ContentPage
	{	
		public tabpg1 ()
		{
			InitializeComponent ();

            sendBtn.Clicked += SendBtn_Clicked;
		}

        private void SendBtn_Clicked(object sender, EventArgs e)
        {
            Showlabel.Text = "Hello! "+unameEntry.Text +" " +stunum.Text;
        }
    }
}

