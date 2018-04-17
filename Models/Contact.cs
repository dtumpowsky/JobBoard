using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace JobBoard.Models
{

    public class Contact
    {
        private string _name;
        private string _phoneNumber;
        private string _email;
        public Contact(string Name, string Number, string Email)
        {
            _name = Name;
            _phoneNumber = Number;
            _email = Email;
        }

        public void SetName(string newName)
        {
            _name = newName;
        }
        public string GetName()
        {
            return _name;
        }

        public void SetNumber(string newNumber)
        {
            _phoneNumber = newNumber;
        }
        public string GetNumber()
        {
            return _phoneNumber;
        }

        public void SetEmail(string newEmail)
        {
            _email = newEmail;
        }
        public string GetEmail()
        {
            return _email;
        }
    }
}
