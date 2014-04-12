using BusinessManagementSystem.HelperClasses;
using BusinessManagementSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BusinessManagementSystem
{
    public class ApplicationViewModel : ObservableObject
    {
        #region Fields

        private ICommand _changePageCommand;

        private IPageViewModel _currentPageViewModel;
        private List<IPageViewModel> _pageViewModels;
        private List<IPageViewModel> _administrationViewModels;

        #endregion

        #region Constructor

        public ApplicationViewModel()
        {
            // Add available pages
            //PageViewModels.Add(new LoginViewModel());
            PageViewModels.Add(new HomeViewModel());
            PageViewModels.Add(new UserViewModel());

            // Set starting page
            CurrentPageViewModel = PageViewModels[0];
        }

        #endregion

        #region Commands

        public ICommand ChangePageCommand
        {
            get
            {
                if (_changePageCommand == null)
                {
                    _changePageCommand = new RelayCommand(
                        p => ChangeViewModel((IPageViewModel)p),
                        p => p is IPageViewModel);
                }

                return _changePageCommand;
            }
        }

        #endregion

        #region Properties

        public List<IPageViewModel> PageViewModels
        {
            get
            {
                if (_pageViewModels == null)
                    _pageViewModels = new List<IPageViewModel>();

                return _pageViewModels;
            }
        }

        public List<IPageViewModel> AdministrationViewModels
        {
            get
            {
                if (_administrationViewModels == null)
                    _administrationViewModels = PageViewModels.Where(w => !w.Name.Equals("Home")).ToList();

                return _administrationViewModels;
            }
        }

        public IPageViewModel CurrentPageViewModel
        {
            get
            {
                return _currentPageViewModel;
            }
            set
            {
                if (_currentPageViewModel != value)
                {
                    _currentPageViewModel = value;
                    OnPropertyChanged("CurrentPageViewModel");
                }
            }
        }

        #endregion

        #region Methods

        private void ChangeViewModel(IPageViewModel viewModel)
        {
            if (!PageViewModels.Contains(viewModel))
                PageViewModels.Add(viewModel);

            CurrentPageViewModel = PageViewModels
                .FirstOrDefault(vm => vm == viewModel);
        }

        #endregion
    }
}
