namespace PhoneClasses
{
    public class SqlCommandBuilder
    {
        private SqlDataAdapter dataChannel;

        public SqlCommandBuilder()
        {
        }

        public SqlCommandBuilder(SqlDataAdapter dataChannel)
        {
            this.dataChannel = dataChannel;
        }
    }
}