﻿using System;
using System.Collections.Generic;
using wfaProjetoIntegrador.Configuration;
using Npgsql;
using System.Data;
using System.Linq;

namespace wfaProjetoIntegrador.Repository
{
    abstract class BaseRepository<T, K> : Repository<T, K>
    {
        String tableName;
        public BaseRepository()
        {
            tableName = typeof(T).Name.ToLower();
        }

        public List<T> getAll()
        {
            var connection = Connection.getConnection();
            var cmd = new NpgsqlCommand("SELECT * FROM " + tableName + " ORDER BY id DESC", connection);
            var reader = cmd.ExecuteReader();

            List<T> records = new List<T>();

            while (reader.Read())
            {
                records.Add(parse(reader));
            }
            connection.Close();
            return records;
        }

        public T find(K id)
        {
            var connection = Connection.getConnection();
            var query = "SELECT * FROM " + tableName + " WHERE id = @id " + " ORDER BY id DESC";
            var cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("id", id);
            var reader = cmd.ExecuteReader();

            T record = default;
            if (reader.Read())
            {
                record = parse(reader);
            }
            connection.Close();
            return record;
        }

        public T findBy(string fieldName, dynamic value)
        {
            var connection = Connection.getConnection();
            var query = "SELECT * FROM " + tableName + " WHERE " + fieldName + " = @" + fieldName + " ORDER BY id DESC";
            var cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue(fieldName, value);
            var reader = cmd.ExecuteReader();

            T record = default;
            if (reader.Read())
            {
                record = parse(reader);
            }
            connection.Close();
            return record;
        }

        public T findBy(Dictionary<string, dynamic> fields, string queryOperator = "AND")
        {
            var connection = Connection.getConnection();
            var query = "SELECT * FROM " + tableName + " WHERE ";

            var fieldList = fields.Keys.ToList<string>();
            for (int i = 0;i< fieldList.Count; i++)
            {
                query += fieldList[i] + "= @" + fieldList[i];

                if(!(i+1 >= fieldList.Count))
                {
                    query += " "+ queryOperator + " ";
                }
            }
            query += " ORDER BY id DESC";
            var cmd = new NpgsqlCommand(query, connection);

            foreach(string field in fieldList)
            {
                cmd.Parameters.AddWithValue(field, fields[field]);
            }

            var reader = cmd.ExecuteReader();

            T record = default;
            if (reader.Read())
            {
                record = parse(reader);
            }
            connection.Close();
            return record;
        }

        public List<T> queryBy(Dictionary<string, dynamic> fields, string queryOperator = "AND")
        {
            var connection = Connection.getConnection();
            var query = "SELECT * FROM " + tableName + " WHERE ";

            var fieldList = fields.Keys.ToList<string>();
            for (int i = 0; i < fieldList.Count; i++)
            {
                query += fieldList[i] + "= @" + fieldList[i];

                if (!(i + 1 >= fieldList.Count))
                {
                    query += " " + queryOperator + " ";
                }
            }

            query += " ORDER BY id DESC";
            var cmd = new NpgsqlCommand(query, connection);

            foreach (string field in fieldList)
            {
                cmd.Parameters.AddWithValue(field, fields[field]);
            }

            var reader = cmd.ExecuteReader();

            List<T> records = new List<T>();

            while (reader.Read())
            {
                records.Add(parse(reader));
            }
            connection.Close();
            return records;
        }

        public bool create(T model)
        {
            List<String> columns = typeof(T).GetProperties().Select(f => f.Name).ToList();
            columns.Remove("id");
            List<String> values = columns.Select(f => "@" + f).ToList();

            var connection = Connection.getConnection();
            string statement = "INSERT INTO " + tableName + "(" + string.Join(",", columns) + ") values (" + string.Join(",", values) + ")";

            int result;

            using (var cmd = new NpgsqlCommand(statement, connection))
            {
                foreach (var field in columns)
                {
                    cmd.Parameters.AddWithValue(field, model.GetType().GetProperty(field).GetValue(model));
                }

                result = cmd.ExecuteNonQuery();
            }
            connection.Close();
            return result == 1 ? true : false;
        }

        public bool delete(K id)
        {
            var connection = Connection.getConnection();
            var query = "DELETE FROM " + tableName + " WHERE id = @id ";
            var cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("id", id);
            var result = cmd.ExecuteNonQuery() == 1 ? true : false;
            connection.Close();
            return result;
        }
        public bool update(K id, T model)
        {
            List<String> columns = typeof(T).GetProperties().Select(f => f.Name).ToList();
            columns.Remove("id=@id");
            List<String> values = typeof(T).GetProperties().Select(f => f.Name + "=@" + f.Name).ToList();


            var connection = Connection.getConnection();
            string statement = "UPDATE " + tableName + " SET " + string.Join(",", values) + " WHERE id = @id ";

            int nonQueryResult;

            using (var cmd = new NpgsqlCommand(statement, connection))
            {
                cmd.Parameters.AddWithValue("id", id);
                foreach (var field in columns)
                {
                    cmd.Parameters.AddWithValue(field, model.GetType().GetProperty(field).GetValue(model));
                }

                nonQueryResult = cmd.ExecuteNonQuery();
            }
            connection.Close();
            return nonQueryResult == 1 ? true : false;
        }
        public abstract T parse(IDataRecord record);

    }
}
