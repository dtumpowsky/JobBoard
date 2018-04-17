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
        private string _contactPerson;
        private static List<JobOpening> _instances = new List<JobOpening> {};

        public JobOpening (string JobTitle, string Description, long Salary, string ContactPerson)
        {
            _jobTitle = JobTitle;
            _description = Description;
            _salary = Salary;
            _contactPerson = ContactPerson;
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
        public void SetContactPerson(string newContactPerson)
        {
            _contactPerson = newContactPerson;
        }
        public string GetContactPerson()
        {
            return _contactPerson;
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
