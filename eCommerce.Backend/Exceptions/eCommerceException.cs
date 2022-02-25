namespace eCommerce.Backend.Exceptions
{
    public class eCommerceException : Exception
    {
        public eCommerceException()
        {
        }

        public eCommerceException(string message)
            : base(message)
        {
        }

        public eCommerceException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}