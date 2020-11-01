using CoffeeShop_Manager.Data_transfer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop_Manager.Data_access
{
    public class Products_DA
    {
        private static Products_DA instance;

        public static Products_DA Instance
        {
            get { if (instance == null) instance = new Products_DA(); return Products_DA.instance; }
            private set { Products_DA.instance = value; }
        }

        private Products_DA() { }

        public List<Products> Get_Products_By_CategoryID(int id)
        {
            List<Products> list = new List<Products>();

            string query = "select * from Products where Id_Products_Category = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Products products = new Products(item);
                list.Add(products);
            }

            return list;
        }

        public List<Products> Get_List_Products()
        {
            List<Products> list = new List<Products>();

            string query = "select * from Products";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Products products = new Products(item);
                list.Add(products);
            }

            return list;
        }

        
        // Hàm thêm sản phẩm vào database
        public bool Insert_Products(string name, int id, float price)
        {
            string query = string.Format("INSERT dbo.Products ( Name_Products, Id_Products_Category, Products_price )VALUES  ( N'{0}', {1}, {2})", name, id, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        // Hàm sửa sản phẩm vào database
        public bool Update_Products(int idFood, string name, int id, float price)
        {
            string query = string.Format("UPDATE dbo.Products SET Name_Products = N'{0}', Id_Products_Category = {1}, Products_price = {2} WHERE Id_Products = {3}", name, id, price, idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        // Hàm xóa sản phẩm vào database
        public bool Delete_Products(int idFood)
        {
            Bill_Information_DA.Instance.DeleteBillInfoByFoodID(idFood);

            string query = string.Format("Delete Products where Id_Products = {0}", idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
