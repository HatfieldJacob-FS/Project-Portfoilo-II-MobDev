using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AnyOnrCanCook.Models;

namespace AnyOnrCanCook
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignIn : ContentPage
    {
        private DataTracker _datatrack = new DataTracker();
        private User _user = new User();
        public SignIn()
        {
            InitializeComponent();
            signInButton.Clicked += SignInButton_Clicked;
            showPassword.Toggled += ShowPassword_Toggled;
            forgotPass.Clicked += ForgotPass_Clicked;
            forgotUser.Clicked += ForgotUser_Clicked;
            createAcc.Clicked += CreateAcc_Clicked;
        }

        private void CreateAcc_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void ForgotUser_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Hint:", "Username", "Dismiss");
        }

        private void ForgotPass_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Hint:", "Password", "Dismiss");
        }

        private void ShowPassword_Toggled(object sender, ToggledEventArgs e)
        {
            if (showPassword.IsToggled == false)
            {
                passwordEntry.IsPassword = true;
                
            }
            else if (showPassword.IsToggled == true)
            {
                passwordEntry.IsPassword = false;
               
            }
        }

        private void SignInButton_Clicked(object sender, EventArgs e)
        {
           
           _user.UserName = userNameEntry.Text;
            _user.Password = passwordEntry.Text;
           var validUser = _datatrack.Validation(_user);

            if (validUser == false)
            {
                DisplayAlert("Error", "Username and or Password was Incorrect", "Dismiss");
                userNameEntry.Text = "";
                passwordEntry.Text = "";
            }
            else
            {
                DisplayAlert("Notification", "Thank you for Signing In :)", "Dismiss");
            }
           

        }
    }
}