namespace SpecificationPattern.Specifications
{
    public class OrSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> first;
        private readonly ISpecification<T> second;

        public OrSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first;
            this.second = second;
        }

        public bool IsSatisfiedBy(T entity)
        {
            return first.IsSatisfiedBy(entity) || second.IsSatisfiedBy(entity);
        }
    }
}