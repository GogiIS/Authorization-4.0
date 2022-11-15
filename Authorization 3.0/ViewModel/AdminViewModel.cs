using Authorization_3._0.Command;
using Authorization_3._0.View.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Authorization_3._0.ViewModel
{
    internal class AdminViewModel:BaseViewModel
    {
        private Page _selectedPage;

        public Page SelectedPage { get => _selectedPage; set => SetProperty(ref _selectedPage, value); }
        public ICommand OpenUsersPageCommand { get; private set; }

        public AdminViewModel()
        {
            OpenUsersPageCommand = new DelegateCommand(OpenUsersPage);
        }

        private void OpenUsersPage(object parameter)
        {
            SelectedPage = new UserPage();
        }
    }
}
