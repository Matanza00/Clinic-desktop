using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Demo1
{
    public class PatientModel
    {
        [BsonId]
        public Guid Pid { get; set; }
        public string Name { get; set; }
        public string PhNo { get; set; }
        public DateTime DOB { get; set; }
        public string Predicament{ get; set; }

        public PatientModel(string name,string phno, DateTime dob, string pd)
        {
            Name = name;
            PhNo = phno;
            DOB = dob;
            Predicament = pd;
        }
    }
}

//Name: "Usman Nadeem"
//PhNo : "428451221"
//DOB : 2021 - 04 - 08T19: 00:00.000 + 00:00
//Predicament : "I don't know"

