using sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml;
using sample.Commands;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using sample;
using System.ComponentModel;
using BasicMvvm.Commands;
using BasicMvvm;
using sample.Services;

namespace sample.ViewModels
{
    public class LoginViewModel:BindableBase
    {
		private LoginModel loginModel = new LoginModel();
        
        public ICommand SubmitCommand => new DelegateCommand(SubmitCommandFunction);

        public ICommand ClearCommand => new DelegateCommand(ClearCommandFunction);

        public LoginModel LoginModel
		{
			get { return loginModel; }
			set { loginModel = value; OnPropertyChanged("LoginModel"); }
		}
        public void SubmitCommandFunction()
        {
            if (LoginModel.UserName == "admin" && LoginModel.Password == "admin")
            {
                NavigationService.CurrentInstance.NavigateTo("TableView");
            }
        }
        public void ClearCommandFunction()
        {
            LoginModel.UserName = "";
            LoginModel.Password = "";
        }
    }
}
