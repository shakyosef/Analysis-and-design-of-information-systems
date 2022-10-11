using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ourproject
{
    class Supplier
    {
       private int id;
        private string name;
        private DateTime joindate;
        private string email;
        private DateTime contractenddate;
        private operationdirector operationdirector;
        private List<Designer> Designerlist;
        private List<Complaintfroms> Complaintfromslist;
      

        public Supplier(int id, string name, DateTime joindate, string email, DateTime contractenddate, operationdirector operationdirector, List<Designer> Designerlist,  List<Complaintfroms> Complaintfromslist)
        {
            this.id = id;
            this.name = name;
            this.joindate = joindate;
            this.email = email;
            this.contractenddate = contractenddate;
            this.operationdirector = operationdirector; 
            this.Designerlist=Designerlist;
            this.Complaintfromslist = Complaintfromslist;
         

    }

        public string getname()
        {
            return this.name;
        }
        public int getid()
        {
            return this.id;
        }

        public DateTime getcontractenddate()
        {
            return this.contractenddate;

        }
        public string getEmail()
        {
            return this.email;
        }
        public DateTime getJoinDate()
        {
            return this.joindate;
        }
        public override string ToString()
        {
            return this.getcontractenddate() + " " + this.getEmail() + " " + this.getJoinDate() + "  " + this.getid() + " " + this.getname();

            // return this.getname() + " " + this.getid() + " " + this.getJoinDate();
        }

    }
}
