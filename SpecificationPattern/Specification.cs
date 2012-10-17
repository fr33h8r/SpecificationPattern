namespace SpecificationPattern
{
    public abstract class Specification<T>
    {
        public abstract bool IsSatisfiedBy(T item);
    }
}