﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace wfaProjetoIntegrador.Configuration
{
    public static class Connection
    {
        static NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Username=postgres;Password=123;Database=projetoIntegrador");

        public static NpgsqlConnection getConnection()
        {
            if (connection.State.Equals(System.Data.ConnectionState.Closed)) {
                connection.Open();
                return connection;
            }
            connection.Open();
            return connection;
        }

        public static void closeConnection()
        {
            connection.Close();
        }

    }
}
