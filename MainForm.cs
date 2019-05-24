using System.Windows.Forms;
using DataBindingAppWinForms.Models;
using DataBindingAppWinForms.ViewModels;

namespace DataBindingAppWinForms
{
    public partial class MainForm : Form
    {
        private readonly MainFormViewModel _viewModel = new MainFormViewModel();
        public MainForm()
        {
            InitializeComponent();
            bsPersons.DataSource = _viewModel.Items;
        }

        private void RefreshGrid()
        {
            bsPersons.DataSource = null;
            bsPersons.DataSource = _viewModel.Items;
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            var form = new AddEditPerson();

            var res = form.ShowDialog();

            if (res == DialogResult.OK)
            {
                var newPerson = new PersonModel
                {
                    City = form.ViewModel.City,
                    DateOfBirth = form.ViewModel.DateOfBirth,
                    Name = form.ViewModel.Name,
                    LastName = form.ViewModel.LastName
                };

                _viewModel.Items.Add(newPerson);

                RefreshGrid();
            }
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (gridViewPersons.SelectedRows.Count == 1)
            {
                var selectedRowIndex = gridViewPersons.SelectedRows[0].Index;

                _viewModel.Items.RemoveAt(selectedRowIndex);

                RefreshGrid();
            }
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            if (gridViewPersons.SelectedRows.Count == 1)
            {
                var selectedRowIndex = gridViewPersons.SelectedRows[0].Index;

                var selectedPerson = _viewModel.Items[selectedRowIndex];

                var form = new AddEditPerson();

                form.ViewModel.DateOfBirth = selectedPerson.DateOfBirth;
                form.ViewModel.City = selectedPerson.City;
                form.ViewModel.LastName = selectedPerson.LastName;
                form.ViewModel.Name = selectedPerson.Name;

                form.SetFields();

                var res = form.ShowDialog();

                if (res == DialogResult.OK)
                {
                    selectedPerson.DateOfBirth = form.ViewModel.DateOfBirth;
                    selectedPerson.City = form.ViewModel.City;
                    selectedPerson.Name = form.ViewModel.Name;
                    selectedPerson.LastName = form.ViewModel.LastName;
                    RefreshGrid();
                }
            }
        }
    }
}
