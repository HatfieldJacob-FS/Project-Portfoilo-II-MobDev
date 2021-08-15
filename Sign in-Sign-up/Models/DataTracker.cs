using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;


namespace AnyOnrCanCook.Models
{
    class DataTracker
    {
        private User _getUser = new User();
        private string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AnyOnrCanCook.txt");

       



        public bool UserCheck(string checks)
        {
            
            bool invalidUser = false;
            if (File.Exists(_fileName))
            {
                using (var load = new StreamReader(_fileName))
                {
                    if (File.ReadAllLines(_fileName).Contains(checks))
                    {
                        invalidUser = true;
                    }
                    else if (File.ReadAllLines(_fileName).Contains(checks))
                    {
                        invalidUser = true;
                    }
                }
            }//if statement ends
           
            return invalidUser;
        }
        public void UserSave(User userData)
        {
            using(var save = new StreamWriter(_fileName))
            {
                save.WriteLine(userData.Name);
                save.WriteLine(userData.LastName);
                save.WriteLine(userData.UserName);
                save.WriteLine(userData.Email);
                save.WriteLine(userData.Password);

            }
        }

        public bool Validation(User data)
        {
            bool verfUser = false;
            if (File.Exists(_fileName))
            {
                using (var valid = new StreamReader(_fileName))
                {
                    if (File.ReadAllLines(_fileName).Contains(data.UserName))
                    {
                        if (File.ReadAllLines(_fileName).Contains(data.Password))
                        {
                            verfUser = true;
                        }
                    }
                    

                }
            }//if statement end
            




            return verfUser;
        }
        






    }
}
