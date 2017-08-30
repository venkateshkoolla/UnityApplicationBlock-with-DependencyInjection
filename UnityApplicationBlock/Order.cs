using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityApplicationBlock
{
    public class Order
    {
        ILoyalty _loyalty;
        readonly int _guestId = 12345;

        public Order(ILoyalty loyalty)
        {
            this._loyalty = loyalty;
        }

        public Order()
        {

        }

        public List<Certificate> GetRewards()
        {
            return (List<Certificate>)_loyalty.GetRewards(_guestId);
        }

        public void ProcessRewards()
        {

        }
    }

    //public class OrderDerived : Order
    //{
    //   public OrderDerived():base
    //    {

    //    }
    //}

    //public partial class Order
    //{
    //    public List<Certificate> GetRewards1()
    //    {
    //        return (List<Certificate>)_loyalty.GetRewards(_guestId);
    //    }
    //}

    //public  class Ordertest:Order
    //{
    //    private Order o = new Order();
    //    private static ILoyalty loyalty;
    //    public Ordertest():base(loyalty)
    //    {
    //        o.GetRewards1();
    //    }

    //    public  void testc()
    //    {
    //     //Do logif   
    //    }

    //}

    //public class OrderFurther: Ordertest
    //{
    //    public  void testc()
    //    {
    //        //Do logif   
    //    }
    //}
}
