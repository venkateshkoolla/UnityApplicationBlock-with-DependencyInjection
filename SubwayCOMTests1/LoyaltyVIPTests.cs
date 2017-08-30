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
    public class LoyaltyVIPTests
    {

        private UnityContainer _ioc = null;
        private ILoyalty _loyalty= new LoyaltyVIP();

        public LoyaltyVIPTests()
        {
            UnityContainer container= new UnityContainer();
            container.RegisterType<ILoyalty, Loyalty>();
            container.RegisterType<ILoyalty, LoyaltyVIP>();
            _loyalty= container.Resolve<ILoyalty>();
        }

        [Fact()]
        public void GetRewardsTest()
        {
           var certificates= _loyalty.GetRewards(12345);
            Assert.Equal(2,certificates.Count);
        }

        [Fact()]
        public void ProcessRewardsTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void VoidRewardsTest()
        {
            Assert.True(false, "This test needs an implementation");
        }
    }
}