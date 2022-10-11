using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ourproject
{
    class compensationcomplaint : Complaint
    {
       
      private status statusDirector;
        private Customerservicedirector Customerservicedirector;
        public compensationcomplaint(int complaintnum, string complaint, status status, string inquirySummery,  status status1, Customerservicedirector Customerservicedirector, customer customer, CustomerServiceClerck CustomerServiceClerck)
           : base(complaintnum,complaint,status,inquirySummery,  customer ,  CustomerServiceClerck)
            {
            this.statusDirector = status1;
            this.Customerservicedirector = Customerservicedirector;
                
            }
        public Customerservicedirector getCustomerservicedirector()
        {
            return this.Customerservicedirector;
        }

        public void setstatusDirector(status status)
        {
            this.statusDirector = status;
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_setStatus  @complaintnum, @statusDirector";
            c.Parameters.AddWithValue("@complaintnum", base.complaintNum);
            c.Parameters.AddWithValue("@statusDirector", this.statusDirector);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public status getstatusDirector()
        {
            return this.statusDirector;
        }
    }
  
}