using CoffeeShop_Manager.Data_access;
using CoffeeShop_Manager.Data_transfer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop_Manager
{
    public partial class Main_Manager : Form
    {
        public Main_Manager()
        {
            InitializeComponent();

            // Load dữ liệu bảng table_customer lên form
            Load_Table_Customer();

            // Load dữ liệu vào comboBox Products_Category để select thể loại món
            Load_Products_Category();

          
        }

        // Định nghĩa hàm
        // Hàm load table customer
        void Load_Table_Customer()
        {
            flp_Table_Customer.Controls.Clear();
            List<Table_Customer> tableList = Table_CustomerDA.Instance.LoadTableList();

            
            foreach (Table_Customer item in tableList)
            {
                Button btn_Table_Customer = new Button()  { Width = Table_CustomerDA.TableWidth, Height = Table_CustomerDA.TableHeight };
                btn_Table_Customer.FlatStyle = FlatStyle.Flat;
                btn_Table_Customer.ForeColor = Color.White;

                btn_Table_Customer.Text = item.Name + Environment.NewLine + item.Status + Environment.NewLine;
                btn_Table_Customer.Click += Btn_Table_Customer_Click;           
                btn_Table_Customer.Tag = item;


                switch (item.Status)
                {
                    case "Bàn trống":
                        {
                            btn_Table_Customer.BackColor = Color.FromArgb(0, 200, 83);
                            btn_Table_Customer.Image = Image.FromFile("C:/Users/phamn/OneDrive/Máy tính/ĐỒ ÁN CNTT/Project CNTT/CoffeeShop_Manager/CoffeeShop_Manager/img/icons8-checkmark-yes-32.png");
                            btn_Table_Customer.ImageAlign = ContentAlignment.BottomCenter;
                            break;
                        }
                        
                        
                    case "Bàn có người":
                        {
                            btn_Table_Customer.BackColor = Color.Red;
                            btn_Table_Customer.Image = Image.FromFile("C:/Users/phamn/OneDrive/Máy tính/ĐỒ ÁN CNTT/Project CNTT/CoffeeShop_Manager/CoffeeShop_Manager/img/icons8-no-entry-32.png");
                            btn_Table_Customer.ImageAlign = ContentAlignment.BottomCenter;
                            break;
                        }
                }

                flp_Table_Customer.Controls.Add(btn_Table_Customer);
            }
        }

        private void Btn_Table_Customer_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table_Customer).ID;
            lsv_Bill.Tag = (sender as Button).Tag;
            HienThi_HoaDon(tableID);
        }


        // Hàm Load dữ liệu vào comboBox của Products_Category
        void Load_Products_Category()
        {
            List<Products_Category> listCategory = Products_Category_DA.Instance.Get_List_Products_Category();
            cmb_Products_Category.DataSource = listCategory;
            cmb_Products_Category.DisplayMember = "Name";
        }

        // Hàm Load dữ liệu vào comboBox của Products theo các lựa chọn của Products_Category
        void Load_Products(int id)
        {
            List<Products> listFood = Products_DA.Instance.Get_Products_By_CategoryID(id);
            cmb_Products.DataSource = listFood;
            cmb_Products.DisplayMember = "Name";
        }

        // Hàm bắt sự kiện khi select vào 1 thể loại món thì sẽ load lên dữ liệu của Products tương ứng
        private void cmb_Products_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cmb = sender as ComboBox;
            if (cmb.SelectedItem == null)
                return;

            Products_Category selected = cmb.SelectedItem as Products_Category;
            id = selected.ID;

            Load_Products(id);
        }

        // Hàm để hiển thị bill khi tương tác như: select products -> Hiển thị các thông tin chi tiết hóa đơn của 1 bàn khi select products
        void HienThi_HoaDon(int id)
        {
            lsv_Bill.Items.Clear();
            List<Show_Menu> listBillInfo = Show_Menu_DA.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (Show_Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsv_Bill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            //Thread.CurrentThread.CurrentCulture = culture;

            txt_Total_Price.Text = totalPrice.ToString("c", culture);
            
        }


        // Hàm xử lí sự kiện khi click select chọn products --> INSert bill mới vào database
        private void btn_Select_Click(object sender, EventArgs e)
        {
            Table_Customer table_customer = lsv_Bill.Tag as Table_Customer;

            int idBill = Bill_Status_DA.Instance.GetUncheckBillIDByTableID(table_customer.ID);
            int foodID = (cmb_Products.SelectedItem as Products).ID;
            int count = (int)nmr_Add_Count.Value;

            if (idBill == -1)
            {
                Bill_Status_DA.Instance.InsertBill(table_customer.ID);
                Bill_Information_DA.Instance.InsertBillInfo(Bill_Status_DA.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                Bill_Information_DA.Instance.InsertBillInfo(idBill, foodID, count);
            }

            HienThi_HoaDon(table_customer.ID);
            Load_Table_Customer();
        }


        // hàm xử lí sự kiện khi click vào button pay ( thanh toán ) hóa đơn, đồng thời xóa dữ liệu hiện tại ở bàn đấy
        private void btn_Thanhtoan_Click(object sender, EventArgs e)
        {
            Table_Customer table_customer = lsv_Bill.Tag as Table_Customer;

            int idBill = Bill_Status_DA.Instance.GetUncheckBillIDByTableID(table_customer.ID);

            if (idBill != -1)
            {
                if (MessageBox.Show("Bạn có chắc thanh toán hóa đơn cho bàn " + table_customer.Name, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    Bill_Status_DA.Instance.Pay_Table_Customer(idBill);
                    HienThi_HoaDon(table_customer.ID);
                    
                    Load_Table_Customer();
                }
            }
        }



        // Click vào form Products manager
        private void btn_Products_Manager_Click(object sender, EventArgs e)
        {
            Products_Manager form_products_manager = new Products_Manager();
            form_products_manager.ShowDialog();

        }

       

        private void btn_Table_Manager_Click(object sender, EventArgs e)
        {
            Table_Manager table_Manager = new Table_Manager();
            table_Manager.ShowDialog();
        }

        private void btn_Logout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
