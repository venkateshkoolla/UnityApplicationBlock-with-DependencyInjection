using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnapLogicAPI;

namespace UnityApplicationBlock
{
    public class Loyalty : ILoyalty
    {

        IList<Certificate> ILoyalty.GetRewards(int guestId)
        {
            SnapLogicAPI.Class1 obj = new Class1();
            var certificates = obj.GuestLookup(guestId);

            IList<Certificate> certs = null;
            foreach (var _certificate in certificates)
            {
                if (certs == null)
                {
                    certs = new List<Certificate>();
                }
                var certificate = new Certificate {Id = _certificate.Id};
                certs.Add(certificate);
            }
            return certs;
        }

        public void ProcessRewards(Cart cart)
        {
            throw new NotImplementedException();
        }

        public void VoidRewards(Cart cart)
        {
            throw new NotImplementedException();
        }

        public int Id { get; set; }
    }

    public class LoyaltyVIP:ILoyalty
    {
        public int Id { get; set; }
        public IList<Certificate> GetRewards(int guestId)
        {
            // Call Snaplogic
            var obj = new Class1();
            var certificates = obj.GetRewards(guestId);

            var lstCertificates= new List<Certificate>();
            var cert=new Certificate();

            foreach (var certificate in certificates)
            {
                cert.Id = certificate.Id;
                lstCertificates.Add(cert);
            }
            return lstCertificates;
        }

        public void ProcessRewards(Cart cart)
        {
            throw new NotImplementedException();
        }

        public void VoidRewards(Cart cart)
        {
            throw new NotImplementedException();
        }
    }
}
