namespace PhoneClasses
{
    public class SqlParameter
    {
        private string paramName;
        private object paramValue;

        public SqlParameter()
        {
        }

        public SqlParameter(string paramName, object paramValue)
        {
            this.paramName = paramName;
            this.paramValue = paramValue;
        }

        public object Direction { get; internal set; }
        public object Value { get; internal set; }
    }
}