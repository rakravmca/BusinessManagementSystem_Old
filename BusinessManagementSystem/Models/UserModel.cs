using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementSystem.Models
{
    public class UserModel
    {
        public UserModel()
        {
            Genders = new List<GenderModel>()
	                    {
	                        new GenderModel(){ Key = "M",Value = "Male"},
	                        new GenderModel(){ Key = "F",Value = "Female"}
	                    };

        }

        public long Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public String BirthDateString
        {
            get { return BirthDate.ToShortDateString(); }
            set
            {
                if (value != BirthDateString)
                {
                    BirthDateString = value;
                }
            }
        }

        public string EmailAddress { get; set; }

        public string Gender { get; set; }

        public string GenderName
        {
            get
            {
                return Genders.Where(w=>w.Key==Gender).SingleOrDefault().Value;
            }
            set { }
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public List<GenderModel> Genders { get; set; }
    }
}
