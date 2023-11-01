using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_27
{
    class Visit
    {
        private Customer customer;
       // private DateTime date;
        private double serviceExpense;
        private double productExpense;
        public Visit(string name)
        {
            customer = new Customer(name);
            //this.date = date;
        }
        public string getName()
        {
            return customer.getName();
        }
        public double getServiceExpense()
        {
            return serviceExpense;
        }
        public void setServiceExpense(double ex)
        {
            serviceExpense = ex;
        }
        public double getProductExpense()
        {
            return productExpense;
        }
        public void setProductExpense(double ex)
        {
            productExpense = ex;
        }
        public double getTotalExpense()
        {
            return (productExpense + serviceExpense);
        }
        public string toString()
        {
            customer.toString();
            return "Hello, I am on Visit class";
        }
    }
}
