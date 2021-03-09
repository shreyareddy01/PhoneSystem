using System;

namespace PhoneClasses
{
    public class SqlConnection
    {
        private string connectionString;

        public SqlConnection()
        {
        }

        public SqlConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }
    }
}