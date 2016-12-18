using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfLearning.Models;
using WpfLearning.Commands;

namespace WpfLearning.ViewModels
{
    public class UserViewModel : ViewModelBase
    {
        private User user;

        public decimal UserId
        {
            get { return user.UserId; }
            set
            {
                user.UserId = value;
                //NotifyPropertyChanged("UserId");
            }
        }


        public string Name
        {
            get { return user.Name; }
            set
            {
                user.Name = value;
                //NotifyPropertyChanged("Name");
            }
        }
        
        public string FirstName
        {
            get { return user.FirstName; }
            set
            {
                user.FirstName = value;
                NotifyPropertyChanged("FirstName");
                NotifyPropertyChanged("FullName");
            }
        }
        
        public string LastName
        {
            get { return user.LastName; }
            set
            {
                user.LastName = value;
                NotifyPropertyChanged("LastName");
                NotifyPropertyChanged("FullName");
            }
        }

        public string FullName
        {
            get
            {
                return $"{user.FirstName} {user.LastName}";
            }
        }

        public ICommand LoginCommand
        {
            get;
            private set;
        }


        public UserViewModel()
        {
            //user = new User() { UserId = 10m, FirstName = "Vijay", LastName = "Srinivasagam", Name = "isvijay" };
            user = new User() { Name = "isvijay" };
            LoginCommand = new UserLoginCommand(this);
        }
        
        internal bool CanAttemptLogin()
        {
            return !string.IsNullOrWhiteSpace(user.Name) && !string.IsNullOrWhiteSpace(user.Name) && user.Name.Length > 3;
        }

        public void Login()
        {
            /// Code here for login validations
            if ( user.Name.Equals("isvijay") )
            {
                FirstName = "Vijay";
                LastName = "Srinivasagam";
                UserId = 10m;
            }
        }

    }
}
