using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace SpecificationPattern
{
    public class Ware
    {
        public string Articul { get; set; }
        public string Name { get; set; }
        public DateTime ProduceDate { get; set; }
        public DateTime BestBefore { get; set; }
    }

    public abstract class Specification<T>
    {
        public abstract bool IsSatisfiedBy(T item);
    }
}
