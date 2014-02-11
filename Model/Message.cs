using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoCSharpTest.Model
{
    class Message
    {
        public ObjectId _id { get; set; }
        public string plant { get; set; }
        public string truck { get; set; }
        public string status { get; set; }
        public string payload { get; set; }
        public DateTime createdate { get; set; }
    }
}
