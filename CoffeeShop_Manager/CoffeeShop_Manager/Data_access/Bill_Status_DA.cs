using CoffeeShop_Manager.Data_transfer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop_Manager.Data_access
{
    public class Bill_Status_DA
    {
        private static Bill_Status_DA instance;

        public static Bill_Status_DA Instance
        {
            get { if (instance == null) instance = new Bill_Status_DA(); return Bill_Status_DA.instance; }
            private set { Bill_Status_DA.instance = value; }
        }

        private Bill_Status_DA() { }

       
        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill_Status WHERE Id_Table = " + id + " AND Status_bill = 0");

            if (data.Rows.Count > 0)
            {
                Bill_Status bill_status = new Bill_Status(data.Rows[0]);
                return bill_status.ID;
            }

            return -1;
        }


        // Hàm xử lí thanh toán, sử dụng để update bàn lại trạng thái ban đầu sau khi thanh toán
        public void Pay_Table_Customer(int id)
        {
            string query = "UPDATE dbo.Bill_Status SET Status_bill = 1 WHERE Id_Bill_Status = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
            
            //string query1 = "DELETE dbo.Bill_Information WHERE Id_Bill_Status = " + id;
            //DataProvider.Instance.ExecuteNonQuery(query1);
        }


        // Hàm insert bill mới từ client sang database
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec Bill_Insert @idTable", new object[] { id });
        }

        // 
        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(Id_Bill_Status) FROM dbo.Bill_Status");
            }
            catch
            {
                return 1;
            }
        }

        
    }
}
