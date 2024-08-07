using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace tni2213211861
{	
	public partial class ROCKPPSC : ContentPage
	{	
		public ROCKPPSC ()
		{
			InitializeComponent ();
		}

        private void OnRockClicked(object sender, EventArgs e)
        {
            PlayGame("หิน");
        }

        private void OnPaperClicked(object sender, EventArgs e)
        {
            PlayGame("กระดาษ");
        }

        private void OnScissorsClicked(object sender, EventArgs e)
        {
            PlayGame("กรรไกร");
        }

        private void PlayGame(string userChoice)
        {
            var choices = new[] { "หิน", "กระดาษ", "กรรไกร" };
            var random = new Random();
            var computerChoice = choices[random.Next(choices.Length)];

            string result;
            if (userChoice == computerChoice)
            {
                result = "เสมอ!";
            }
            else if ((userChoice == "หิน" && computerChoice == "กรรไกร") ||
                     (userChoice == "กระดาษ" && computerChoice == "หิน") ||
                     (userChoice == "กรรไกร" && computerChoice == "กระดาษ"))
            {
                result = "youชนะ!";
            }
            else
            {
                result = "youแพ้!";
            }

            ResultLabel.Text = $"คุณเลือก: {userChoice}\nคอมพิวเตอร์เลือก: {computerChoice}\nผลลัพธ์: {result}";
        }
    }
}
