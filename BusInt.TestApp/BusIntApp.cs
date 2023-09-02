using BusInt.TestApp.Client;
using BusInt.TestApp.Database;
using BusInt.TestApp.Models.Entities;
using BusInt.TestApp.Repositories.Implementations;
using BusInt.TestApp.Repositories.Interfaces;
using System.ComponentModel;

namespace BusInt.TestApp
{
    public partial class BusIntApp : Form
    {
        private readonly IClienteRepository _repository;
        public BusIntApp()
        {
            InitializeComponent();
            var context = new AppDbContext();
            _repository = new ClienteRepository(context);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var items = await _repository.GetAll();
                var bindingList = new BindingList<Cliente>(items);
                dataGridView1.DataSource = bindingList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void registarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //await Task.Run(() =>
            //{
                ClientRegister clientRegisterForm = new ClientRegister();
                clientRegisterForm.Show();

            //});
        }
    }
}