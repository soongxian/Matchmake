using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JodohFinder.SpecificationCheck
{
    public static class SpecificationExtension
    {
        public static Task<T> FirstOrDefaultAsync<T>(this DbSet<T> dbSet, Specification<T> specification) where T : class
        {
            return dbSet.WithSpecification(specification).FirstOrDefaultAsync();
        }
    }
}
