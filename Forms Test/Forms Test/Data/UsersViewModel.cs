using FormsTest.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FormsTest
{
   public class UsersViewModel
    { private IUsersRepository _usersRepository;
        private IEnumerable<Users> _users;

        public IEnumerable<Users> Users
        {
            get
            {
                return _users;
            }
            set 
            {
                _users = value;
                OnPropertyChanged();
            }
        }
        public string UserName { get; set; }
        public string UserPassword { get; set; }

        public ICommand AddCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var users = new Users
                    {
                        Name = UserName,
                        Password = UserPassword,
                    };
                    await _usersRepository.AddUser(users);
                });
            }
        }

        public ICommand RefreshCommand
        {
            get
            {
                return new Command(async () =>
                {
                    Users = await _usersRepository.GetUsersAsync();
                });
            }
        }




        public UsersViewModel(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
