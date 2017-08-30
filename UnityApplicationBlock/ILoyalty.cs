using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityApplicationBlock
{
    public interface ILoyalty
    {
        int Id { get; set; }
        IList<Certificate> GetRewards(int guestId);
        void ProcessRewards(Cart cart);
        void VoidRewards(Cart cart);
    }
    
}
