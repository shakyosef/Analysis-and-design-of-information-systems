
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ourproject
{
    class CustomerServiceClerck 
    {
        
        private int id;
        private string name;
        private int expirience;
        private DateTime birthdate;
        private string email;
        private Customerservicedirector Customerservicedirector;
        private List<Rate> ratelist;
        private List<Complaint> Complaintlist;
        private bool  neww;

        public CustomerServiceClerck(int id1, string name1, int expirience1, DateTime birthdate1, string email1, Customerservicedirector Customerservicedirector, List<Rate> ratelist
           , List<Complaint> Complaintlist, bool neww1)
        {
           
                this.id = id1;
                this.name = name1;
                this.expirience = expirience1;
                this.birthdate = birthdate1;
                this.email = email1;
                this.Customerservicedirector = Customerservicedirector;
                this.ratelist = ratelist;
                this.Complaintlist = Complaintlist;
            this.neww = neww1;
            if (neww1)
            {
                SqlCommand c = new SqlCommand();
                c.CommandText = "EXECUTE SP_add_customerServiceClerck  @id, @manager,@name, @expirence,@birthdate,@email,@rate";
                c.Parameters.AddWithValue("@id", id1);
                c.Parameters.AddWithValue("@manager", Customerservicedirector.getID());
                c.Parameters.AddWithValue("@name", name1);
                c.Parameters.AddWithValue("@expirence", expirience1);
                c.Parameters.AddWithValue("@birthdate", birthdate1);
                c.Parameters.AddWithValue("@email", email1);
                c.Parameters.AddWithValue("@rate", 0);
                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(c);
                Program.CustomerServiceClercks.Add(this);
                  }


    }
        public CustomerServiceClerck(int id, string name, int expirience, DateTime birthdate, string email)
        {
            this.id = id;
            this.name = name;
            this.expirience = expirience;
            this.birthdate = birthdate;
            this.email = email;

        }
        public void setComplaintlist(List<Complaint> Complaintlist)
        {
            this.Complaintlist = Complaintlist;
        }
        public void update_CustomerServiceClerck(int id1, string name1, int experience1, DateTime birthdate1, string email1)
        {

            this.id = id1;
            this.name = name1;
            this.expirience = experience1;
            this.birthdate = birthdate1;
            this.email = email1;
         
            
            double sum = 0;
            int x = 0;
            foreach(Rate r in ratelist)
            {
                sum = sum + r.getrate();
                x++;
            }
           
            sum = sum / x;
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_customerServiceClerck  @id, @manager,@name, @expirence,@birthdate,@email,@rate";
            c.Parameters.AddWithValue("@id", id1);
            c.Parameters.AddWithValue("@manager", this.Customerservicedirector.getID());
            c.Parameters.AddWithValue("@name", name1);
            c.Parameters.AddWithValue("@expirence", experience1);
            c.Parameters.AddWithValue("@birthdate", birthdate1);
            c.Parameters.AddWithValue("@email", email1);
            c.Parameters.AddWithValue("@rate", sum);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void Delete_CustomerServiceClerck()
        {
            Program.CustomerServiceClercks.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_delete_customerServiceClercks @id";
            c.Parameters.AddWithValue("@id", this.id);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void create_CustomerServiceClerck()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_customerServiceClerck  @id, @manager,@name, @expirence,@birthdate,@email,@rate";
            c.Parameters.AddWithValue("@id", this.id);
            c.Parameters.AddWithValue("@manager", this.Customerservicedirector.getID());
            c.Parameters.AddWithValue("@name", this.name);
            c.Parameters.AddWithValue("@expirence", this.expirience);
            c.Parameters.AddWithValue("@birthdate", this.birthdate);
            c.Parameters.AddWithValue("@email", this.email);
            c.Parameters.AddWithValue("@rate", 0);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public int getID()
        {
            return this.id;
        }
        public string getname()
        {
            return this.name;
        }
        public int getexpirience()
        {
            return this.expirience;
        }
        public DateTime getbirthdate()
        {
            return this.birthdate;
        }
        public string getemail()
        {
            return this.email;
        }
        public void setname(string name)
        {
            this.name = name;
        }
        public void setexpirience(int e)
        {
            this.expirience = e;
        }
        public void setbirthdate(DateTime b)
        {
            this.birthdate = b;
        }
        public void setemail(string email)
        {
            this.email = email;
        }
    }
}
