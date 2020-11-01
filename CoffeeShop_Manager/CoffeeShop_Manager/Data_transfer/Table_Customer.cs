using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop_Manager.Data_transfer
{
    public class Table_Customer
    {
        public Table_Customer(int id, string name, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }

        public Table_Customer(DataRow row)
        {
            this.ID = (int)row["Id_Table"];
            this.Name = row["Name_Table"].ToString();
            this.Status = row["Status_Table"].ToString();
        }

        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
