using Dapper;
using Kodehive.Service.Interface.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodehive5._0.Service.Services
{
    public class DbService : IDbService
    {
        private readonly IDbConnection _db;
        public DbService(IConfiguration configuration)
        {
            _db = new MySqlConnection(configuration.GetConnectionString("ConnectKampus12"));
        }

        public async Task<List<T>> Get<T>(string command,object param)
        {
            List<T> result=(await _db.QueryAsync<T>(command,param)).ToList();
            return result;
        }

        public async Task<int> ModifyData(string command, object param)
        {
            var result = await _db.ExecuteAsync(command, param);
            return result;
        }
    }
}
