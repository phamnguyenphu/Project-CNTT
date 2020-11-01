using CoffeeShop_Manager.Data_transfer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop_Manager.Data_access
{
    public class Table_CustomerDA
    {
        private static Table_CustomerDA instance;

        public static Table_CustomerDA Instance
        {
            get { if (instance == null) instance = new Table_CustomerDA(); return Table_CustomerDA.instance; }
            private set { Table_CustomerDA.instance = value; }
        }

        public static int TableWidth = 120;
        public static int TableHeight = 100;

        private Table_CustomerDA() { }

        public List<Table_Customer> LoadTableList()
        {
            List<Table_Customer> tableList = new List<Table_Customer>();

            DataTable data = DataProvider.Instance.ExecuteQuery("GetTable_Customer");

            foreach (DataRow item in data.Rows)
            {
                Table_Customer table = new Table_Customer(item);
                tableList.Add(table);
            }

            return tableList;
        }
        public List<Table_Customer> GetListTable()
        {
            List<Table_Customer> list = new List<Table_Customer>();

            string query = "select * from Table_Customer";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Table_Customer table_Customer = new Table_Customer(item);
                list.Add(table_Customer);
            }

            return list;

        }

        //Hàm thêm bàn
        public bool Insert_Table_Customer(string name)
        {
            string query = string.Format("INSERT dbo.Table_Customer ( Name_Table )VALUES  ( N'{0}')", name );
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }


        // Hàm chỉnh sửa thông tin bàn 
        public bool Update_Table_Customer(string name, int id)
        {
            string query = string.Format("UPDATE dbo.Table_Customer SET Name_Table = N'{0}' WHERE Id_Table = {1}", name, id );
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        // Hàm xóa thông tin bàn
        public bool Delete_Table_Customer(int idTable)
        {
 

            string query = string.Format("Delete Table_Customer where Id_Table = {0}", idTable);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
