using CoffeeShop_Manager.Data_access;
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
    public partial class Table_Manager : Form
    {
        BindingSource bindingTable = new BindingSource();
        public Table_Manager()
        {
            InitializeComponent();
            Load_Table_customer();
            addBindingTable();
        }

        void Load_Table_customer()
        {
            dtgv_Table.DataSource = bindingTable;
            bindingTable.DataSource = Table_CustomerDA.Instance.GetListTable();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string name = txt_Table_Name.Text;
           

            if (Table_CustomerDA.Instance.Insert_Table_Customer(name))
            {
                MessageBox.Show("Thực hiện thêm thông tin bàn thành công");
                Load_Table_customer();

            }
            else
            {
                MessageBox.Show("Thực hiện việc thêm thông tin bàn không đúng");
            }
        }

        // Hàm xử lí sửa thông tin bàn
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string name = txt_Table_Name.Text;
            int id = Convert.ToInt32(txt_Table_ID.Text);

            if (Table_CustomerDA.Instance.Update_Table_Customer(name, id))
            {
                MessageBox.Show("Thực hiện sửa thông tin bàn thành công");
                Load_Table_customer();

            }
            else
            {
                MessageBox.Show("Thực hiện việc sửa thông tin bàn không đúng");
            }
        }


        // Hàm xử lí xóa thông tin bàn 
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_Table_ID.Text);

            if (Table_CustomerDA.Instance.Delete_Table_Customer(id))
            {
                MessageBox.Show("Thực hiện xóa thông tin bàn thành công");
                Load_Table_customer();

            }
            else
            {
                MessageBox.Show("Thực hiện việc xóa thông tin bàn không đúng");
            }
        }

        //Add binding

        void addBindingTable()
        {
            txt_Table_Name.DataBindings.Add(new Binding("Text", dtgv_Table.DataSource, "Name"));
            txt_Table_ID.DataBindings.Add(new Binding("Text", dtgv_Table.DataSource, "ID"));
        }
    }
}
