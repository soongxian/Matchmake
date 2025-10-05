namespace JodohFinder.Guard
{
    public class GuardInvalidException : GuardParentException
    {
        public GuardInvalidException(string id) : base($"{id} is invalid.")
        {

        }
    }
}
