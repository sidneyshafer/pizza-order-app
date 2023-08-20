using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class Customer
    {
        private string Phone;
        private string Name;
        private string Addr1;
        private string Addr2;
        private string City;
        private string State;
        private string Zip;

        public Customer() { }

        public Customer(string Phone, string Name, string Addr1, string Addr2, string City, string State, string Zip)
        {
            custPhone = Phone;
            custName = Name;
            custAddr1 = Addr1;
            custAddr2 = Addr2;
            custCity = City;
            custState = State;
            custZip = Zip;
        }

        public string custPhone
        {
            get { return Phone; }
            set
            {
                if (value.Length > 9)
                    Phone = value;
                else
                    Phone = "0000000000";
            }
        }

        public string custName
        {
            get { return Name; }
            set { Name = value; }
        }

        public string custAddr1
        {
            get { return Addr1; }
            set { Addr1 = value; }
        }

        public string custAddr2
        {
            get { return Addr2; }
            set 
            {
                if (value.Length > 5)
                    Addr2 = value;
                else
                    Addr2 = "N/A";
            }
        }

        public string custCity
        {
            get { return City; }
            set { City = value; }
        }

        public string custState
        {
            get { return State; }
            set { State = value; }
        }

        public string custZip
        {
            get { return Zip; }
            set { Zip = value; }
        }

        public string Display()
        {
            return Phone + "\n" + Name + "\n" + Addr1 + "\n" + Addr2 + "\n" + State + "\n" + Zip + "\n" ;
        }
    }
}
