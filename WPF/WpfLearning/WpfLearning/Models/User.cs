using System;

namespace WpfLearning.Models
{
    public class User : ModelBase
    {
        private decimal userId;

        public decimal UserId
        {
            get { return userId; }
            set
            {
                userId = value;
                NotifyPropertyChanged("UserId");
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                NotifyPropertyChanged("FirstName");
            }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                NotifyPropertyChanged("LastName");
            }
        }
        
        public User()
        {

        }

    }
}
