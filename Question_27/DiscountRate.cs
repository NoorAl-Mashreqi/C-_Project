using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_27
{
    class DiscountRate
    {
        private double serviceDiscountPremium = 0.2;
        private double serviceDiscountGold = 0.15;
        private double serviceDiscountSilver = 0.1;
        private double productDiscountPremium=0.1;
        private double productDiscountGold=0.1;
        private double productDiscountSilver=0.1;
        public double getServiceDiscountRate(string type)
        {
            return serviceDiscountPremium * serviceDiscountGold * serviceDiscountSilver;
        }
        public double getProductDiscountRate(string type)
        {
            return productDiscountPremium * productDiscountGold * productDiscountSilver;
        }
    }
}
