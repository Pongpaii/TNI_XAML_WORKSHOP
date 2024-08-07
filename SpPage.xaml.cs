using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace tni2213211861
{	
	public partial class SpPage : ContentPage
	{	
		public SpPage ()
		{
			InitializeComponent ();
            plus.Clicked += Plus_Clicked;
            minus.Clicked += Minus_Clicked;
            multiply.Clicked += Multiply_Clicked;
            divide.Clicked += Divide_Clicked;
		}

        private void Divide_Clicked(object sender, EventArgs e)
        {
            float a = float.Parse(num1et.Text);
            float b = float.Parse(num2et.Text);
            float c = a / b;
            totallb.Text = a + " / " + b + " = " + string.Format("{0:f2}",c);
        }

        private void Multiply_Clicked(object sender, EventArgs e)
        {
            float a = float.Parse(num1et.Text);
            float b = float.Parse(num2et.Text);
            totallb.Text = a + " x " + b + " = " + (a * b);
        }

        private void Minus_Clicked(object sender, EventArgs e)
        {
            float a = float.Parse(num1et.Text);
            float b = float.Parse(num2et.Text);
            totallb.Text = a + " - " + b + " = " + (a - b);
        }

        private void Plus_Clicked(object sender, EventArgs e)
        {
            float a = float.Parse(num1et.Text);
            float b = float.Parse(num2et.Text);
            totallb.Text = a +" + "+ b +" = "+(a+b) ;
        }
    }
}

