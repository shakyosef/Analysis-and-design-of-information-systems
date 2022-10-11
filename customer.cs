using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ourproject
{
    class customer
    {
        private int ID;
        private string name;
        private string Email;
        private DateTime joinDate;
       private List<discount> discountlist ;
      
        private List<Rate> ratelist;
 
      
        private List<Complaint> Complaintlist;
   
        public customer(int id,string name, string email, DateTime joinDate
          , List<Rate> ratelist,    List<Complaint> Complaintlist, List<discount> discountlist)
        {
            this.ID = id;
            this.name = name;
            this.Email = email;
            this.joinDate = joinDate;
            this.discountlist = discountlist;
            this.ratelist = ratelist;
            this.Complaintlist = Complaintlist;
            if (this.discountlist == null)
            {
                this.discountlist = new List<discount>();
            }

            }
        public void setratelist(List<Rate> ratelist)
        {
            this.ratelist = ratelist;
        }
        public void setComplaintlist(List<Complaint> Complaintlist)
        {
            this.Complaintlist = Complaintlist;
        }
        public void setdiscountlist(discount discount)
        {
            this.discountlist.Add( discount);
        }
        public int getId()
        {
            return ID;
        }
        public string getname()
        {
            return this.name;
        }
        public string getEmail()
        {
            return this.Email;
        }
         
        public void setdiscount(discount d)
        {
            this.discountlist.Add(d);


       
        }
             
    }
}
