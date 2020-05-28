using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace BFFPACrossPlatform
{
    public partial class SecondScreen : ContentPage
    {
        public SecondScreen()
        {
            InitializeComponent();
        }

        async void CreateUserButton(System.Object sender, System.EventArgs e)
        {
            User user = new User(Convert.ToDouble(uweight.Text), uname.Text, ugender.SelectedItem.ToString(), Convert.ToDouble(uBakU.Text), Convert.ToDouble(uBakO.Text));

            Console.WriteLine(user.name, user.weight, user.genderFaktor);

        }
    }
}
