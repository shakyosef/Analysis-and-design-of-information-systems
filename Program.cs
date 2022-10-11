using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace ourproject
{
    static class Program
    {
        public static System.Collections.Generic.List<Supplier> Suppliers;
        public static System.Collections.Generic.List<operationdirector> operationdirectors;
        public static System.Collections.Generic.List<PatternMaking> patternMakings;
        public static System.Collections.Generic.List<Designer> Designers;
        public static System.Collections.Generic.List<Complaintfroms> Complaintfroms;
        public static System.Collections.Generic.List<Customerservicedirector> Customerservicedirectors;
        public static System.Collections.Generic.List<CustomerServiceClerck> CustomerServiceClercks;
        public static System.Collections.Generic.List<discount> discounts;
        public static System.Collections.Generic.List<compensationcomplaint> compensationcomplaints;
        public static System.Collections.Generic.List<Rate> rates;
        public static System.Collections.Generic.List<Complaint> Complaints;
        public static System.Collections.Generic.List<customer> customers;
      public static System.Collections.Generic.List<Financedirectors> financedirectorss;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            init_all();
        
           Application.Run(new Form2());
        }
        

        //קריאת טבלאות

        
        public static void init_operationdirector()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_operationDirector";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            operationdirectors = new List<operationdirector>();
            while (rdr.Read())
            {
                operationdirector od = new operationdirector(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), int.Parse(rdr.GetValue(2).ToString()), DateTime.Parse(rdr.GetValue(3).ToString()), rdr.GetValue(4).ToString(), Suppliers, Complaintfroms,false);
                operationdirectors.Add(od);
            }
        }
        public static void init_all()
        {
           init_patternMakings();
           init_operationdirector();
           init_suppliers();
           init_customers();
            init_customerServiceDirectors();
           
            init_ccustomerServiceClercks();
            init_designers();
            init_Complaints();
            init_compensationcomplaints();
            init_complaintForms();
            init_discounts();
            init_rates();




        }
        public static void init_suppliers()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_suplliers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Suppliers = new List<Supplier>();
            while (rdr.Read())
            {
                Supplier s = new Supplier(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), DateTime.Parse(rdr.GetValue(4).ToString()), seekoperationdirector(int.Parse(rdr.GetValue(5).ToString())), Designers, Complaintfroms);
                Suppliers.Add(s);
            }
        }
        public static void init_customers()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_customers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            customers = new List<customer>();
            while (rdr.Read())
            {
                customer cu = new customer(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), DateTime.Parse(rdr.GetValue(3).ToString()), rates, Complaints, discounts);
                customers.Add(cu);
            }
        }
        public static void init_customerServiceDirectors()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_customerServiceDirector";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Customerservicedirectors = new List<Customerservicedirector>();
            while (rdr.Read())
            {
                Customerservicedirector csd = new Customerservicedirector(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(),int.Parse(rdr.GetValue(2).ToString()), DateTime.Parse(rdr.GetValue(3).ToString()), rdr.GetValue(4).ToString(), CustomerServiceClercks, discounts, compensationcomplaints,false);
                Customerservicedirectors.Add(csd);
            }
        }
        public static void init_ccustomerServiceClercks()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_customerServiceClerck";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            CustomerServiceClercks = new List<CustomerServiceClerck>();
            while (rdr.Read())
            {
                CustomerServiceClerck csc = new CustomerServiceClerck(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(2).ToString(), int.Parse(rdr.GetValue(3).ToString()), DateTime.Parse(rdr.GetValue(4).ToString()), rdr.GetValue(5).ToString(), seekCustomerservicedirector(int.Parse(rdr.GetValue(1).ToString())), rates, Complaints,false);
                CustomerServiceClercks.Add(csc);
            }
        }

        public static void init_Complaints()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_complaints";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Complaints = new List<Complaint>();
            while (rdr.Read())
            {
                status s = (status)Enum.Parse(typeof(status), rdr.GetValue(5).ToString());
                Complaint com = new Complaint(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(),s,rdr.GetValue(2).ToString(),seekCustomer(int.Parse(rdr.GetValue(4).ToString())), seekCustomerServiceClerck(int.Parse(rdr.GetValue(3).ToString())));
                Complaints.Add(com);
            }
        }
        public static void init_designers()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_designers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Designers = new List<Designer>();
            while (rdr.Read())
            {
                Designer d = new Designer(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), int.Parse(rdr.GetValue(2).ToString()), DateTime.Parse(rdr.GetValue(3).ToString()), rdr.GetValue(4).ToString(), Suppliers, Complaintfroms,false);
                Designers.Add(d);
            }
            for (int i = 0; i < Designers.Count; i++)
            {
                //string messege = MessageBox.Show(Designers[i].getID());
                    Console.WriteLine(Designers[i].getID());
            }
        }

        public static void init_complaintForms()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_complaintForms";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Complaintfroms = new List<Complaintfroms>();
            while (rdr.Read())
            {
                status s = (status)Enum.Parse(typeof(status), rdr.GetValue(6).ToString());
                Complaintfroms cf = new Complaintfroms(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(),s, rdr.GetValue(2).ToString(), seekdesignerg(int.Parse(rdr.GetValue(5).ToString())), seekSupplier(int.Parse(rdr.GetValue(3).ToString())), seekoperationdirector(int.Parse(rdr.GetValue(4).ToString())));
                Complaintfroms.Add(cf);
            }
        }

        public static void init_compensationcomplaints()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_compensationComplaints";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            compensationcomplaints = new List<compensationcomplaint>();
            while (rdr.Read())
            {
                status s = (status)Enum.Parse(typeof(status), rdr.GetValue(6).ToString());
                status s2 = (status)Enum.Parse(typeof(status), rdr.GetValue(7).ToString());

                compensationcomplaint cc = new compensationcomplaint(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), s, rdr.GetValue(2).ToString(), s2, seekCustomerservicedirector(int.Parse(rdr.GetValue(3).ToString())), seekCustomer(int.Parse(rdr.GetValue(4).ToString())), seekCustomerServiceClerck(int.Parse(rdr.GetValue(5).ToString())));
                compensationcomplaints.Add(cc);
            }
        }
        public static void init_discounts()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_discounts";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            discounts = new List<discount>();
            while (rdr.Read())
            {
                discount dis = new discount(rdr.GetValue(0).ToString(), double.Parse(rdr.GetValue(1).ToString()), seekCustomerservicedirector(int.Parse(rdr.GetValue(2).ToString())), seekCustomer(int.Parse(rdr.GetValue(3).ToString())),false);
                discounts.Add(dis);
            }
        }

        public static void init_patternMakings()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_patternMakings";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            patternMakings = new List<PatternMaking>();
            while (rdr.Read())
            {
                PatternMaking pm = new PatternMaking(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), int.Parse(rdr.GetValue(2).ToString()), DateTime.Parse(rdr.GetValue(3).ToString()),rdr.GetValue(4).ToString());
                patternMakings.Add(pm);
            }
        }

        public static void init_serviceRates()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_serviceRate";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            rates = new List<Rate>();
            while (rdr.Read())
            {
                Rate r = new Rate(seekCustomer(int.Parse(rdr.GetValue(0).ToString())),DateTime.Parse(rdr.GetValue(1).ToString()), int.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(),seekCustomerServiceClerck(int.Parse(rdr.GetValue(4).ToString())));
                rates.Add(r);
            }
           
        }
        public static void init_finnanceDirectors()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_finnanceDirector";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            financedirectorss = new List<Financedirectors>();
            while (rdr.Read())
            {
                Financedirectors f = new Financedirectors(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), int.Parse(rdr.GetValue(2).ToString()),DateTime.Parse(rdr.GetValue(3).ToString()), rdr.GetValue(4).ToString());
                financedirectorss.Add(f);
            }
        }
        public static void init_rates()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_serviceRate";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            rates = new List<Rate>();
            while (rdr.Read())
            {
                Rate f = new Rate(seekCustomer( int.Parse(rdr.GetValue(0).ToString())), DateTime.Parse(rdr.GetValue(1).ToString()), int.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(),seekCustomerServiceClerck(int.Parse(rdr.GetValue(4).ToString())));
                rates.Add(f);
            }
        }






        //חיפושי אובייקטים
        public static Supplier seekSupplier(int id)
    {
        foreach (Supplier s in Suppliers)
        {
            if (s.getid() == id)
                return s;
        }
        return null;
    }
        public static customer seekCustomer(int id)
        {
            foreach (customer c in customers)
            {
                if (c.getId() == id)
                    return c;
            }
            return null;
        }

        public static PatternMaking seekPatternMaking(int id)
        {
            foreach (PatternMaking p in patternMakings)
            {
                if (p.getID() == id)
                    return p;
            }
            return null;
        }
        public static Designer seekdesignerg(int id)
        {
            foreach (Designer d in Designers)
            {
                if (d.getID() == id)
                    return d;
            }
            return null;
        }
        public static CustomerServiceClerck seekCustomerServiceClerck(int id)
        {
            foreach (CustomerServiceClerck c in CustomerServiceClercks)
            {
                if (c.getID() == id)
                    return c;
            }
            return null;
        }
        public static Customerservicedirector seekCustomerservicedirector(int id)
        {
            foreach (Customerservicedirector cd in Customerservicedirectors)
            {
                if (cd.getID() == id)
                    return cd;
            }
            return null;
        }
        public static Financedirectors seekFinancedirectors(int id)
        {
            foreach (Financedirectors f in financedirectorss)
            {
                if (f.getID() == id)
                    return f;
            }
            return null;
        }
        public static operationdirector seekoperationdirector(int id)
        {
            foreach (operationdirector o in operationdirectors)
            {
                if (o.getID() == id && (o.getemail().Equals("noamcohen@gmail.com")))
                    return o;
            }
            return null;
        }
        public static operationdirector operationdirectorMaill(operationdirector m)
        {
            foreach (operationdirector o in operationdirectors)
            {
                if (o.getemail().Equals(m.getemail()))
                    return m;
            }
            return null;
        }
        public static Complaintfroms seeComplaintfroms(int numofcimplaint)
        {
            foreach (Complaintfroms o in Complaintfroms)
            {
                if (o.getnumofcimplaint() == numofcimplaint)
                    return o;
            }
            return null;
        }

        public static compensationcomplaint seecompensationcomplaint(int complaintNum)
        {
            foreach (compensationcomplaint o in compensationcomplaints)
            {
                if (o.getcomplaintNum() == complaintNum)
                    return o;
            }
            return null;
        }

        

    }
    // שיירררררר

    
}

