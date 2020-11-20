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
        public void Pay_Table_Customer(int id, float totalPrice)
        {
            string query = "UPDATE dbo.Bill_Status SET Time_Checkout = GETDATE(), Status_bill = 1 " + ", totalPrice = " + totalPrice + " WHERE Id_Bill_Status = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
             
        }

        public DataTable Danhsachbill_theothoigian(DateTime checkin, DateTime checkout)
        {
            return DataProvider.Instance.ExecuteQuery("exec GetListBillByTime @checkin , @checkout", new object[] { checkin, checkout });
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
