using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ourproject
{
    class Designer
    {
        private int id;
        private string name;
        private int expirience;
        private DateTime birthdate;
        private string email;
        private List<Supplier> Supplierlist;
        private List<Complaintfroms> Complaintfromslist;
        private bool neww;

       public Designer(int id1, string name1, int expirience1, DateTime birthdate1, string email1, List<Supplier> Supplierlist1, List<Complaintfroms> Complaintfromslist1, bool neww1)
       
        {
            this.id = id1;
            this.name = name1;
            this.expirience = expirience1;
            this.birthdate = birthdate1;
            this.email = email1;
            this. Supplierlist= Supplierlist1;
            this.Complaintfromslist = Complaintfromslist1;
            this.neww = neww1;
            if (neww1)
            {
                SqlCommand c = new SqlCommand();
                c.CommandText = "EXECUTE SP_add_designers @id, @name, @expirence,@birthdate,@email";
                c.Parameters.AddWithValue("@id", id1);
                c.Parameters.AddWithValue("@name", name1);
                c.Parameters.AddWithValue("@expirence", expirience1);
                c.Parameters.AddWithValue("@birthdate", birthdate1);
                c.Parameters.AddWithValue("@email", email1);
                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(c);
                Program.Designers.Add(this);
            }


        }
        public Designer(int id, string name, int expirience, DateTime birthdate, string email)

        {
            this.id = id;
            this.name = name;
            this.expirience = expirience;
            this.birthdate = birthdate;
            this.email = email;
        }
        public void setSupplierlist(List<Supplier> Supplierlist)
        {
            this.Supplierlist = Supplierlist;
        }
        public void setComplaintfromslist(List<Complaintfroms> Complaintfromslist)
        {
            this.Complaintfromslist = Complaintfromslist;
        }
        public void update_Designer(int id1, string name1, int experience1, DateTime birthdate1, string email1)
        {
            this.id = id1;
            this.name = name1;
            this.expirience = experience1;
            this.birthdate = birthdate1;
            this.email = email1;
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_designers  @id, @name, @expirence,@birthdate,@email";
            c.Parameters.AddWithValue("@id", id1);
            c.Parameters.AddWithValue("@name", name1);
            c.Parameters.AddWithValue("@expirence", experience1);
            c.Parameters.AddWithValue("@birthdate",birthdate1);
            c.Parameters.AddWithValue("@email", email1);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void Delete_Designer()
        {
            Program.Designers.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_delete_designers @id";
            c.Parameters.AddWithValue("@id", this.id);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void create_Designer()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_designers @id, @name, @expirence,@birthdate,@email";
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
