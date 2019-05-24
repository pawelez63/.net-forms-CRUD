using System;

namespace DataBindingAppWinForms.Models
{
    public class PersonModel
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age => (DateTime.Now - DateOfBirth).Days;

        public string City { get; set; }
    }
}