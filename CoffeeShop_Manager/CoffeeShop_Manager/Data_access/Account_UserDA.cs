using CoffeeShop_Manager.Data_transfer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop_Manager.Data_access
{
    public class Account_UserDA
    {
        private static Account_UserDA instance;

        public static Account_UserDA Instance
        {
            get { if (instance == null) instance = new Account_UserDA(); return instance; }
            private set { instance = value; }
        }

        private Account_UserDA() { }

        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });

            return result.Rows.Count > 0;
        }

        public Account_User Lay_thong_tin_tk_byUserName(string userName)
        {
            DataTable data =  DataProvider.Instance.ExecuteQuery("Select * from Account_User where UserName_AccountUser = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account_User(item);
            }
            return null;
        }
        public bool CapNhatThongTinTk(string userName, string displayName, string password, string newPassword)
        {
            int data = DataProvider.Instance.ExecuteNonQuery("exec UpdateAccountUser @userName , @displayName , @password , @newPassword", new object[] { userName, displayName, password, newPassword });
            return data > 0;
        }
    }
}
