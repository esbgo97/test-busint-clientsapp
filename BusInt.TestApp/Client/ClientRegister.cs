using BusInt.TestApp.Database;
using BusInt.TestApp.Models.Entities;
using BusInt.TestApp.Repositories.Implementations;
using BusInt.TestApp.Repositories.Interfaces;

namespace BusInt.TestApp.Client
{
    public partial class ClientRegister : Form
    {
        private readonly IClienteRepository _repository;
        public ClientRegister()
        {
            InitializeComponent();
            var context = new AppDbContext();
            _repository = new ClienteRepository(context);
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = new Cliente()
                {
                    DocType = cmbDocType.SelectedValue.ToString(),
                    Document = txtDocument.Text,
                    Names = txtName.Text,
                    LastNames = txtLastName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Country = int.Parse(cmbCountry.SelectedValue.ToString()),
                    Address = txtAddress.Text,
                    Neighbornhood = txtNeighbornhood.Text,
                    Birth = dtmBirth.Value,
                    CivilStatus = int.Parse(cmbCivilStatus.SelectedValue.ToString()),
                    NumChild = int.Parse(numChild.Value.ToString()),
                    AcceptData = chkData.Checked,
                    AcceptTerm = chkTerms.Checked,
                    AcceptNotifications = chkTerms.Checked,
                    Job = txtJob.Text
                };

                var result = await _repository.Save(cliente);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
