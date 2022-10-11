using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ourproject
{
    class Rate
    {
        private DateTime RateTime;
        private string review;
        private int rate;
        private CustomerServiceClerck CustomerServiceClerck;
        private customer customer;
        public Rate( customer customer, DateTime RateTime, int rate,  string review,  CustomerServiceClerck CustomerServiceClerck)
        {
            
            this.review = review;
            this.RateTime = RateTime;
            this.rate = rate;
            this.CustomerServiceClerck = CustomerServiceClerck;
            this.customer = customer;

        }
        public int getcustomerid()
        {
            return this.customer.getId();
        }
        public int getrate()
        {
            return this.rate;
        }
        public int getCustomerServiceClerckid()
        {
            return this.CustomerServiceClerck.getID();
        }
        public DateTime getRateTime()
        {
            return this.RateTime;
        }
    }
}
