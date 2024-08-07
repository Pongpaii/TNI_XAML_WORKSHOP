using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace tni2213211861
{	
	public partial class Homepage : ContentPage
	{	
		public Homepage ()
		{
			InitializeComponent ();
            sendBtn.Clicked += SendBtn_Clicked;
            Ageslider.ValueChanged += Ageslider_ValueChanged;
            Carstepper.ValueChanged += Carstepper_ValueChanged;
            Opensw.Toggled += Opensw_Toggled;
            Picker.SelectedIndexChanged += Picker_SelectedIndexChanged;

		}

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            showLabel.Text = Picker.SelectedItem.ToString();

        }

        private void Opensw_Toggled(object sender, ToggledEventArgs e)
        {
            showLabel.Text = e.Value.ToString();
        }

        private void Carstepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            showLabel.Text = e.NewValue.ToString("N0");
        }

        private void Ageslider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            showLabel.Text = e.NewValue.ToString ("N0") ;
        }

        private void SendBtn_Clicked(object sender, EventArgs e)
        {
            showLabel.Text = "Hello!    "+unameEntry.Text+  " "+Surname.Text +"\n Your age is  "+ Ageslider.Value + "\n YOUR FAV COLOR IS "+Picker.SelectedItem ;
        }
    }
}

