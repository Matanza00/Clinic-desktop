using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Demo1
{
    public class BillModel
    {
        [BsonId]
        public Guid Pid { get; set; }
        public string Name { get; set; }
        public string Treatment { get; set; }

        public string Bill { get; set; }

        public BillModel( string name, string t, string bill)
        {
            Name = name;
            Treatment = t;
            Bill = bill;
        }
    }
}
