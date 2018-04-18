using System.Collections.Generic;
using System;

namespace JobBoard.Models
{
    public class JobOpening
    {
        private string _jobTitle;
        private string _description;
        //long is a different kind of int
        private long _salary;
        private Contact _contact;
        private static List<JobOpening> _instances = new List<JobOpening> {};

        public JobOpening(string JobTitle, string Description, long Salary, Contact contact)
        {
            _jobTitle = JobTitle;
            _description = Description;
            _salary = Salary;
            _contact = contact;
        }

        public void SetJob(string newJob)
        {
            _jobTitle = newJob;
        }
        public string GetJobTitle()
        {
            return _jobTitle;
        }

        public void SetDescription(string newDescription)
        {
            _description = newDescription;
        }
        public string GetDescription()
        {
            return _description;
        }
        public void SetSalary(int newSalary)
        {
            _salary = newSalary;
        }
        public long GetSalary()
        {
            return _salary;
        }

        public Contact GetContact()
        {
            return _contact;
        }

        public static List<JobOpening> GetAll()
        {
        return _instances;
        }

        public void Save()
        {
            _instances.Add(this);
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}
