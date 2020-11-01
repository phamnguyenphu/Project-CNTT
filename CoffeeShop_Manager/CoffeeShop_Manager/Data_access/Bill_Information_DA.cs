using CoffeeShop_Manager.Data_transfer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop_Manager.Data_access
{
    public class Bill_Information_DA
    {
        private static Bill_Information_DA instance;

        public static Bill_Information_DA Instance
        {
            get { if (instance == null) instance = new Bill_Information_DA(); return Bill_Information_DA.instance; }
            private set { Bill_Information_DA.instance = value; }
        }

        private Bill_Information_DA() { }

        public List<Bill_Information> GetListBillInfo(int id)
        {
            List<Bill_Information> listBillInfo = new List<Bill_Information>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill_Information WHERE Id_Bill_Status = " + id);

            foreach (DataRow item in data.Rows)
            {
                Bill_Information bill_information = new Bill_Information(item);
                listBillInfo.Add(bill_information);
            }

            return listBillInfo;
        }


        // Hàm insert bill_information từ clint sang database
        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("Bill_Information_Insert @idBill , @idFood , @count", new object[] { idBill, idFood, count });
        }
        // Hàm xóa dữ liệu sản phẩm 
        public void DeleteBillInfoByFoodID(int id)
        {
            DataProvider.Instance.ExecuteQuery("delete dbo.Bill_Information WHERE Id_Products = " + id);
        }
    }
}
