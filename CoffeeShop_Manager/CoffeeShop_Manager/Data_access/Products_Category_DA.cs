using CoffeeShop_Manager.Data_transfer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop_Manager.Data_access
{
    public class Products_Category_DA
    {
        private static Products_Category_DA instance;

        public static Products_Category_DA Instance
        {
            get { if (instance == null) instance = new Products_Category_DA(); return Products_Category_DA.instance; }
            private set { Products_Category_DA.instance = value; }
        }

        private Products_Category_DA() { }

        public List<Products_Category> Get_List_Products_Category()
        {
            List<Products_Category> list = new List<Products_Category>();

            string query = "select * from Products_Category";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Products_Category category = new Products_Category(item);
                list.Add(category);
            }

            return list;
        }

        public Products_Category GetCategoryByID(int id)
        {
            Products_Category category = null;

            string query = "select * from Products_Category where Id_Products_Category = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new Products_Category(item);
                return category;
            }

            return category;
        }
    }
}
