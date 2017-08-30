using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapLogicAPI
{
    public class Class1
    {
        public List<Certificate> GuestLookup(int guestId)
        {
            return new List<Certificate>() { new Certificate() { Id = 1234 } };
        }

        public List<Certificate> GetRewards(int guestId)
        {
            //var cert = new Certificate { Id = 1 };
            //var cert1Certificate = new Certificate { Id = 2 };

            return new List<Certificate>() { new Certificate() { Id = 1 }, new Certificate() { Id = 2 } };
          
        }

       
    }
}
