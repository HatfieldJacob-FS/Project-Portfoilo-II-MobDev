using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using API_Test_File.Models;

namespace API_Test_File
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            apiGetter.Clicked += ApiGetter_Clicked;
        }

        private void ApiGetter_Clicked(object sender, EventArgs e)
        {
            DataManager dataMan = new DataManager ("pizza");
            dataMan.GetRecipes();
        }
    }
}
