using BusinessManagementSystem.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementSystem.ViewModels
{
    public class HomeViewModel : ObservableObject, IPageViewModel
    {
        #region Properties

        public string Name
        {
            get
            {
                return "Home";
            }
        }

        #endregion
    }
}
