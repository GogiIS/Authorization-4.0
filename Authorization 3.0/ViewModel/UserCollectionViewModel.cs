using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Authorization_3._0.model;
using Authorization_3._0.Core;

namespace Authorization_3._0.ViewModel
{
    internal class UserCollectionViewModel : BaseViewModel
    {
        private ObservableCollection<User> _users;
        public ObservableCollection<User> Users { get => _users; set => SetProperty(ref _users, value); }

        public UserCollectionViewModel()
        {
            Users = new ObservableCollection<User>(UserParser.ParseFile("users3.txt"));
        }
    }
}
