using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ourproject
{
    class discount
    {
        private string code;
        private double percentage;
        private Customerservicedirector Customerservicedirector;
        private customer customer;
        private bool new1;

        public discount(string code, double percentage, Customerservicedirector Customerservicedirector, customer customer1, bool new1)
        {
            this.new1 = new1;
            if (!new1)
            {
                this.code = code;
                this.percentage = percentage;
                this.Customerservicedirector = Customerservicedirector;
                this.customer = customer1;
            }
            else
            {
                this.code = code;
                this.percentage = percentage;
                this.Customerservicedirector = Customerservicedirector;
                this.customer = customer1;
                SqlCommand c = new SqlCommand();
                c.CommandText = "EXECUTE dbo.SP_add_discount @code, @percentage, @customerServiceDirector,@customerID";
                c.Parameters.AddWithValue("@code", code);
                c.Parameters.AddWithValue("@percentage", percentage);
                c.Parameters.AddWithValue("@customerServiceDirector", Customerservicedirector.getID());
                c.Parameters.AddWithValue("@customerID", customer.getId());
                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(c);
                customer1.setdiscountlist(this);
                Program.discounts.Add(this);
            }
    }
        public string getcode()
        {
            return this.code;
        }

        public double getpercentage()
        {
            return this.percentage;
        }

        public Customerservicedirector getCustomerservicedirector()
        {
            return this.Customerservicedirector;
        }
        public customer getcustomer()
        {
            return this.customer; 
        }
    }
}
