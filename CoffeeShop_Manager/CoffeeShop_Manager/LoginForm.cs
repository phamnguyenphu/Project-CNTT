using CoffeeShop_Manager.Data_access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop_Manager
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            
            InitializeComponent();
            //setting color ban đầu username, password
            txt_UserName.ForeColor = Color.DimGray;
            txt_Password.ForeColor = Color.DimGray;
        }

        private void Turn_off_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }
       

        private void txt_UserName_Enter(object sender, EventArgs e)
        {
           
            if (txt_UserName.Text == "User name")
            {
                txt_UserName.Text = "";
                txt_UserName.ForeColor = Color.Black;
            }
        }

        private void txt_UserName_Leave(object sender, EventArgs e)
        {
            if (txt_UserName.Text == "")
            {
                txt_UserName.Text = "User name";
            }
            txt_UserName.ForeColor = Color.DimGray; 
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            if (txt_Password.Text == "Password")
            {
                txt_Password.Text = "";
                txt_Password.ForeColor = Color.Black;
                txt_Password.UseSystemPasswordChar = true;
            }    
        }

        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if (txt_Password.Text =="")
            {
                txt_Password.UseSystemPasswordChar = false;
                txt_Password.Text = "Password";
                txt_Password.ForeColor = Color.DimGray;

            }    
        }

        // Điều kiện xác nhận có chắc chắn thoát chương trình hay không? --> Thoát form
        private void Login_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        // ----------------------------------------------------------------------------------------------------------------------
        //                                          CHỨC NĂNG ĐĂNG NHẬP
        //Load form Main_manager khi click button Login và kiểm tra điều kiện đúng hay sai tài khoản mật khẩu ở database
        // User 1: phamnguyenphu -- pass: nguyenphu2
        // User 2: 
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string userName = txt_UserName.Text;
            string passWord = txt_Password.Text;
            if (Login(userName,passWord))
            {
                Data_transfer.Account_User loginAccount = Account_UserDA.Instance.Lay_thong_tin_tk_byUserName(userName);
                Main_Manager form_main_manager = new Main_Manager(loginAccount);
                this.Hide();
                form_main_manager.ShowDialog();
                this.Show();
            }    
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mẩu khẩu. Vui lòng thử lại!", "Notice");

            }    
           
        }


        // Kiểm tra hàm login account user
        bool Login(string userName, string passWord)
        {
            return Account_UserDA.Instance.Login(userName, passWord);
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // ---------------------------------------------------------------------------------------------------------------------------


    }
}
