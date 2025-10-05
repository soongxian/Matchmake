namespace JodohFinder.Guard
{
    public class GuardDuplicateException : GuardParentException
    {
        public GuardDuplicateException(string id) : base($"{id} is duplicated.")
        {
        }
    }
}
