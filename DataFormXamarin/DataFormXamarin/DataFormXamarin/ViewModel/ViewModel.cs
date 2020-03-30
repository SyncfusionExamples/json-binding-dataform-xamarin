using DataFormXamarin;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace DataFormXamarin
{
    public class ViewModel : INotifyPropertyChanged
    {
        private ContactsInfo contactsInfo;

        public event PropertyChangedEventHandler PropertyChanged;

        //// Add data for JSON data model
        private string JsonData =
          "[{\"UserName\": \"Chan\",\"UserGender\": \"Male\",\"UserMail\": \"chan@yyy.com\",\"UserCountry\": \"Japan\", \"UserBirthDate\": \"05/01/1996\"}]";

        public ContactsInfo ContactsInfo
        {
            get { return this.contactsInfo; }
            set
            {
                this.contactsInfo = value;
                this.RaisePropertyChanged("ContactsInfo");
            }
        }

        public ViewModel()
        {
            this.ContactsInfo = new ContactsInfo();

            //// Deserialize the JSON data as list of JSON data model.
            List<JSONData> jsonDataCollection = JsonConvert.DeserializeObject<List<JSONData>>(JsonData);

            foreach (var data in jsonDataCollection)
            {
                this.ContactsInfo.Name = data.UserName;
                this.ContactsInfo.Gender = data.UserGender;
                this.ContactsInfo.Email = data.UserMail;
                this.ContactsInfo.Country = data.UserCountry;
                this.ContactsInfo.DateOfBirth = Convert.ToDateTime(data.UserBirthDate);
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
