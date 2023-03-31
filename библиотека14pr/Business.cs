using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace библиотека14pr
{
    public class Business:contact
    {
        private string organization;
        private string post;
        private DateTime datalast = new DateTime();
        public string Organization
        {
            get
            {
                return organization;
            }
            set
            {
                organization = value;
            }
        }
        public string Post
        {
            get
            {
                return post;
            }
            set
            {
                post = value;
            }
        }
        public DateTime Datalast
        {
            get
            {
                return datalast;
            }
            set
            {
                datalast = value;
            }
        }
        public Business(string name, string telephone, string address, string type, string organization, string post, DateTime datalast) : base(name, telephone, address, type )
        {
            this.datalast = datalast;
            this.organization = organization;
            this.post = post;
        }
        public override string Info()
        {
            return $"{Name}\n{Telephone}\n{Address}\n{Type}\n{datalast.ToShortDateString()}\n{organization}\n{post}";
        }
    }
}
