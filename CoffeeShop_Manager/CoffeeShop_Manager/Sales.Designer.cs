namespace CoffeeShop_Manager
{
    partial class Sales
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.dtpkDateStart = new System.Windows.Forms.DateTimePicker();
            this.dtpkDateEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpkDa = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_List = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvBill);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 506);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.btn_List);
            this.panel2.Controls.Add(this.btn_Exit);
            this.panel2.Controls.Add(this.dtpkDa);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtpkDateEnd);
            this.panel2.Controls.Add(this.dtpkDateStart);
            this.panel2.Location = new System.Drawing.Point(7, 423);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 77);
            this.panel2.TabIndex = 0;
            // 
            // dtgvBill
            // 
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(7, 7);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.Size = new System.Drawing.Size(863, 411);
            this.dtgvBill.TabIndex = 1;
            // 
            // dtpkDateStart
            // 
            this.dtpkDateStart.Location = new System.Drawing.Point(3, 40);
            this.dtpkDateStart.Name = "dtpkDateStart";
            this.dtpkDateStart.Size = new System.Drawing.Size(269, 20);
            this.dtpkDateStart.TabIndex = 0;
            // 
            // dtpkDateEnd
            // 
            this.dtpkDateEnd.Location = new System.Drawing.Point(276, 40);
            this.dtpkDateEnd.Name = "dtpkDateEnd";
            this.dtpkDateEnd.Size = new System.Drawing.Size(255, 20);
            this.dtpkDateEnd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date Start";
            // 
            // dtpkDa
            // 
            this.dtpkDa.AutoSize = true;
            this.dtpkDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDa.Location = new System.Drawing.Point(273, 10);
            this.dtpkDa.Name = "dtpkDa";
            this.dtpkDa.Size = new System.Drawing.Size(58, 15);
            this.dtpkDa.TabIndex = 3;
            this.dtpkDa.Text = "Date End";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Exit.Location = new System.Drawing.Point(710, 10);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(140, 50);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_List
            // 
            this.btn_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.btn_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_List.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_List.Location = new System.Drawing.Point(555, 10);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(140, 50);
            this.btn_List.TabIndex = 8;
            this.btn_List.Text = "List";
            this.btn_List.UseVisualStyleBackColor = false;
            // 
            // Sales
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 517);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales";
            this.Text = "Sales";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label dtpkDa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpkDateEnd;
        private System.Windows.Forms.DateTimePicker dtpkDateStart;
        private System.Windows.Forms.Button btn_List;
        private System.Windows.Forms.Button btn_Exit;
    }
}