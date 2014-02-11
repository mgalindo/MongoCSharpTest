using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MongoDB.Driver;

namespace MongoCSharpTest.Model
{
    public class MongoWrapper
    {
        public static MongoDatabase GetDatabase()
        {
            var client = new MongoClient(ConnectionString);

            var server = client.GetServer();

            // Create server settings to pass connection string, timeout, etc.
            //MongoServer server = MongoServer.Create(ConnectionString);

            // Get our database instance to reach collections and data
            var database = server.GetDatabase("MessageQueue");

            return database;
        }

        public static string ConnectionString
        {
            get
            {
                //return "Server=localhost:27017"; 
                return ConfigurationManager.AppSettings["connectionString"];
            }
        }

    }
}
