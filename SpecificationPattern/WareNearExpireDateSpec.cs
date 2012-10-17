using System;
using FluentAssertions;
using Xunit;

namespace SpecificationPattern
{
    public class WareNearExpireDateSpec : Specification<Ware>
    {
        public override bool IsSatisfiedBy(Ware item)
        {
            return item.BestBefore < DateTime.Now.AddMonths(4);
        }
    }

    public class WareNearExpireDateSpecificationTests
    {
        [Fact]
        public void should_test_satisfying(DateTime expected)
        {
            var spec = new WareNearExpireDateSpec().IsSatisfiedBy(new Ware {BestBefore = DateTime.Now});
            spec.Should().BeTrue();
            //spec = new WareNearExpireDateSpec().IsSatisfiedBy(new Ware {BestBefore = DateTime.Now.AddMonths(10)});
            //spec.Should().BeFalse();
            //spec = new WareNearExpireDateSpec().IsSatisfiedBy(new Ware { BestBefore = DateTime.Now.AddMonths(-10) });
            //spec.Should().BeFalse();
        }
    }
}