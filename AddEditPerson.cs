using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBindingAppWinForms.ViewModels;

namespace DataBindingAppWinForms
{
    public partial class AddEditPerson : Form
    {
        public AddEditPersonViewModel ViewModel { get; }
        public AddEditPerson()
        {
            ViewModel = new AddEditPersonViewModel();
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ViewModel.DateOfBirth = dtDateOfBirth.Value;
            ViewModel.City = txtCity.Text;
            ViewModel.LastName = txtLastName.Text;
            ViewModel.Name = txtName.Text;
        }

        public void SetFields()
        {
            txtName.Text = ViewModel.Name;
            txtLastName.Text = ViewModel.LastName;
            dtDateOfBirth.Value = ViewModel.DateOfBirth;
            txtCity.Text = ViewModel.City;
        }
    }
}
