using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AnyOnrCanCook.Models;

namespace AnyOnrCanCook
{
    public partial class MainPage : ContentPage
    {
        private DataTracker _data = new DataTracker();
        private User _getUser = new User();
        public MainPage()
        {

            InitializeComponent();
            createAccountButton.Clicked += CreateAccountButton_Validation;
            createAccountButton.Clicked += CreateAccountButton_Clicked;
            showPassword.Toggled += ShowPassword_Toggled;
            signInButton.Clicked += SignInButton_Clicked;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            //first
            nameEntryFirst.Text = "";

            //last
            nameEntryLast.Text = "";
            //user
            userNameEntry.Text = "";

            //email
            emailEntry.Text = "";
            //password
            passwordEntry.Text = "";
            //repassword
            passwordReEnterEntry.Text = "";
           

        }

        private void CreateAccountButton_Validation(object sender, EventArgs e)
        {
            if (passwordReEnterEntry.Text != passwordEntry.Text)
            {
                DisplayAlert("Error", "Passwords do not match", "Dismiss");
                passwordEntry.Text = "";
                passwordReEnterEntry.Text = "";
            }
            if (emailEntry.Text.Contains("@"))
            {

            }
            else
            {
                DisplayAlert("Error", "Please enter a valid Email", "Dismiss");
            }
            if (nameEntryFirst.Text == "")
            {
                DisplayAlert("Error", "Please fill all fields(First Name)", "Dismiss");
            }
            else if (nameEntryLast.Text == "")
            {
                DisplayAlert("Error", "Please fill all fields(Last Name)", "Dismiss");
            }
            else if (userNameEntry.Text == "")
            {
                DisplayAlert("Error", "Please fill all fields(UserName)", "Dismiss");
            }
            else if (emailEntry.Text == "")
            {
                DisplayAlert("Error", "Please fill all fields(Email)", "Dismiss");
            }
            else if (passwordEntry.Text == "")
            {
                DisplayAlert("Error", "Please fill all fields(Password)", "Dismiss");
            }
            
            var emailVal = _data.UserCheck(emailEntry.Text);
            if(emailVal == true)
            {
                DisplayAlert("Error", "Email is already linked to an Account", "Dismiss");
            }
        }

        private void ShowPassword_Toggled(object sender, ToggledEventArgs e)
        {
            if(showPassword.IsToggled == false)
            {
                passwordEntry.IsPassword = true;
                passwordReEnterEntry.IsPassword = true;
            }
            else if(showPassword.IsToggled == true)
            {
                passwordEntry.IsPassword = false;
                passwordReEnterEntry.IsPassword = false;
            }
        }

        async void SignInButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignIn());
        }

        

        private void CreateAccountButton_Clicked(object sender, EventArgs e)
        {

            //_getUser.Name = nameEntryFirst.Text;
            //_getUser.LastName = nameEntryLast.Text;
            //_getUser.UserName = userNameEntry.Text;
            //_getUser.Email = emailEntry.Text;
            //_getUser.Password = passwordEntry.Text;
           
            //_data.UserSave(_getUser);

            var signinAccepted = _data.Validation(_getUser);
            _getUser.Password = passwordEntry.Text;
            _getUser.UserName = userNameEntry.Text;
            _getUser.Email = emailEntry.Text;
            if (emailEntry.Text.Contains("@"))
            {
                
                    DisplayAlert("Notification", "Account Created Please sign in", "Dismiss");
                    _getUser.Name = nameEntryFirst.Text;
                    _getUser.LastName = nameEntryLast.Text;
                    _getUser.UserName = userNameEntry.Text;
                    _getUser.Email = emailEntry.Text;
                    _getUser.Password = passwordEntry.Text;

                    _data.UserSave(_getUser);
                    Navigation.PushAsync(new SignIn());
                
            }

            else
            {
                DisplayAlert("Error", "Please enter a valid Email", "Dismiss");
                OnAppearing();
            }
          
            
           
        }
    }
}
