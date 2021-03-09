namespace PhoneClasses
{
    public class SqlCommand
    {
        private string sProcName;
        private SqlConnection connectionToDB;

        public SqlCommand(string sProcName, SqlConnection connectionToDB)
        {
            this.sProcName = sProcName;
            this.connectionToDB = connectionToDB;
        }

        public object Parameters { get; internal set; }
        public object CommandType { get; internal set; }
    }
}