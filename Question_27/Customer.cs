using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_27
{
    class Customer
    {
        private string name;
        private Boolean member=false;
        private string memberType;
        public Customer(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public Boolean isMember()
        {
            return member;
        }
        public void setMember(Boolean member)
        {
            this.member = member;
        }
        public String getMemberType()
        {
            return memberType;
        }
        public void setMemberType(String type)
        {
            memberType = type;
        }
        public string toString()
        {
            return "Hello, I am on Customer class.";
        }

    }
}
