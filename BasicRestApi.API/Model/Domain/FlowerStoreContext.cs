using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BasicRestApi.Model.Domain
{
    public class FlowerStoreContext
    {
        public string ConnectionString { get; set; }

        public FlowerStoreContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        internal object GetAllAlbums()
        {
            throw new NotImplementedException();
        }
    }
}