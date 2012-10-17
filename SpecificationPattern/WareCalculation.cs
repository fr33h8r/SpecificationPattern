using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace SpecificationPattern
{
    public class WareCalculation
    {
        public int CountExpiredWares(List<Ware> wares)
        {
            return wares.FindAll(w => w.BestBefore < DateTime.Now.AddMonths(4)).Count;
        }
    }

    public class WareCalculationTests
    {
        [Fact]
        public void should_count_expired_wares()
        {
            var list = new List<Ware>
                           {
                               new Ware {BestBefore = DateTime.Now.AddMonths(6)},
                               new Ware(),
                               new Ware()
                           };
            var expiredWare = new WareCalculation().CountExpiredWares(list);
            expiredWare.Should().Be(2);
        }
    }
}