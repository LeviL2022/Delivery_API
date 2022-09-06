using Microsoft.AspNetCore.Mvc;
using DeliveryAPI.Models;
using Repository;

namespace DeliveryAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class DeliveryController : ControllerBase
    {
        DeliveryRepository repository = new DeliveryRepository();

        [HttpPost]
        public void SaveDelivery([FromBody] Delivery delivery)
        {

            repository.RegistrationDelivery(delivery);
        }

        [HttpGet]
        public List<Delivery> GetDeliverys()
        {
            return repository.GetDeliverys();
        }
    }

}