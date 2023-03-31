using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace библиотека14pr
{
    public class PersonalContacts:contact
    {
        private DateTime date = new DateTime();
        private string congratulation;
        private string relation;
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public string Congratulation
        {
            get
            {
                return congratulation;
            }
            set
            {
                congratulation = value;
            }
        }
        public string Relation
        {
            get
            {
                return relation;
            }
            set
            {
                relation = value;
            }
        }
        public PersonalContacts(string name, string telephone, string address, string type, DateTime date, string congratulation, string relation) : base(name, telephone, address, type)
        {
            this.date = date;
            this.congratulation = congratulation;
            this.relation = relation;
        }
        public override string Info()
        {
            return Name + "\n" + Telephone + "\n" + Address + "\n" + Type + "\n"+ date.ToShortDateString() + "\n"+ congratulation+"\n"+ relation;
        }
    }
}
