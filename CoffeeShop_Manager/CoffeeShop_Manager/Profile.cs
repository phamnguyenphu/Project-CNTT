using CoffeeShop_Manager.Data_access;
using CoffeeShop_Manager.Data_transfer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop_Manager
{
    public partial class Profile : Form
    {
        private Account_User loginAccount;

        public Account_User LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; KiemTraTk_admin_or_staff(loginAccount); }
        }
        public Profile(Account_User account)
        {
            InitializeComponent();
            LoginAccount = account;
        }
        void KiemTraTk_admin_or_staff(Account_User account)
        {
            txt_Username.Text = account.UserName;
            txt_Display.Text = account.DisplayName;

        }

        void CapNhatChinhSuaThongTinTK()
        {
            string userName = txt_Username.Text;
            string displayName = txt_Display.Text;
            string password = txt_Password.Text;
            string newPassword = txt_NewPassword.Text;
            string reEnterPassword = txt_ReEnter.Text;

            if (newPassword != reEnterPassword)
            {
                MessageBox.Show("Mật khẩu mới không khớp với mật khẩu hiện tại");
            }
            else
            {
                if (Account_UserDA.Instance.CapNhatThongTinTk(userName, displayName, password, newPassword))
                {
                    MessageBox.Show("Cập nhật thông tin thành công");
                    if (capNhatThongTinTaiKhoan != null)
                        capNhatThongTinTaiKhoan(this, new AccountEvent (Account_UserDA.Instance.Lay_thong_tin_tk_byUserName(userName)));
                }
                else
                {
                    MessageBox.Show("Nhập mật khẩu hoặc mật khẩu không chính xác");
                }    
            }    
        }

        private event EventHandler<AccountEvent> capNhatThongTinTaiKhoan;
        public event EventHandler<AccountEvent> CapNhatThongTinTaiKhoan
        {
            add { capNhatThongTinTaiKhoan += value; }
            remove { capNhatThongTinTaiKhoan -= value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_acc_Click(object sender, EventArgs e)
        {
            CapNhatChinhSuaThongTinTK();
        }
    }

// hàm tham khảo howkteam
    public class AccountEvent:EventArgs
    {
        private Account_User acc;

        public Account_User Acc
        {
            get { return acc; }
            set { acc = value; }
        }

        public AccountEvent(Account_User acc)
        {
            this.Acc = acc;
        }
    }
}
