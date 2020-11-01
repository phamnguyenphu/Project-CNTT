using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop_Manager.Data_transfer
{
    public class Products_Category
    {
        public Products_Category(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public Products_Category(DataRow row)
        {
            this.ID = (int)row["Id_Products_Category"];
            this.Name = row["Name_Products_Category"].ToString();
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
