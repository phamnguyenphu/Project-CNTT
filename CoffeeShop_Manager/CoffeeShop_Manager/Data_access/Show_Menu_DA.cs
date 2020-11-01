using CoffeeShop_Manager.Data_transfer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop_Manager.Data_access
{
    public class Show_Menu_DA
    {
        private static Show_Menu_DA instance;

        public static Show_Menu_DA Instance
        {
            get { if (instance == null) instance = new Show_Menu_DA(); return Show_Menu_DA.instance; }
            private set { Show_Menu_DA.instance = value; }
        }

        private Show_Menu_DA() { }

        public List<Show_Menu> GetListMenuByTable(int id)
        {
            List<Show_Menu> listMenu = new List<Show_Menu>();

            string query = "SELECT f.Name_Products, bi.count, f.Products_price, f.Products_price*bi.count AS totalPrice FROM dbo.Bill_Information AS bi, dbo.Bill_Status AS b, dbo.Products AS f WHERE bi.Id_Bill_Status = b.Id_Bill_Status AND bi.Id_Products = f.Id_Products AND b.Status_bill = 0  AND b.Id_Table = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Show_Menu menu = new Show_Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
