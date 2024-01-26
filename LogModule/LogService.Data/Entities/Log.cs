using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogService.Data.Entities
{
    public class Log
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; } = null!;

        [BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string ServiceName { get; set; } = null!;


        [BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string LogType { get; set; } = null!;


        [BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string LogException { get; set; } = null!;


        [BsonRepresentation(MongoDB.Bson.BsonType.DateTime)]
        public DateTime LogDate { get; set; }
    }
}
