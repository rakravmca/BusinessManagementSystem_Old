using BusinessManagementSystem.Data;
using BusinessManagementSystem.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace BusinessManagementSystem.ViewModels
{
    public class LoginViewModel : ObservableObject, IPageViewModel
    {
        #region Fields

        private User _currentUser;
        private string _username;
        private ICommand _loginUserCommand;

        #endregion
        

        #region Constructor

        public LoginViewModel()
        {
            Username = "ASDAS";
        }

        #endregion

        #region Properties

        public string Name
        {
            get
            {
                return "Login";
            }
        }

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                RaisePropertyChanged("Username");
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

        #endregion

        #region Commands

        public ICommand LoginUserCommand
        {
            get
            {
                if (_loginUserCommand == null)
                {
                    _loginUserCommand = new RelayCommand(
                        p => LoginUser());
                }
                return _loginUserCommand;
            }
        }

        #endregion

        #region Methods

        private bool LoginUser()
        {
            using (BusinessManagementSystemEntities entities = new BusinessManagementSystemEntities())
            {
                return (from user in entities.Users
                        where
                        (user.Username == Username &&
                        user.Password == Username
                        )
                        select user).Any();
            }
        }

        #endregion
    }
}
