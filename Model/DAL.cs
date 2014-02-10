using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;


namespace MongoCSharpTest.Model
{
    class DAL
    {

        public DAL()
        {

        }

        

        public static void CreateMessage(string plant, string truck, string payload)
        {

            var MsgCollection = MongoWrapper.GetDatabase().GetCollection("MessageQueue");

            // Create BsonDocument object for new user
            var message = new BsonDocument();
            message["plant"] = plant;
            message["truck"] = truck;
            message["payload"] = payload;
            message["createdate"] = DateTime.Now;

            // Insert new user object to collection
            MsgCollection.Insert(message);
        }

        public static List<Message> GetMessages()
        {
            List<Message> lst = new List<Message>();

            var MsgCollection = MongoWrapper.GetDatabase().GetCollection("MessageQueue");

            MongoCollection<Message> messages = MongoWrapper.GetDatabase().GetCollection<Message>("MessageQueue");
            foreach (Message message in messages.FindAll())
            {
                lst.Add(message);
            }

            return lst;
        }

    }
}
