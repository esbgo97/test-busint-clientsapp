using BusInt.TestApp.Database;
using BusInt.TestApp.Models.Entities;
using BusInt.TestApp.Repositories.Implementations;
using BusInt.TestApp.Repositories.Interfaces;
using MySqlX.XDevAPI;
using System.Data;

namespace BusInt.TestApp.Client
{
    public partial class ClientRegister : Form
    {
        private readonly IClienteRepository _repository;
        private readonly IPaisRepository _paisRepo;
        private readonly ICityRepository _cityRepository;
        
        public ClientRegister()
        {
            InitializeComponent();
            var context = new AppDbContext();
            _repository = new ClienteRepository(context);
            _paisRepo = new PaisRepository(context);
            _cityRepository = new CityRepository(context);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = new Cliente();

                cliente.DocType = cmbDocType.SelectedValue.ToString();

                cliente.Document = txtDocument.Text;
                cliente.Names = txtName.Text;
                cliente.LastNames = txtLastName.Text;
                cliente.Phone = txtPhone.Text;
                cliente.Email = txtEmail.Text;
                cliente.Address = txtAddress.Text;
                cliente.Neighbornhood = txtNeighbornhood.Text;
                cliente.Birth = dtmBirth.Value;
                cliente.AcceptData = chkData.Checked;
                cliente.AcceptTerm = chkTerms.Checked;
                cliente.AcceptNotifications = chkTerms.Checked;
                cliente.Job = txtJob.Text;
                
                cliente.Country = cmbCountry.SelectedValue?.ToString();
                cliente.City = cmbCity.SelectedValue?.ToString();
                cliente.CivilStatus = cmbCivilStatus.SelectedText?.ToString();

                cliente.NumChild = int.Parse(numChild.Value.ToString());

                var result = await _repository.Save(cliente);
                if(result > 0)
                {
                    MessageBox.Show($"Se creó el usuario {cliente.Names} {cliente.LastNames}, correctamente.");
                    Thread.Sleep(4000);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void ClientRegister_Load(object sender, EventArgs e)
        {
            await LoadCountries();
            await LoadCities();
            LoadCivilStatus();
            LoadDocTypes();
        }

        private async Task LoadCountries()
        {
            var items = await _paisRepo.GetAll();
            cmbCountry.DataSource = items;
            cmbCountry.DisplayMember = "Nompais";
            cmbCountry.ValueMember = "Cod";
        }

        private async Task LoadCities()
        {
            var cities = await _cityRepository.GetByCountryCode("");
            cmbCity.DataSource = cities;
            cmbCity.DisplayMember = "DianName";
            cmbCity.ValueMember = "DianCode";
        }

        private void LoadDocTypes()
        {
            DataTable TiposDoc = new DataTable();
            TiposDoc.Columns.Add("Cod");
            TiposDoc.Columns.Add("Nombre");
            TiposDoc.Rows.Add("C", "Cedula");
            TiposDoc.Rows.Add("N", "Nit");
            TiposDoc.Rows.Add("CE", "Cédula de Extranjeria");
            TiposDoc.Rows.Add("CI", "Consecutivo Interno");
            TiposDoc.Rows.Add("TI", "Tarjeta de Identidad");
            TiposDoc.Rows.Add("P", "Pasaporte");
            TiposDoc.Rows.Add("R", "Registro fiscal Exterior");
            TiposDoc.Rows.Add("RC", "Registro Civil");
            TiposDoc.Rows.Add("TE", "Tarjeta de extrangeria");
            TiposDoc.Rows.Add("DE", "Documento de identificación extranjero");
            TiposDoc.Rows.Add("NP", "NIT de otro país");
            TiposDoc.Rows.Add("BU", "NUIP*");

            cmbDocType.DataSource = TiposDoc;
            cmbDocType.DisplayMember = "Nombre";
            cmbDocType.ValueMember = "Cod";
        }

        private void LoadCivilStatus()
        {
            string[] civilStatues = { "Soltero", "Casado", "Unión Libre", "Viudo" };
            cmbCivilStatus.Items.AddRange(civilStatues);

        }

    }
}
