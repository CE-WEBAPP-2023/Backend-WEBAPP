namespace Backend_WEBAPP.Models
{
    public class OrderModel
    {
        public object? _id { get; set; }

        public required UserModel User { get; set; }

        public UserModel? Raider { get; set; }

        public required string UserLocation { get; set; }

        public required CanteenModel Canteen { get; set; }

        public required List<FoodModel> Food { get; set; }
    }

    public class PostOrderModel
    {
        public required UserModel User { get; set; }

        public required string UserLocation { get; set; }

        public required CanteenModel Canteen { get; set; }

        public required List<FoodModel> Food { get; set; }
    }

}