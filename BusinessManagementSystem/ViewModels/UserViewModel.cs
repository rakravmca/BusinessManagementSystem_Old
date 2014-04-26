using BusinessManagementSystem.Data;
using BusinessManagementSystem.HelperClasses;
using BusinessManagementSystem.Models;
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

        private bool _isEditPopupOpen;
        private UserModel _currentUser;
        private List<UserModel> _userCollection;
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
                        p => EditUser((UserModel)p),
                        p => p is UserModel);
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

        public ICommand SavetUserCommand
        {
            get
            {
                if (_saveUserCommand == null)
                {
                    _saveUserCommand = new RelayCommand(
                        p => SaveUser());
                }
                return _saveUserCommand;
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

        public UserModel CurrentUser
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

        public List<UserModel> UserCollection
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

        private List<UserModel> GetUsers()
        {
            using (BusinessManagementSystemEntities entities = new BusinessManagementSystemEntities())
            {
                return (from user in entities.Users select new UserModel
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    MiddleName = user.MiddleName,
                    LastName = user.LastName,
                    BirthDate = user.BirthDate,
                    Gender = user.Gender,
                    Username =user.Username,
                    EmailAddress=user.EmailAddress
                }).ToList();
            }
        }

        private void SaveUser()
        {
            using (BusinessManagementSystemEntities entities = new BusinessManagementSystemEntities())
            {
                User user;

                if (CurrentUser.Id == 0)
                {
                    user = new User();
                }
                else
                {
                    user = entities.Users.SingleOrDefault(s => s.Id == CurrentUser.Id);
                }

                if (user != null)
                {
                    user.FirstName = CurrentUser.FirstName;
                    user.MiddleName = CurrentUser.MiddleName;
                    user.LastName = CurrentUser.LastName;
                    user.Gender = CurrentUser.Gender;
                    user.BirthDate = Convert.ToDateTime(CurrentUser.BirthDateString);
                    user.EmailAddress = CurrentUser.EmailAddress;
                    user.Username = CurrentUser.Username;
                    user.Password = CurrentUser.Password; 

                    if (CurrentUser.Id == 0)
                    {
                        entities.Users.Add(user);
                    }

                    entities.SaveChanges();
                }
            }
        }

        private void DeleteUser()
        {
            // You would implement your user save here
        }

        private void AddUser()
        {
            CurrentUser = new UserModel()
            {
                BirthDate=DateTime.Now
            };
            IsEditPopupOpen = true;
        }

        private void EditUser(UserModel currentUser)
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
