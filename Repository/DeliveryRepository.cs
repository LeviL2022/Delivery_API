using DeliveryAPI.Models;
namespace Repository
{
    public class DeliveryRepository
    {

        private static List<Delivery> deliverys = new List<Delivery>();
        private static int id = 1;
        private static int numOfDelivery = 1;


        public void RegistrationDelivery(Delivery delivery)
        {

            delivery.NumOfDelivery = numOfDelivery++;
            delivery.Id = id++;
            deliverys.Add(delivery);

        }

        public List<Delivery> GetDeliverys()
        {
            return deliverys;
        }

    }
}