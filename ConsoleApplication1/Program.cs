using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using UnityApplicationBlock;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ioc = new UnityContainer();

            ioc.RegisterType<ILoyalty, Loyalty>();
            ILoyalty loyaltyService = ioc.Resolve<ILoyalty>();
            var order = new Order(loyaltyService);

            //ILoyalty loyalty= new Loyalty();
            //var order = new Order(loyalty);

            Console.WriteLine(order.GetRewards().Count);
            //Console.WriteLine(order.GetRewards().Count);
        }
    }
}
