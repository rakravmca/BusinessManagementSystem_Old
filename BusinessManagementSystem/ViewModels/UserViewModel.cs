using BusinessManagementSystem.Data;
using BusinessManagementSystem.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BusinessManagementSystem.ViewModels
{
    public class UserViewModel : ObservableObject, IPageViewModel
    {
        #region Fields

        private int _userId;
        private bool _isEditPopupOpen;
        private User _currentUser;
        private List<User> _userCollection;
        private ICommand _getUserCommand;
        private ICommand _saveUserCommand;
        private ICommand _editUserCommand;
        private ICommand _closeEditUserPopupCommand;
        private ICommand _addUserCommand;

        #endregion

        #region Constructor

        public UserViewModel()
        {
            UserCollection = GetUsers();
        }

        #endregion

        #region Commands

        public ICommand AddUserCommand
        {
            get
            {
                if (_addUserCommand == null)
                {
                    _addUserCommand = new RelayCommand(
                        p => AddUser());
                }
                return _addUserCommand;
            }
        }

        public ICommand EditUserCommand
        {
            get
            {
                if (_editUserCommand == null)
                {
                    _editUserCommand = new RelayCommand(
                        p => EditUser((User)p),
                        p => p is User);
                }
                return _editUserCommand;
            }
        }

        public ICommand CloseEditUserPopupCommand
        {
            get
            {
                if (_closeEditUserPopupCommand == null)
                {
                    _closeEditUserPopupCommand = new RelayCommand(
                        param => CloseEditUserPopup()
                    );
                }
                return _closeEditUserPopupCommand;
            }
        }

        #endregion

        #region Properties

        public string Name
        {
            get
            {
                return "Users";
            }
        }

        public int UserId
        {
            get { return _userId; }
            set
            {
                if (value != _userId)
                {
                    _userId = value;
                    OnPropertyChanged("UserId");
                }
            }
        }

        public User CurrentUser
        {
            get { return _currentUser; }
            set
            {
                if (value != _currentUser)
                {
                    _currentUser = value;
                    OnPropertyChanged("CurrentUser");
                }
            }
        }

        public bool IsEditPopupOpen
        {
            get { return _isEditPopupOpen; }
            set
            {
                if (value != _isEditPopupOpen)
                {
                    _isEditPopupOpen = value;
                    OnPropertyChanged("IsEditPopupOpen");
                }
            }
        }

        public List<User> UserCollection
        {
            get { return _userCollection; }
            set
            {
                if (value != _userCollection)
                {
                    _userCollection = value;
                    OnPropertyChanged("UserCollection");
                }
            }
        }

        #endregion

        #region Methods

        private List<User> GetUsers()
        {
            using (BusinessManagementSystemEntities entities = new BusinessManagementSystemEntities())
            {
                return (from user in entities.Users select user).ToList();
            }
        }

        private void SaveUser()
        {
            // You would implement your user save here
        }

        private void DeleteUser()
        {
            // You would implement your user save here
        }

        private void AddUser()
        {
            CurrentUser = new User();
            IsEditPopupOpen = true;
        }

        private void EditUser(User currentUser)
        {
            CurrentUser = currentUser;
            IsEditPopupOpen = true;
        }

        private void CloseEditUserPopup()
        {
            IsEditPopupOpen = false;
        }

        #endregion
    }
}
