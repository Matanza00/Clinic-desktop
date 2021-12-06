using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Demo1
{
    public class AppointModel
    {
        [BsonId]
        public Guid Pid { get; set; }
        public string Name { get; set; }
        public DateTime CApp { get; set; }
        public string Doctor  { get; set; }


        public AppointModel(string name,DateTime ca,string doc)
        {
            Name = name;
            CApp = ca;
            Doctor = doc;
        }
    }
}
