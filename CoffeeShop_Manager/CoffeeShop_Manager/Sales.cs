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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
            LoadDateTimePicker();
            Load_DanhsachBill(dtpkDateStart.Value, dtpkDateEnd.Value);
        }


        void LoadDateTimePicker()
        {
            DateTime today = DateTime.Now;
            dtpkDateStart.Value = new DateTime(today.Year, today.Month, 1);
            dtpkDateEnd.Value = dtpkDateStart.Value.AddMonths(1).AddDays(-1);
        }
        void Load_DanhsachBill(DateTime checkin, DateTime checkout)
        {
            dtgvBill.DataSource = Data_access.Bill_Status_DA.Instance.Danhsachbill_theothoigian(checkin, checkout);
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Xử lí sự kiện khi click vào button List sẽ liệt kê ra danh sách bill theo 2 time start và end
        private void btn_List_Click(object sender, EventArgs e)
        {
            Load_DanhsachBill(dtpkDateStart.Value, dtpkDateEnd.Value);
        }
    }
}
