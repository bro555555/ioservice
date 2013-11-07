using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Configuration;
using ioservice.Models;

namespace ioservice.Controllers
{
    public class transportAllResourcesController : ApiController
    {
        public static readonly string mongoUrl = ConfigurationManager.AppSettings["MONGOLAB_URI"];
        public static readonly string mongoDatabase = "appharbor_de1b58c9-5aa7-46b7-86eb-47d563f78b62";

        private static MongoDB.Driver.MongoDatabase ConnectToDatabase()
        {
            MongoDB.Driver.MongoClient client = new MongoDB.Driver.MongoClient(mongoUrl);
            var server = client.GetServer();
            var db = server.GetDatabase(mongoDatabase);
            return db;
        }

        // GET api/values
        public IEnumerable<ScriptModel> Get()
        {
            var db = ConnectToDatabase();
            var scripts = db.GetCollection("scripts");
            var query = from script in scripts.FindAllAs<ScriptModel>() select script;
            return query.ToList();

        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]ScriptModel script)
        {
            var db = ConnectToDatabase();
            var scripts = db.GetCollection("Scripts");
            scripts.Insert(script);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
