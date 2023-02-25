using BasicMvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample.Models
{
    public class LoginModel:BindableBase
    {
        private string userName;
        private string password;
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                if (userName != value)
                {
                    userName = value;
                    
                    OnPropertyChanged("UserName");
                }
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if(password != value)
                {
                    password= value;
                    OnPropertyChanged("Password");
                }
            }
        }
    }
}
