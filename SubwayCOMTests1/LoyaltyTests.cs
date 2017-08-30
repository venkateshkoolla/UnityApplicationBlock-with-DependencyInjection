using Xunit;
using UnityApplicationBlock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace UnityApplicationBlock.Tests
{
    public class LoyaltyTests
    {
        private UnityContainer _ioc = null;
        private ILoyalty _loyalty;


        public LoyaltyTests()
        {
            _ioc = new UnityContainer();
            _ioc.RegisterType<ILoyalty, Loyalty>();
            _loyalty = _ioc.Resolve<ILoyalty>();
            _loyalty.Id = 1245;
        }

        [Fact()]
        public void ProcessRewardsTest()
        {
            var certificates = _loyalty.GetRewards(124);
            Assert.Equal(1, certificates.Count);
        }

        [Fact()]
        public void VoidRewardsTest()
        {
            Assert.True(false, "This test needs an implementation");
        }
    }

}