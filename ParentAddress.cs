using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectUnAbandon
{
    public class ParentAddress
    {
        private string addressStreet;
        private string addressCity;
        private string addressState;
        private int addressZipCode;

        public ParentAddress(string street, string city, string state, int zipCode)
        {
            AddressStreet = street;
            AddressCity = city;
            AddressState = state;
            AddressZipCode = zipCode;
        }

        public string AddressStreet
        {
            get { return addressStreet; }
            set { addressStreet = value; }
        }
        public string AddressCity
        {
            get { return addressCity; }
            set { addressCity = value; }
        }
        public string AddressState
        {
            get { return addressState; }
            set { addressState = value; }
        }
        public int AddressZipCode
        {
            get { return addressZipCode; }
            set { addressZipCode = value; }
        }
    }
}
