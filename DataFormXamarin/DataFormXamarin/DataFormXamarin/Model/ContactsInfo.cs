using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataFormXamarin
{
    public class ContactsInfo : INotifyPropertyChanged
    {
        private string name;
        private string country;
        private string gender;
        private string email;
        private DateTime dateOfBirth;
        public ContactsInfo()
        {

        }
        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
                this.RaisePropertyChanged("Name");
            }
        }

        public string Gender
        {
            get { return this.gender; }
            set
            {
                this.gender = value;
                this.RaisePropertyChanged("Gender");
            }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                dateOfBirth = value;
                this.RaisePropertyChanged("DateOfBirth");
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                this.RaisePropertyChanged("Email");
            }
        }

        public string Country
        {
            get { return country; }
            set
            {
                country = value;
                this.RaisePropertyChanged("Country");
            }
        }

       

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(String Name)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(Name));
        }
    }
}
