using System;
using SpecificationPattern.Specifications;

namespace SpecificationPattern
{
    public class BankAccount
    {
        public int CurrentBalance { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Console.ReadLine();
        }
    }

    public class AccoundOverdrawnSpecification : ISpecification<BankAccount>
    {
        public bool IsSatisfiedBy(BankAccount entity)
        {
            return entity.CurrentBalance < 0;
        }
    }

    public static class SpecificationsExtensionsMethods
    {
        public static ISpecification<T> And<T>(this ISpecification<T> first, ISpecification<T> second)
        {
            return new AndSpecification<T>(first, second);
        }

        public static ISpecification<T> Or<T>(this ISpecification<T> first, ISpecification<T> second)
        {
            return new OrSpecification<T>(first, second);
        }

        public static ISpecification<T> Not<T>(this ISpecification<T> first, ISpecification<T> second)
        {
            return new NotSpecification<T>(first, second);
        }
    }
}
