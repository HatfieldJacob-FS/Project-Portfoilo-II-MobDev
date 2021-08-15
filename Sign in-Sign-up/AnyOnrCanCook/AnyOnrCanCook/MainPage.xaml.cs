using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AnyOnrCanCook
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            createAccountButton.Clicked += CreateAccountButton_Clicked;
        }

        private void CreateAccountButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
