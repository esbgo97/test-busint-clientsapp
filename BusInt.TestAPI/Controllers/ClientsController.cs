using BusInt.TestApp.Database;
using BusInt.TestApp.Repositories.Implementations;
using BusInt.TestApp.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusInt.TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClienteRepository _repository;
        public ClientsController()
        {
            var context = new AppDbContext();
            _repository = new ClienteRepository(context);
        }
        

    }
}
