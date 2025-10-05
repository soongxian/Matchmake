namespace JodohFinder.Guard
{
    public class GuardNotFoundException : GuardParentException
    {
        public GuardNotFoundException(string id) : base($"{id} not found.")
        {

        }
    }
}
