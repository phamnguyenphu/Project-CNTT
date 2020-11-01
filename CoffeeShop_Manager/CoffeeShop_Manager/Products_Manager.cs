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
    public partial class Products_Manager : Form
    {
        public Products_Manager()
        {
            InitializeComponent();
            Load_Products();
            Load_Products_Category_Into_Combobox(cmb_Category);
        }
        void Load_Products()
        {
            dtgv_Products.DataSource = Products_DA.Instance.Get_List_Products();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Hàm load products category
        void Load_Products_Category_Into_Combobox(ComboBox cb)
        {
            cb.DataSource = Products_Category_DA.Instance.Get_List_Products_Category();
            cb.DisplayMember = "Name";
        }

        // Hàm xử lí sự kiện khi muốn thêm products vào database
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string name = txt_Products_Name.Text;
            int categoryID = (cmb_Category.SelectedItem as Products_Category).ID;
            float price = (float)nbr_Products_Price.Value;

            if (Products_DA.Instance.Insert_Products(name, categoryID, price))
            {
                MessageBox.Show("Thực hiện thêm sản phẩm thành công");
                Load_Products();
                
            }
            else
            {
                MessageBox.Show("Thực hiện việc thêm sản phẩm không đúng");
            }
        }

        // Hàm xử lí sự kiện sửa sản phẩm products vào database

        private void btn_Edit_Click_1(object sender, EventArgs e)
        {
            string name = txt_Products_Name.Text;
            int categoryID = (cmb_Category.SelectedItem as Products_Category).ID;
            float price = (float)nbr_Products_Price.Value;
            int id = Convert.ToInt32(txt_Products_ID.Text);

            if (Products_DA.Instance.Update_Products(id, name, categoryID, price))
            {
                MessageBox.Show("Thực hiện sửa sản phẩm thành công");
                Load_Products();
               
            }
            else
            {
                MessageBox.Show("Thực hiện việc sửa sản phẩm không đúng");
            }
        }

        // Hàm xử lí sự kiện xóa sản phẩm products vào database
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_Products_ID.Text);

            if (Products_DA.Instance.Delete_Products(id))
            {
                MessageBox.Show("Thực hiện xóa sản phẩm thành công");
                Load_Products();
               
            }
            else
            {
                MessageBox.Show("Thực hiện việc xóa sản phẩm không đúng");
            }
        }
    }
}
