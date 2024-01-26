using LogService.Data.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogService.Data.Repositories
{
    public class LogRepository
    {
        private readonly IMongoCollection<Log> _logs;
        public LogRepository() { 
        
            var client = new MongoClient("mongodb://localhost:27017");

            var database = client.GetDatabase("LogDatabase");

            _logs = database.GetCollection<Log>("logs");

        }

        public async Task<Log> CreateLog(Log log) { 
        
            await _logs.InsertOneAsync(log);
            return log;



        }

    }
}
