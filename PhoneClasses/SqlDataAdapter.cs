using System;

namespace PhoneClasses
{
    public class SqlDataAdapter
    {
        private string sProcName;
        private SqlConnection connectionToDB;

        public SqlDataAdapter()
        {
        }

        public SqlDataAdapter(string sProcName, SqlConnection connectionToDB)
        {
            this.sProcName = sProcName;
            this.connectionToDB = connectionToDB;
        }

        public SqlCommand SelectCommand { get; internal set; }

        internal void Fill(DataTable dataTable)
        {
            throw new NotImplementedException();
        }
    }
}