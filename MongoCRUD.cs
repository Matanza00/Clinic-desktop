using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Demo1
{
    public class MongoCRUD
    {
        private IMongoDatabase db;
        public MongoCRUD(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }
        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);

        }
        public List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find(new BsonDocument()).ToList();
        }
        public T LoadRecordByPid<T>(string table, string Name)
        {
            var collection = db.GetCollection<T>(table);
            var filters = Builders<T>.Filter.Eq("Name", Name);
            return collection.Find(filters).First();
        }
        public void UpsertRecord<T>(string table, string Name, T record)
        {
            var collection = db.GetCollection<T>(table);
            var result = collection.ReplaceOne(new BsonDocument("Name", Name), record, new UpdateOptions { IsUpsert = true });
        }
        public void DeleteRecord<T>(string table, string Name)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Name", Name);
            collection.DeleteOne(filter);

        }
    }
}
