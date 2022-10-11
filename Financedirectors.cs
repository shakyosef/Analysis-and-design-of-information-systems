using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ourproject
{
    class Financedirectors
    {
        private int id;
        private string name;
        private int expirience;
        private DateTime birthdate;
        private string email;
       
        public Financedirectors(int id, string name, int expirience, DateTime birthdate, string email)
         
        {
            this.id = id;
            this.name = name;
            this.expirience = expirience;
            this.birthdate = birthdate;
            this.email = email;
        
         }
        public void update_Financedirectors()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Financedirectors  @id, @name, @expirence,@birthdate,@email";
            c.Parameters.AddWithValue("@id", this.id);
            c.Parameters.AddWithValue("@name", this.name);
            c.Parameters.AddWithValue("@expirence", this.expirience);
            c.Parameters.AddWithValue("@birthdate", this.birthdate);
            c.Parameters.AddWithValue("@email", this.email);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void Delete_Designer()
        {
            Program.financedirectorss.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_delete_Financedirectors @id";
            c.Parameters.AddWithValue("@id", this.id);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void create_Financedirectors()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_Financedirectors @id, @name, @expirence,@birthdate,@email";
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
