using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ourproject
{
    class Complaintfroms
    {
        private int numofcimplaint;
        private string description;
        private status status;
        private string inquirysummary;
        private Designer Designer;
        private Supplier Supplier;
        private operationdirector operationdirector;
        public Complaintfroms(int numofcimplaint, string description, status status, string inquirysummary,
            Designer Designer, Supplier Supplier, operationdirector operationdirector)
        {
            this.numofcimplaint = numofcimplaint;
            this.description = description;
            this.status = status;
            this.inquirysummary = inquirysummary;
            this.Designer = Designer;
            this.Supplier = Supplier;
            this.operationdirector = operationdirector;

        }
        public int getnumofcimplaint ()
        {
            return this.numofcimplaint;

        }
        public string getdescription()
        {
            return this.description;

        }
        public string getinquirysummary()
        {
            return this.inquirysummary;

        }
        public status getstatus()
        {
            return this.status;

        }
        public int getDesignerid()
        {
            return this.Designer.getID();

        }
        public int getSupplierid()
        {
            return this.Supplier.getid();

        }
    }

}
