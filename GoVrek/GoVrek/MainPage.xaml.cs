using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GoVrek
{

    public partial class MainPage : ContentPage
    {

        static string bomb = new Random().Next(1, 11).ToString();

        static int scores = 0;
        public MainPage()
        {
            InitializeComponent();
        }
        async void ButtonClicked(object sender, EventArgs e)
        {

            Button button = sender as Button;
            if (button.Text == bomb)
            {
                scores = 0;

                await DisplayAlert("Bomb Exploded", "Go Home Noob", "Or Try Again");
                bomb = new Random().Next(1, 12) .ToString();
            }
            else
            {
                scores += 1;

                await DisplayAlert("Bomb Defused!", "Score " + scores, "Continue");
                bomb = new Random().Next(1, 12).ToString();



                /// i add this in my self hoping it will work ////


                Button buttonz = sender as Button;
                if (button.Text == bomb)
                {
                    scores = 0;

                    await DisplayAlert("Bomb Exploded", "Go Home Noob", "Or Try Again");
                    bomb = new Random().Next(11, 22).ToString();
                }
                else
                {
                    scores += 1;

                    await DisplayAlert("Bomb Defused!", "Score " + scores, "Continue");
                    bomb = new Random().Next(11, 22).ToString();
                 

                }
            }











        }
    }
}
