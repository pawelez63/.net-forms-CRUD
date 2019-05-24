using System;
using System.Collections.Generic;
using DataBindingAppWinForms.Models;

namespace DataBindingAppWinForms.ViewModels
{
    public class MainFormViewModel
    {
        public IList<PersonModel> Items { get; }

        public MainFormViewModel()
        {
            Items = new List<PersonModel>()
            {
                new PersonModel
                {
                    City = "Zabrze",
                    DateOfBirth = new DateTime(1988, 11, 12),
                    LastName = "Matuszek",
                    Name = "Michał"
                }
            };
        }

    }
}