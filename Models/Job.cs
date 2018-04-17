using System.Collections.Generic;
using System;

namespace JobBoard.Models
{
    public class JobOpening
        {
        private string _jobTitle;
        private string _description;
        private int _salary;
        private string _contatctPerson;
        private static List<JobOpening> _instances = new List<JobOpening> {};

        public JobOpening (string JobTitle, int Description, int Salary, string ContatctPerson)
        {
            _jobTitle = JobTitle;
            _description = Description;
            _salary = salary;
            _contactPerson = ContactPerson;
        }

        public void SetJob(string newJob)
        {
            _jobTitle = newJob;
        }
        public string GetJob()
        {
            return jobTitle;
        }

        public void SetDescription(int newDescription)
        {
            _description = newDescription;
        }
        public int GetDescription()
        {
            return _description;
        }
        public void SetSalary(int newSalary)
        {
            _salary = newSalary;
        }
        public int GetSalary()
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

        public static List<Car> GetAll()
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
