using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace библиотека14pr
{
    public abstract class contact
    {
        private string name;
        private string telephone;
        private string address;
        private string type;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Telephone
        {
            get
            {
                return telephone;
            }
            set
            {
                telephone = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        public contact(string name, string telephone, string address, string type)
        {
            this.name = name;
            this.telephone = telephone;
            this.address = address;
            this.type = type;
        }
        public abstract string Info();
    }
}
