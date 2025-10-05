namespace JodohFinder.Guard
{
    public class GuardParentException : Exception
    {
        public int StatusCode { get; }
        public string CustomMessage { get; }

        public GuardParentException(string message) : base(message)
        {
            CustomMessage = message;
            StatusCode = 400;
        }
    }
}
