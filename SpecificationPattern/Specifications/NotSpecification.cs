namespace SpecificationPattern.Specifications
{
    public class NotSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> first;
        private readonly ISpecification<T> second;

        public NotSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first;
            this.second = second;
        }

        public bool IsSatisfiedBy(T entity)
        {
            return !first.IsSatisfiedBy(entity).Equals(second.IsSatisfiedBy(entity));
        }
    }
}