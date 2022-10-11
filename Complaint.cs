using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ourproject
{
    class Complaint
    {
       protected int complaintNum;
        private string complaint;
        private status status;
        private string inquirySummery;
        private CustomerServiceClerck CustomerServiceClerck;
        private customer customer;

        public Complaint (int complaintNum,string complaint, status status, string inquirySummery, customer customer, CustomerServiceClerck CustomerServiceClerck)
        {
            this.complaintNum = complaintNum;
            this.complaint = complaint;
            this.status = status;
            this.inquirySummery = inquirySummery;
            this.customer = customer;
            this.CustomerServiceClerck = CustomerServiceClerck;
        }

       public int getcomplaintNum()
        {
            return this.complaintNum;
        }
        public customer getcustomer()
        {
            return this.customer;
        }
        public string getinquirySummery()
        {
            return this.inquirySummery;
        }
        public string getcomplaint()
        {
            return this.complaint;
        }

    }
}
