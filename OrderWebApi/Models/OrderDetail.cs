using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace OrderWebApi.Models
{
    public class OrderDetail
    {
        [BsonElement("product_id"), BsonRepresentation(BsonType.ObjectId)]
        public int ProductId { get; set; }
        [BsonElement("quantity"), BsonRepresentation(BsonType.ObjectId)]
        public decimal Quantity { get; set; }
        [BsonElement("unit_price"), BsonRepresentation(BsonType.ObjectId)]
        public decimal UnitPrice { get; set; }
    }
}
