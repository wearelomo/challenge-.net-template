using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Seven_pay.Database
{
    public class DBContext : IDisposable
    {
        private SqlConnection _connection;
        private SqlTransaction _transaction;
        private string _connectionString;

        /// <summary>
        /// Builds the DBContext object.
        /// </summary>
        /// <param name="connectionString">ConnectionString used to connect to the database.</param>
        public DBContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Opens the connection to the database and initializes a transaction
        /// </summary>
        public void OpenConnection()
        {
            if (_connection != null || _transaction != null)
            {
                throw new Exception("Can't open connection");
            }
            _connection = new SqlConnection(_connectionString);
            // Commented for test
            //_connection.Open();
            //_transaction = _connection.BeginTransaction();
        }
        /// <summary>
        /// Opens the connection to the database 
        /// </summary>
        public void OpenConnectionWithoutTransaction()
        {
            if (_connection != null || _transaction != null)
            {
                throw new Exception("Can't open connection");
            }
            _connection = new SqlConnection(_connectionString);
            // Commented for test
            //_connection.Open();
        }

        /// <summary>
        /// Commits the transaction if there was a connection open.
        /// </summary>
        public void CommitTransaction()
        {
            // Commented for test
            //if (_transaction != null)
            //    _transaction.Commit();
            _transaction = null;
        }

        /// <summary>
        /// Rollbacks the transaction if there was a connection open.
        /// </summary>
        public void RollbackTransaction()
        {
            // Commented for test
            //if (_transaction != null)
            //    _transaction.Rollback();
            _transaction = null;
        }

        /// <summary>
        /// Closes the current connection. Rollbacks any open transactions.
        /// </summary>
        public void CloseConnection()
        {
            if (_connection != null)
            {
                // Commented for test
                //if (_transaction != null)
                //    RollbackTransaction();
                //_connection.Close();
                _connection = null;
            }
        }

        /// <summary>
        /// Destroys the object and close the connection.
        /// </summary>
        public void Dispose()
        {
            CloseConnection();
        }

        /// <summary>
        /// Creates an object that calls a Stored Procedure.
        /// </summary>
        /// <param name="name">name of the Stored Procedure to call.</param>
        /// <returns>SqlCommand object to call the Stored Procedure.</returns>
        public SqlCommand CreateStoredProcedureCommand(string name)
        {
            if (_connection == null || _transaction == null)
                throw new Exception("Can't create StoredProcedure");
            SqlCommand command = new SqlCommand(name, _connection, _transaction);
            command.CommandType = CommandType.StoredProcedure;
            return command;
        }
        /// <summary>
        /// Creates an object that calls a Stored Procedure.
        /// </summary>
        /// <param name="name">name of the Stored Procedure to call.</param>
        /// <returns>SqlCommand object to call the Stored Procedure.</returns>
        public SqlCommand CreateStoredProcedureCommandWithoutTransaction(string name)
        {
            if (_connection == null)
                throw new Exception("Can't create StoredProcedure");
            SqlCommand command = new SqlCommand(name, _connection, _transaction);
            command.CommandType = CommandType.StoredProcedure;
            return command;
        }
    }
}
