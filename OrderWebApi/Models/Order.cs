using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace OrderWebApi.Models
{
    [Serializable, BsonIgnoreExtraElements]
    public class Order
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string OrderId { get; set; } = null!;
        [BsonElement("customer_id"), BsonRepresentation(BsonType.ObjectId)]
        public int CustomerId { get; set; }
        [BsonElement("ordered_on"), BsonRepresentation(BsonType.ObjectId)]
        public DateTime OrderedOn { get; set; }
        [BsonElement("order_details")]
        public List<OrderDetail> OrderDetails { get; set; }  
    }

}
