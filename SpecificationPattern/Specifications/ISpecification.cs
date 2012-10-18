namespace SpecificationPattern.Specifications
{
    public interface ISpecification<in T>
    {
        bool IsSatisfiedBy(T entity);
    }
}