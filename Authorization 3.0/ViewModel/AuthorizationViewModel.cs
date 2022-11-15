using Authorization_3._0.Command;
using Authorization_3._0.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using Authorization_3._0.View.Windows;

namespace Authorization_3._0.ViewModel
{
    internal class AuthorizationViewModel : BaseViewModel
    {
        private string _login;
        private string _password;

        public string Login { get => _login; set => SetProperty(ref _login, value); }
        public string Password { get => _password; set => SetProperty(ref _password, value); }
        public ICommand SingInCommand { get; private set; }

        public AuthorizationViewModel()
        {
            SingInCommand = new DelegateCommand(SingIn);
        }
        private void SingIn(object parameter)
        {
            if (UserValidator.Validate(Login, Password))
            {
                new UserListWindow().Show();
                Application.Current.Windows
                    .Cast<Window>()
                    .FirstOrDefault(w => w is AuthorizationWindow)
                    .Close();
            }
            else MessageBox.Show("Invalid login or password");
        }
    }
}
