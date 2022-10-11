using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ourproject
{
    class Customerservicedirector
    {
        private int id;
        private string name;
        private int expirience;
        private DateTime birthdate;
        private string email;
        private List<CustomerServiceClerck> CustomerServiceClercklist;
        private List <discount> discountlist;
        private List<compensationcomplaint> compensationcomplaintlist;
        private bool neww;
        public Customerservicedirector(int id1, string name1, int expirience1, DateTime birthdate1, string email1, List<CustomerServiceClerck> CustomerServiceClercklist,
            List<discount> discountlist, List<compensationcomplaint> compensationcomplaintlist, bool neww1)
          
             
        {
            this.id = id1;
            this.name = name1;
            this.expirience = expirience1;
            this.birthdate = birthdate1;
            this.email = email1;
            this.CustomerServiceClercklist = CustomerServiceClercklist;
            this.discountlist = discountlist;
            this.compensationcomplaintlist = compensationcomplaintlist;
            this.neww = neww1;
            if (neww1)
            {
                SqlCommand c = new SqlCommand();
                c.CommandText = "EXECUTE SP_add_customerServiceDirectors @id, @name, @expirence,@birthdate,@email";
                c.Parameters.AddWithValue("@id", id1);
                c.Parameters.AddWithValue("@name", name1);
                c.Parameters.AddWithValue("@expirence", expirience1);
                c.Parameters.AddWithValue("@birthdate", birthdate1);
                c.Parameters.AddWithValue("@email", email1);
                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(c);

                Program.Customerservicedirectors.Add(this);
            }

        }

        public void setcompensationcomplaintlist(List<compensationcomplaint> compensationcomplaintlist)
        {
            this.compensationcomplaintlist = compensationcomplaintlist;
        }
        public void setdiscountlist(List<discount> discountlist)
        {
            this.discountlist = discountlist;
        }
        public void setCustomerServiceClercklist(List<CustomerServiceClerck> CustomerServiceClercklist)
        {
            this.CustomerServiceClercklist = CustomerServiceClercklist;
        }


        public void update_Customerservicedirector(int id1, string name1, int experience1, DateTime birthdate1, string email1)
        {
            this.id = id1;
            this.name = name1;
            this.expirience = experience1;
            this.birthdate = birthdate1;
            this.email = email1;
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_customerServiceDirector  @id, @name, @expirence,@birthdate,@email";
            c.Parameters.AddWithValue("@id", id1);
            c.Parameters.AddWithValue("@name", name1);
            c.Parameters.AddWithValue("@expirence", experience1);
            c.Parameters.AddWithValue("@birthdate", birthdate1);
            c.Parameters.AddWithValue("@email", email1);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void Delete_Customerservicedirector()
        {
            Program.Customerservicedirectors.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_delete_customerServiceDirectors @id";
            c.Parameters.AddWithValue("@id", this.id);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void create_Customerservicedirectork()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_customerServiceDirectors @id, @name, @expirence,@birthdate,@email";
            c.Parameters.AddWithValue("@id", this.id);
            c.Parameters.AddWithValue("@name", this.name);
            c.Parameters.AddWithValue("@expirence", this.expirience);
            c.Parameters.AddWithValue("@birthdate", this.birthdate);
            c.Parameters.AddWithValue("@email", this.email);
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
