namespace CoffeeShop_Manager
{
    partial class Main_Manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Manager));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lsv_Bill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Thanhtoan = new System.Windows.Forms.Button();
            this.txt_Total_Price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Table_Manager = new System.Windows.Forms.Button();
            this.btn_Products_Manager = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nmr_Add_Count = new System.Windows.Forms.NumericUpDown();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.cmb_Products = new System.Windows.Forms.ComboBox();
            this.cmb_Products_Category = new System.Windows.Forms.ComboBox();
            this.flp_Table_Customer = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Add_Count)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lsv_Bill);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 108);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(612, 418);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // lsv_Bill
            // 
            this.lsv_Bill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsv_Bill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsv_Bill.Cursor = System.Windows.Forms.Cursors.Default;
            this.lsv_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv_Bill.HideSelection = false;
            this.lsv_Bill.Location = new System.Drawing.Point(3, 3);
            this.lsv_Bill.Name = "lsv_Bill";
            this.lsv_Bill.Size = new System.Drawing.Size(609, 415);
            this.lsv_Bill.TabIndex = 0;
            this.lsv_Bill.UseCompatibleStateImageBehavior = false;
            this.lsv_Bill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 195;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Count";
            this.columnHeader2.Width = 105;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 153;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 144;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.btn_Thanhtoan);
            this.panel2.Controls.Add(this.txt_Total_Price);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(11, 540);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 64);
            this.panel2.TabIndex = 4;
            // 
            // btn_Thanhtoan
            // 
            this.btn_Thanhtoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.btn_Thanhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thanhtoan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Thanhtoan.Location = new System.Drawing.Point(469, 3);
            this.btn_Thanhtoan.Name = "btn_Thanhtoan";
            this.btn_Thanhtoan.Size = new System.Drawing.Size(140, 58);
            this.btn_Thanhtoan.TabIndex = 5;
            this.btn_Thanhtoan.Text = "Pay";
            this.btn_Thanhtoan.UseVisualStyleBackColor = false;
            this.btn_Thanhtoan.Click += new System.EventHandler(this.btn_Thanhtoan_Click);
            // 
            // txt_Total_Price
            // 
            this.txt_Total_Price.Location = new System.Drawing.Point(86, 20);
            this.txt_Total_Price.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Total_Price.Name = "txt_Total_Price";
            this.txt_Total_Price.ReadOnly = true;
            this.txt_Total_Price.Size = new System.Drawing.Size(228, 20);
            this.txt_Total_Price.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tổng tiền";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.Minimize);
            this.panel3.Controls.Add(this.btn_Logout);
            this.panel3.Controls.Add(this.btn_Table_Manager);
            this.panel3.Controls.Add(this.btn_Products_Manager);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1205, 100);
            this.panel3.TabIndex = 5;
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minimize.BackgroundImage")));
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimize.Location = new System.Drawing.Point(1171, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(22, 20);
            this.Minimize.TabIndex = 14;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Logout.Location = new System.Drawing.Point(683, 25);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(140, 50);
            this.btn_Logout.TabIndex = 3;
            this.btn_Logout.Text = "Log out";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click_1);
            // 
            // btn_Table_Manager
            // 
            this.btn_Table_Manager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.btn_Table_Manager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Table_Manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Table_Manager.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Table_Manager.Location = new System.Drawing.Point(483, 25);
            this.btn_Table_Manager.Name = "btn_Table_Manager";
            this.btn_Table_Manager.Size = new System.Drawing.Size(140, 50);
            this.btn_Table_Manager.TabIndex = 2;
            this.btn_Table_Manager.Text = "Table";
            this.btn_Table_Manager.UseVisualStyleBackColor = false;
            this.btn_Table_Manager.Click += new System.EventHandler(this.btn_Table_Manager_Click);
            // 
            // btn_Products_Manager
            // 
            this.btn_Products_Manager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.btn_Products_Manager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Products_Manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Products_Manager.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Products_Manager.Location = new System.Drawing.Point(283, 25);
            this.btn_Products_Manager.Name = "btn_Products_Manager";
            this.btn_Products_Manager.Size = new System.Drawing.Size(140, 50);
            this.btn_Products_Manager.TabIndex = 1;
            this.btn_Products_Manager.Text = "Products ";
            this.btn_Products_Manager.UseVisualStyleBackColor = false;
            this.btn_Products_Manager.Click += new System.EventHandler(this.btn_Products_Manager_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Coffee Manager";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Controls.Add(this.nmr_Add_Count);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.btn_Select);
            this.panel4.Controls.Add(this.cmb_Products);
            this.panel4.Controls.Add(this.cmb_Products_Category);
            this.panel4.Location = new System.Drawing.Point(683, 105);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(522, 77);
            this.panel4.TabIndex = 0;
            // 
            // nmr_Add_Count
            // 
            this.nmr_Add_Count.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nmr_Add_Count.Location = new System.Drawing.Point(409, 45);
            this.nmr_Add_Count.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmr_Add_Count.Name = "nmr_Add_Count";
            this.nmr_Add_Count.Size = new System.Drawing.Size(101, 16);
            this.nmr_Add_Count.TabIndex = 17;
            this.nmr_Add_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(409, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(101, 36);
            this.button7.TabIndex = 16;
            this.button7.Text = "Add count";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btn_Select
            // 
            this.btn_Select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.btn_Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Select.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Select.Location = new System.Drawing.Point(288, 3);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(115, 66);
            this.btn_Select.TabIndex = 15;
            this.btn_Select.Text = "Select ";
            this.btn_Select.UseVisualStyleBackColor = false;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // cmb_Products
            // 
            this.cmb_Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Products.FormattingEnabled = true;
            this.cmb_Products.Location = new System.Drawing.Point(3, 45);
            this.cmb_Products.Name = "cmb_Products";
            this.cmb_Products.Size = new System.Drawing.Size(279, 24);
            this.cmb_Products.TabIndex = 1;
            // 
            // cmb_Products_Category
            // 
            this.cmb_Products_Category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Products_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Products_Category.FormattingEnabled = true;
            this.cmb_Products_Category.Location = new System.Drawing.Point(3, 3);
            this.cmb_Products_Category.Name = "cmb_Products_Category";
            this.cmb_Products_Category.Size = new System.Drawing.Size(279, 24);
            this.cmb_Products_Category.TabIndex = 0;
            this.cmb_Products_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Products_Category_SelectedIndexChanged);
            // 
            // flp_Table_Customer
            // 
            this.flp_Table_Customer.AutoScroll = true;
            this.flp_Table_Customer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flp_Table_Customer.Location = new System.Drawing.Point(683, 197);
            this.flp_Table_Customer.Name = "flp_Table_Customer";
            this.flp_Table_Customer.Size = new System.Drawing.Size(522, 418);
            this.flp_Table_Customer.TabIndex = 6;
            // 
            // Main_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1205, 615);
            this.Controls.Add(this.flp_Table_Customer);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Manager";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Add_Count)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Total_Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Table_Manager;
        private System.Windows.Forms.Button btn_Products_Manager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.ListView lsv_Bill;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.ComboBox cmb_Products;
        private System.Windows.Forms.ComboBox cmb_Products_Category;
        private System.Windows.Forms.Button btn_Thanhtoan;
        private System.Windows.Forms.NumericUpDown nmr_Add_Count;
        private System.Windows.Forms.FlowLayoutPanel flp_Table_Customer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}