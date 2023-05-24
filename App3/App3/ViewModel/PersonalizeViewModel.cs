using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using App3.Models;
using SQLite;

namespace App3.ViewModels
{
    public class PersonalizeViewModel : INotifyPropertyChanged
    {
        private User _user;
        private SQLiteAsyncConnection _connection;

        public PersonalizeViewModel()
        {
            _user = App.LoggedInUser;
            Username = _user.username;
            Email = _user.email;
            Password = _user.password;
            Shopping = _user.Shopping;
            Milk = _user.Milk;
            Loathes = _user.Loathes;
            Meat = _user.Meat;
            Fish = _user.Fish;
            Eggs = _user.Eggs;
            Vegetables = _user.Vegetables;
            Fruit = _user.Fruit;
        }

        public string Username
        {
            get { return _user.username; }
            set
            {
                if (_user.username != value)
                {
                    _user.username = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Email
        {
            get { return _user.email; }
            set
            {
                _user.email = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get { return _user.password; }
            set
            {
                if (_user.password != value)
                {
                    _user.password = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Shopping
        {
            get { return _user.Shopping; }
            set
            {
                if (_user.Shopping != value)
                {
                    _user.Shopping = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Milk
        {
            get { return _user.Milk; }
            set
            {
                if (_user.Milk != value)
                {
                    _user.Milk = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Loathes
        {
            get { return _user.Loathes; }
            set
            {
                if (_user.Loathes != value)
                {
                    _user.Loathes = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Meat
        {
            get { return _user.Meat; }
            set
            {
                if (_user.Meat != value)
                {
                    _user.Meat = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Fish
        {
            get { return _user.Fish; }
            set
            {
                if (_user.Fish != value)
                {
                    _user.Fish = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Eggs
        {
            get { return _user.Eggs; }
            set
            {
                if (_user.Eggs != value)
                {
                    _user.Eggs = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Vegetables
        {
            get { return _user.Vegetables; }
            set
            {
                if (_user.Vegetables != value)
                {
                    _user.Vegetables = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Fruit
        {
            get { return _user.Fruit; }
            set
            {
                if (_user.Fruit != value)
                {
                    _user.Fruit = value;
                    OnPropertyChanged();
                }
            }
        }

        public async Task UpdateUserShoppingAsync(string fish)
        {
            _user.Fish = fish;
            await _connection.UpdateAsync(_user);
            OnPropertyChanged(nameof(Fish));
        }

        // Add properties for the rest of the user data here

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
