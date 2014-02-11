using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
//using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;
using MongoDB.Bson;


namespace MongoCSharpTest.Model
{
    class DAL
    {

        public DAL()
        {

        }

        

        public static void CreateMessage(string plant, string truck, string payload, string status)
        {

            var MsgCollection = MongoWrapper.GetDatabase().GetCollection("MessageQueue");

            // Create BsonDocument object for new user
            var message = new BsonDocument();
            message["plant"] = plant;
            message["truck"] = truck;
            message["payload"] = payload;
            message["status"] = status;
            message["createdate"] = DateTime.Now;

            // Insert new user object to collection
            MsgCollection.Insert(message);
        }

        public static List<Message> GetMessages(string plant, string truck, string status, bool descendingSort, int limitRecords)
        {
            List<Message> lst = new List<Message>();
            var sortBy = SortBy.Descending("createdate");

            //var query = Query.EQ("plant", plant);

            var query = new QueryDocument();

            if (plant != "")
            {
                query.Add("plant", plant);
            };

            if (truck != "")
            {
                query.Add("truck", truck);
            };

            if (status != "All")
            {
                query.Add("status", status);
            };

            if (!descendingSort) 
            {
                sortBy = SortBy.Ascending("createdate");
            };

 
            MongoCollection<Message> messages = MongoWrapper.GetDatabase().GetCollection<Message>("MessageQueue");

            var cursor = messages.Find(query).SetSortOrder(sortBy);

            if (limitRecords > 0)
            {
                cursor.SetLimit(limitRecords);
            };

            foreach (Message message in cursor)
            {
                lst.Add(message);
            }

            return lst;
        }

    }
}
