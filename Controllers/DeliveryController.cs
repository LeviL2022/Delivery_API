using Microsoft.AspNetCore.Mvc;
using DeliveryAPI.Models;

namespace DeliveryAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class DeliveryController : ControllerBase
    {
        private static List<Delivery> deliverys = new List<Delivery>();
        private static int id = 1;
        private static int numOfDelivery = 1;

        [HttpPost]
        public void RegistrationDelivery([FromBody] Delivery delivery)
        {
            delivery.NumOfDelivery = numOfDelivery++;
            delivery.Id = id++;
            deliverys.Add(delivery);

        }

        [HttpGet]
        public List<Delivery> GetDelivery()
        {
            return deliverys;
        }
    }
}
